using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clasificare
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApplicationGui());
        }
    }
}