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
using Controlador.posiciones;
using Controlador.resultados;

namespace Olimpiadas_Vista_.resultados
{
    public partial class ResultadosPrincipal : Form
    {
        ParticipantesDTO participantesDTO = null;
        ParticipantesDAO participantesDAO = null;
        DataTable dataTable = null;

        PaisesDTO paisesDTO = null;
        PaisesDAO paisesDAO = null;
        DataTable datatablePaises = null;

        PosicionesDTO posicionesDTO = null;
        PosicionesDAO posicionesDAO = null;
        DataTable datatablePosiciones = null;

        ResultadosDTO resultadosDTO = null;
        ResultadosDAO resultadosDAO = null;
        DataTable datatableResultados = null;

        private void listarParticipantes() {
            participantesDTO = new ParticipantesDTO();
            participantesDAO = new ParticipantesDAO(participantesDTO);

            dataTable = new DataTable();
            dataTable = participantesDAO.ListarParticipantes();

            if (dataTable.Rows.Count > 0)
            {
                cmbparticipantes.DataSource = dataTable;
                DataRow dataRow = dataTable.NewRow();
                dataRow["nombreparticipante"] = "Seleccione..";
                dataTable.Rows.InsertAt(dataRow, 0);

                cmbparticipantes.DisplayMember = "nombreparticipante";
                cmbparticipantes.ValueMember = "numerodocumento";

                cmbparticipantes.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("No hay participantes para mostrar.");
            }
        }

        private void listarPosiciones()
        {
            posicionesDTO = new PosicionesDTO();
            posicionesDAO = new PosicionesDAO(posicionesDTO);

            datatablePosiciones = new DataTable();
            datatablePosiciones = posicionesDAO.ListarPosiciones();

            if (datatablePosiciones.Rows.Count > 0)
            {
                cmbposicion.DataSource = datatablePosiciones;

                DataRow dataRow = datatablePosiciones.NewRow();
                dataRow["nombreposicion"] = "Seleccione..";
                datatablePosiciones.Rows.InsertAt(dataRow, 0);

                cmbposicion.DisplayMember = "nombreposicion";
                cmbposicion.ValueMember = "idposicion";

                cmbposicion.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No hay posiciones para mostrar.");
            }
        }

        private void listarResultados()
        {
            resultadosDTO = new ResultadosDTO();
            resultadosDAO = new ResultadosDAO(resultadosDTO);

            datatableResultados = new DataTable();
            datatableResultados = resultadosDAO.ListarResultados();
            
            if (datatableResultados.Rows.Count > 0)
            {
                dtresultados.DataSource = datatableResultados;
            }
            else
            {
                MessageBox.Show("No hay resultados para mostrar");
            }
        }

        public ResultadosPrincipal()
        {
            InitializeComponent();
            listarResultados();
            listarParticipantes();
            listarPosiciones();
        }

        private void guardarNuevoResultado()
        {
            if (cmbparticipantes.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un participante");
            }
            else
            {

                resultadosDTO = new ResultadosDTO();
                resultadosDTO.setNumerodocumento(long.Parse(cmbparticipantes.SelectedValue.ToString()));
                resultadosDTO.setNombreparticipante(cmbparticipantes.Text);
                resultadosDTO.setIdposicion(byte.Parse(cmbposicion.SelectedValue.ToString()));

                resultadosDAO = new ResultadosDAO(resultadosDTO);

                resultadosDAO.guardarNuevoResultado();

                MessageBox.Show("Registro Exitoso");

            }
        }

        private void guardarCambiosResultado()
        {
            resultadosDTO = new ResultadosDTO();
            if (cmbposicion.SelectedIndex == 0) {
                resultadosDTO.setNumerodocumento(long.Parse(lblcedulaparticipante.Text));
                resultadosDTO.setIdposicion(0);
            }
            else {
                resultadosDTO.setNumerodocumento(long.Parse(lblcedulaparticipante.Text));
                resultadosDTO.setIdposicion(byte.Parse(cmbposicion.SelectedValue.ToString()));
            }

            resultadosDAO = new ResultadosDAO(resultadosDTO);

            resultadosDAO.guardarCambiosResultados();

            MessageBox.Show("Cambios guardados Exitosamente.");

        }

        private void eliminarResultado()
        {
                resultadosDTO = new ResultadosDTO();
                resultadosDTO.setNumerodocumento(long.Parse(lblcedulaparticipante.Text));

                resultadosDAO = new ResultadosDAO(resultadosDTO);

            resultadosDAO.eliminarResultado();

                MessageBox.Show("Registro eliminado satisfactoriamente.");

        }

        private void cancelar()
        {
            lblnuevoparticipante.Location = new Point(34, 90);
            lblmodificarparticipantes.Location = new Point(219, 90);
            lblnuevoparticipante.Visible = true;
            lblmodificarparticipantes.Visible = false;
            btnnuevoresultado.Enabled = true;
            btnguardarcambios.Enabled = false;
            btncancelar.Visible = false;
            cmbparticipantes.Enabled = true;
            cmbparticipantes.SelectedIndex = 0;
            lblcedulaparticipante.Enabled = false;
            cmbposicion.SelectedIndex = 0;
            lblnombreparticipante.Visible = false;
            lblposicionactual.Visible = false;
            btneliminar.Enabled = false;
        }

        private void btnnuevoresultado_Click(object sender, EventArgs e)
        {
            this.guardarNuevoResultado();
            this.listarResultados();
            this.cancelar();
        }

        private void cmbparticipantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcedulaparticipante.Text = cmbparticipantes.SelectedValue.ToString();
        }

        private void dtresultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbparticipantes.Enabled = false;
            lblnombreparticipante.Visible = true;
            lblcedulaparticipante.Text = dtresultados.Rows[dtresultados.CurrentRow.Index].Cells[0].Value.ToString();
            lblnombreparticipante.Text = dtresultados.Rows[dtresultados.CurrentRow.Index].Cells[1].Value.ToString();
            lblposicionactual.Text = dtresultados.Rows[dtresultados.CurrentRow.Index].Cells[2].Value.ToString();
            lblposicionactual.Visible = true;
            btneliminar.Enabled = true;

            btnnuevoresultado.Enabled = false;
            btnguardarcambios.Enabled = true;
            btncancelar.Visible = true;
            lblnuevoparticipante.Location = new Point(219, 90);
            lblmodificarparticipantes.Location = new Point(34, 90);
            lblnuevoparticipante.Visible = false;
            lblmodificarparticipantes.Visible = true;
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            this.guardarCambiosResultado();
            this.cancelar();
            this.listarResultados();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.eliminarResultado();
            this.cancelar();
            this.listarResultados();
        }
    }
}
