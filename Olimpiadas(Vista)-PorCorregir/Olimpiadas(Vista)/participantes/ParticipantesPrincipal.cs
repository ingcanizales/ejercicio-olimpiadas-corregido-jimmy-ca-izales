using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador.participantes;
using Controlador.paises;

namespace Olimpiadas_Vista_.participantes
{
    public partial class ParticipantesPrincipal : Form
    {
        ParticipantesDTO participantesDTO = null;
        ParticipantesDAO participantesDAO = null;
        DataTable dataTable = null;

        PaisesDTO paisesDTO = null;
        PaisesDAO paisesDAO = null;
        DataTable datatablePaises = null;

        public ParticipantesPrincipal()
        {
            InitializeComponent();
            listarParticipantes();
            listarPaises();
            cmbpaises.SelectedIndex = 0;
        }

        private void listarPaises()
        {
            paisesDTO = new PaisesDTO();
            paisesDAO = new PaisesDAO(paisesDTO);

            datatablePaises = new DataTable();
            datatablePaises = paisesDAO.ListarPaises();

            if (datatablePaises.Rows.Count > 0)
            {
                cmbpaises.DataSource = datatablePaises;

                DataRow dataRow = datatablePaises.NewRow();
                dataRow["nombrepais"] = "Seleccione..";
                datatablePaises.Rows.InsertAt(dataRow,0);

                cmbpaises.DisplayMember = "nombrepais";
                cmbpaises.ValueMember = "idpais";
            }
            else
            {
                MessageBox.Show("No hay paises para mostrar");
            }
        }

        private void listarParticipantes()
        {
            participantesDTO = new ParticipantesDTO();
            participantesDAO = new ParticipantesDAO(participantesDTO);

            dataTable = new DataTable();
            dataTable = participantesDAO.ListarParticipantes();

            if (dataTable.Rows.Count > 0)
            {
                dtparticipantes.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No hay participantes para mostrar");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void guardarNuevoParticipante()
        {
            if (cmbpaises.SelectedIndex == 0) {
                MessageBox.Show("Debe seleccionar un pais");
            } else {

                participantesDTO = new ParticipantesDTO();
                participantesDTO.setNumerodocumento(long.Parse(txtnumerodocumento.Text));
                participantesDTO.setNombreparticipante(txtnombreparticipantes.Text);
                participantesDTO.setIdpais(byte.Parse(cmbpaises.SelectedValue.ToString()));
                participantesDAO = new ParticipantesDAO(participantesDTO);
                
                participantesDAO.guardarNuevoParticipante();

                MessageBox.Show("Registro Exitoso");

            }    
        }


        private void guardarCambiosParticipantes() {
            participantesDTO = new ParticipantesDTO();
            participantesDTO.setNumerodocumento(long.Parse(txtnumerodocumento.Text));
            participantesDTO.setNombreparticipante(txtnombreparticipantes.Text);
            


            if (cmbpaises.SelectedIndex == 0)
            {
                participantesDTO.setIdpais(0);
            }
            else
            {
                participantesDTO.setIdpais(byte.Parse(cmbpaises.SelectedValue.ToString()));
            }

            participantesDAO = new ParticipantesDAO(participantesDTO);

            participantesDAO.guardarCambiosParticipantes();

            MessageBox.Show("Registro modificado Exitosamente");
        }

        private void btnnuevoparticipante_Click(object sender, EventArgs e)
        {
            this.guardarNuevoParticipante();
            this. listarParticipantes();
            this.cancelar();
        }

        private void cancelar()
        {
                
            lblnuevoparticipante.Location = new Point(34, 90);
            lblmodificarparticipantes.Location = new Point(219, 90);
            lblnuevoparticipante.Visible = true;
            lblmodificarparticipantes.Visible = false;
            btnnuevoparticipante.Enabled = true;
            btnguardarcambios.Enabled = false;
            btncancelar.Visible = false;
            txtnumerodocumento.Enabled = true;
            txtnumerodocumento.Text = String.Empty;
            txtnumerodocumento.Focus();
            txtnombreparticipantes.Text = String.Empty;
            cmbpaises.SelectedIndex = 0;
            lblpaisdelparticipante.Visible = false;
                }

        private void dtparticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnumerodocumento.Text = dtparticipantes.Rows[dtparticipantes.CurrentRow.Index].Cells[0].Value.ToString();
            txtnumerodocumento.Enabled = false;
            txtnombreparticipantes.Text = dtparticipantes.Rows[dtparticipantes.CurrentRow.Index].Cells[1].Value.ToString();
            lblpaisdelparticipante.Text = dtparticipantes.Rows[dtparticipantes.CurrentRow.Index].Cells[2].Value.ToString();
            lblpaisdelparticipante.Visible = true;

            btnnuevoparticipante.Enabled = false;
            btnguardarcambios.Enabled = true;
            btncancelar.Visible = true;
            lblnuevoparticipante.Location = new Point(219, 90); 
            lblmodificarparticipantes.Location = new Point(34, 90);
            lblnuevoparticipante.Visible = false;
            lblmodificarparticipantes.Visible = true;


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            guardarCambiosParticipantes();
            listarParticipantes();
            cancelar();
        }

        private void dtparticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
