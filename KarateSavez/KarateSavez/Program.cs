using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using KarateSavez.dao;
using KarateSavez.dto;

namespace KarateSavez
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

            MessageBoxManager.OK = "У реду";
            MessageBoxManager.Yes = "Да";
            MessageBoxManager.No = "Не";
            MessageBoxManager.Cancel = "Одустани";
            MessageBoxManager.Register();

            Application.Run(new pocetnaForma());

            MessageBoxManager.Unregister();
        }
    }
}
