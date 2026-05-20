using System;
using System.Windows.Forms;
using ProjetoDA.Views; // Esta é a linha que falta para resolver o erro!

namespace ProjetoDA
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Agora o Visual Studio já deve reconhecer o FormLogin sem o erro vermelho
            Application.Run(new FormLogin());
        }
    }
}