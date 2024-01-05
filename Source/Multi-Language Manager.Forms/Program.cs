using Nulo.Modules.MultiLanguageManager;
using Nulo.Pages;

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