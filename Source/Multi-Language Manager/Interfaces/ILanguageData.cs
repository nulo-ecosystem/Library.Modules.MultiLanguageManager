using System.Collections.Generic;

namespace Nulo.Modules.MultiLanguageManager {

    public interface ILanguageData {

        void SaveLanguage(string language);
        string GetLanguage();
        List<string> GetAvailableLanguages();
    }
}