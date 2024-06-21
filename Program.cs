using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EnvoiCommandeCRM
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Commun.Commun.ExistProcessusIdentique())
            {
                MessageBox.Show("Le programme ne peut pas être lancé 2 fois !");
                Application.Exit();
            }
            else
                Application.Run(new UFSaisie());
        }
    }
}
