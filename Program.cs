using RacingFinal;
using System;
using System.Windows.Forms;

namespace ImageRace
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Application configuration for .NET 6/7/8.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
