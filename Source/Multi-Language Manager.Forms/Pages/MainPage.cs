﻿namespace Nulo.Pages {

    public partial class MainPage : Form {

        public MainPage() {
            InitializeComponent();
            Program.MultiLanguageManager.SwitchLanguage += MultiLanguageManager_SwitchLanguage;
            Program.MultiLanguageManager.Update();
        }

        private void MainPage_Load(object sender, EventArgs e) {
            LanguaageComboBox.Items.AddRange(Program.MultiLanguageManager.GetLanguages());
            LanguaageComboBox.SelectedItem = Program.MultiLanguageManager.GetCurrentLanguage();
        }

        private void MultiLanguageManager_SwitchLanguage() {
            MessageLabel.Text = Program.MultiLanguageManager.GetText("Message");
        }

        private void LanguaageComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Program.MultiLanguageManager.SetLanguageByIndex(LanguaageComboBox.SelectedIndex);
        }
    }
}