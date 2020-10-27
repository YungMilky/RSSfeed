using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_1
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
<<<<<<< HEAD
            Application.Run(new Form1());

            Podcast p = new Podcast();
            Console.WriteLine($"test {p.GetType().GetProperties()}"); 
=======
            Application.Run(new Podcast());
>>>>>>> 8c7df9574f7d169d4cf99bb21b87584c46522503
        }
    }
}
