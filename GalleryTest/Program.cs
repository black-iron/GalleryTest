using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GalleryTest.Data.DataProviders;

namespace GalleryTest
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
            var t = new DataContext();
            var st = t.Media.Count();
            Application.Run(new FormTets12());
            
        }
    }
}
