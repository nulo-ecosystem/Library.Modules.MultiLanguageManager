using Nulo.Modules.MultiLanguageManager;
using Nulo.Pages;
using System;
using System.Windows.Forms;

namespace Nulo {

    internal static class Program {
        public static MultiLanguageManager<LanguageData> MultiLanguageManager;

        [STAThread]
        private static void Main() {
            ApplicationConfiguration.Initialize();

            MultiLanguageManager = new MultiLanguageManager<LanguageData>("Nulo.Modules.MultiLanguageManager.Language");

            Application.Run(new MainPage());
        }
    }
}