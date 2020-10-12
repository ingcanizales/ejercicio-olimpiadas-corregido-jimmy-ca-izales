using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador.paises;

namespace Olimpiadas_Vista_.paises
{
    public partial class PaisesPrincipal : Form
    {
        PaisesDTO paisesDTO = null;
        PaisesDAO paisesDAO = null;
        DataTable dataTable = null;

        public PaisesPrincipal()
        {
            InitializeComponent();
            listarPaises();
        }

        private void listarPaises() {
            paisesDTO = new PaisesDTO();
            paisesDAO = new PaisesDAO(paisesDTO);

            dataTable = new DataTable();
            dataTable = paisesDAO.ListarPaises();

            if(dataTable.Rows.Count > 0) {
                dtpaises.DataSource = dataTable;
            }else {
                MessageBox.Show("No hay paises para mostrar");
            }
        }

        private void guardarNuevoPais() {
            paisesDTO = new PaisesDTO();
            paisesDTO.setNombrepais(txtnombrepais.Text);
            paisesDAO = new PaisesDAO(paisesDTO);

            paisesDAO.guardarNuevoPais();

            MessageBox.Show("Registro Exitoso");
        }


        private void btnnuevopais_Click(object sender, EventArgs e)
        {
            this.guardarNuevoPais();
            this.listarPaises();
            this.limpiarCampos();
        }

        private void limpiarCampos() {
            txtnombrepais.Text = String.Empty;
            txtnombrepais.Focus();
        }

        private void dtpaises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtpaises.Rows[dtpaises.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombrepais.Text = dtpaises.Rows[dtpaises.CurrentRow.Index].Cells[1].Value.ToString();
            
            txtcodigo.Visible = true;
            lblnuevopais.Location = new Point(154, 92);
            lblmodificarpais.Location = new Point(29, 92);
            lblnuevopais.Visible = false;
            lblmodificarpais.Visible = true;
            txtcodigo.Visible = true;
            txtcodigo.Enabled = false;
            btnnuevopais.Enabled = false;
            btnguardarcambios.Enabled = true;
            btncancelar.Visible = true;
        }

        private void cancelar() {
            txtcodigo.Visible = false;
            lblnuevopais.Location = new Point(29, 92);
            lblmodificarpais.Location = new Point(154, 92); 
            lblnuevopais.Visible = true;
            lblmodificarpais.Visible = false;
            btnnuevopais.Enabled = true;
            btnguardarcambios.Enabled = false;
            btncancelar.Visible = false;
            txtnombrepais.Text = String.Empty;
            txtnombrepais.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }

        private void guardarCambiosPais()
        {
            paisesDTO = new PaisesDTO();
            paisesDTO.setIdpais(txtcodigo.Text);
            paisesDTO.setNombrepais(txtnombrepais.Text);
            paisesDAO = new PaisesDAO(paisesDTO);

            paisesDAO.guardarCambiospais();

            MessageBox.Show("Modificación Exitosa");
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            this.guardarCambiosPais();
            this.listarPaises();
            this.cancelar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void dtpaises_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
