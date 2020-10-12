using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Olimpiadas_Vista_.paises;
using Olimpiadas_Vista_.participantes;
using Olimpiadas_Vista_.posiciones;
using Olimpiadas_Vista_.resultados;

namespace Olimpiadas_Vista_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpaises_Click(object sender, EventArgs e)
        {
            PaisesPrincipal paisesPrincipal = new PaisesPrincipal();
            paisesPrincipal.Show();
            this.Hide();
        }

        private void btnparticipantes_Click(object sender, EventArgs e)
        {
            ParticipantesPrincipal participantesPrincipal = new ParticipantesPrincipal();
            participantesPrincipal.Show();
            this.Hide();
        }

        private void btnposiciones_Click(object sender, EventArgs e)
        {
            PosicionesPrincipal posicionesPrincipal = new PosicionesPrincipal();
            posicionesPrincipal.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();         
        }

        private void btnresultados_Click(object sender, EventArgs e)
        {
            ResultadosPrincipal resultadosPrincipal = new ResultadosPrincipal();
            resultadosPrincipal.Show();
            this.Hide();
        }
    }
}
