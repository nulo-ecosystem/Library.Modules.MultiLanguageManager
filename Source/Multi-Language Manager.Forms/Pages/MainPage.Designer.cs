namespace Nulo.Pages {
    partial class MainPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            LanguaageComboBox = new System.Windows.Forms.ComboBox();
            MessageLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // LanguaageComboBox
            // 
            LanguaageComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            LanguaageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LanguaageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            LanguaageComboBox.FormattingEnabled = true;
            LanguaageComboBox.Location = new System.Drawing.Point(0, 0);
            LanguaageComboBox.Name = "LanguaageComboBox";
            LanguaageComboBox.Size = new System.Drawing.Size(800, 33);
            LanguaageComboBox.TabIndex = 0;
            LanguaageComboBox.SelectedIndexChanged += LanguaageComboBox_SelectedIndexChanged;
            // 
            // MessageLabel
            // 
            MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            MessageLabel.Location = new System.Drawing.Point(0, 33);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new System.Drawing.Size(800, 417);
            MessageLabel.TabIndex = 1;
            MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(MessageLabel);
            Controls.Add(LanguaageComboBox);
            Name = "MainPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Main Page";
            Load += MainPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox LanguaageComboBox;
        private System.Windows.Forms.Label MessageLabel;
    }
}