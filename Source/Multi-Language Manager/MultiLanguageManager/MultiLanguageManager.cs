using System;
using System.Globalization;
using System.Resources;

namespace Nulo.Modules.MultiLanguageManager {

    public class MultiLanguageManager<LanguageData> where LanguageData : ILanguageData {
        private CultureInfo culture;
        private readonly ResourceManager resource;
        private readonly ILanguageData languageData;

        public event SwitchLanguageHandler SwitchLanguage;

        public MultiLanguageManager(string baseName) {
            languageData = Activator.CreateInstance<LanguageData>();
            SetLanguage(languageData.GetLanguage());
            resource = new ResourceManager(baseName, typeof(LanguageData).Assembly);
        }

        #region Public Methods

        public string GetText(string key) {
            return resource.GetString(key, culture);
        }

        public void Update() {
            SwitchLanguage?.Invoke();
        }

        public void SetLanguage(int index) {
            var languages = languageData.GetAvailableLanguages();
            if(index > languages.Count) { return; }
            SetLanguage(languages[index]);
        }

        public string GetCurrentLanguage() {
            return Convert(languageData.GetLanguage());
        }

        public object[] GetLanguages() {
            var languages = new object[languageData.GetAvailableLanguages().Count];
            for(int i = 0; i < languageData.GetAvailableLanguages().Count; i++) {
                languages[i] = Convert(languageData.GetAvailableLanguages()[i]);
            }
            return languages;
        }

        #endregion Public Methods

        #region Private Methods

        private void SetLanguage(string language) {
            culture = new CultureInfo(language);
            languageData.SaveLanguage(language);
            SwitchLanguage?.Invoke();
        }

        private static string Convert(string language) {
            var nativeName = new CultureInfo(language).NativeName;
            return char.ToUpper(nativeName[0]) + nativeName[1..];
        }

        #endregion Private Methods
    }
}