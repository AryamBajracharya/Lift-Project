using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift_Project
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            //initializing it with the state set to ture or isOpening

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(true));
        }
    }
}
