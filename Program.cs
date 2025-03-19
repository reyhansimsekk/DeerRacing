using racingFinal;
using System;
using System.Windows.Forms;

namespace ImageRace
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // .NET 6/7/8'de uygulama yapýlandýrmasý
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
