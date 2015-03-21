//===== GameFuN, 2011-2015 =====\\ 

using System;
using System.Windows.Forms;

namespace minecraftlauncher
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
            Application.Run(new General());
        }
    }
}
