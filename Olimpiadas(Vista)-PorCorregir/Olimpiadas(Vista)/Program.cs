using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Olimpiadas_Vista_.participantes;
using Olimpiadas_Vista_.paises;
using Olimpiadas_Vista_.posiciones;
using Olimpiadas_Vista_.resultados;


namespace Olimpiadas_Vista_
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
