using CDI_ControleDeProducao.Cadastros;
using Itamarati_ControleDeProducao.Cadastros;
using Itamarati_ControleDeProducao.System_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itamarati_ControleDeProducao
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
            Application.Run(new frm_TelaDeAcesso());
        }
    }
}
