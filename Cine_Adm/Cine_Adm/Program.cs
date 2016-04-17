using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Cine_Adm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static login form1;
        [STAThread]

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread thr = new Thread(ConsoleInputThreadProc);
            form1 = new login();
            thr.Start(form1);
            Application.Run( form1);
        }

        static void ConsoleInputThreadProc(object state)
        {

        }
    }
    
}

