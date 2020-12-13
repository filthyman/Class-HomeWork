using ClassWork_11._02._2020.Servises;
using ClassWork_11._02._2020.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork_11._02._2020
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var context = new StorageContext();
            var mainForm = new MainForm(context);

            Application.Run(mainForm);
        }
    }
}
