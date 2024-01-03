using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace Nulo.Modules.MultiLanguageManager {

    public class MultiLanguageManager<LanguageData> where LanguageData : ILanguageData {
        private CultureInfo culture;
        private readonly ResourceManager resource;
        private readonly ILanguageData languageData;

        public event SwitchLanguageHandler SwitchLanguage;

        public MultiLanguageManager(string baseName) {
            //Instanciando um objeto para manipular os dados de configuração do idioma;
            languageData = Activator.CreateInstance<LanguageData>();

            //Definindo o idioma padrão.
            SetLanguage(languageData.GetLanguage());

            //Obtendo os recursos de idiomas.
            resource = new ResourceManager(baseName, typeof(LanguageData).Assembly);
        }

        public void Init() => SwitchLanguage?.Invoke();

        public void SetLanguage(string language) {
            //Obtendo a cultura do idioma.
            culture = new CultureInfo(language);

            //Salvando nas configurações.
            languageData.SaveLanguage(language);

            //Informa que houve uma mudança.
            SwitchLanguage?.Invoke();
        }

        public string GetLanguage() => languageData.GetLanguage();

        public List<string> GetAvailableLanguages() => languageData.GetAvailableLanguages();

        public string GetText(string key) => resource.GetString(key, culture);
    }
}