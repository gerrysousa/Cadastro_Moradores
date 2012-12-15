using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cadastro_Moradores_Condominio.Formulários;

namespace Cadastro_Moradores_Condominio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLista_Dependentes());
            Application.Run(new frmPagina_Inicial());
        }
    }
}
