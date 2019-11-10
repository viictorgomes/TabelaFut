using System;
using System.Windows.Forms;

namespace TabelaFut
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Manager.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }


    }
}