using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador.posiciones;

namespace Olimpiadas_Vista_.posiciones
{
    public partial class PosicionesPrincipal : Form
    {
        PosicionesDTO posicionesDTO = null;
        PosicionesDAO posicionesDAO = null;
        DataTable dataTable = null;

        public PosicionesPrincipal()
        {
            InitializeComponent();
            listarPosiciones();
        }

        private void listarPosiciones()
        {
            posicionesDTO = new PosicionesDTO();
            posicionesDAO = new PosicionesDAO(posicionesDTO);

            dataTable = new DataTable();
            dataTable = posicionesDAO.ListarPosiciones();

            if (dataTable.Rows.Count > 0)
            {
                dtposiciones.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No hay posiciones para mostrar");
            }
        }

        private void guardarNuevoPosicion()
        {
            posicionesDTO = new PosicionesDTO();
            posicionesDTO.setNombreposicion(txtnombreposicion.Text);
            posicionesDAO = new PosicionesDAO(posicionesDTO);

            posicionesDAO.guardarNuevoPosicion();

            MessageBox.Show("Registro Exitoso");
        }

        private void cancelar()
        {
            txtcodigo.Visible = false;
            lblnuevaposicion.Location = new Point(29, 92);
            lblmodificarposicion.Location = new Point(154, 92);
            lblnuevaposicion.Visible = true;
            lblmodificarposicion.Visible = false;
            btnnuevaposicion.Enabled = true;
            btnguardarcambios.Enabled = false;
            btncancelar.Visible = false;
            txtnombreposicion.Text = String.Empty;
            txtnombreposicion.Focus();
        }

        private void btnnuevaposicion_Click(object sender, EventArgs e)
        {
            this.guardarNuevoPosicion();
            this.listarPosiciones();
            this.cancelar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }

        private void guardarCambiosPosicion()
        {
            posicionesDTO = new PosicionesDTO();
            posicionesDTO.setIdposicion(Byte.Parse(txtcodigo.Text));
            posicionesDTO.setNombreposicion(txtnombreposicion.Text);
            posicionesDAO = new PosicionesDAO(posicionesDTO);

            posicionesDAO.guardarCambiosposicion();

            MessageBox.Show("Modificación Exitosa");
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            this.guardarCambiosPosicion();
            this.listarPosiciones();
            this.cancelar();
        }

        private void dtposiciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtposiciones.Rows[dtposiciones.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombreposicion.Text = dtposiciones.Rows[dtposiciones.CurrentRow.Index].Cells[1].Value.ToString();

            txtcodigo.Visible = true;
            lblnuevaposicion.Location = new Point(154, 92);
            lblmodificarposicion.Location = new Point(29, 92);
            lblnuevaposicion.Visible = false;
            lblmodificarposicion.Visible = true;
            txtcodigo.Visible = true;
            txtcodigo.Enabled = false;
            btnnuevaposicion.Enabled = false;
            btnguardarcambios.Enabled = true;
            btncancelar.Visible = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }
    }
}
