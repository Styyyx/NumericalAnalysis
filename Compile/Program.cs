using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static public FormMain formMain;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            Application.Run(formMain);
        }
    }
}
