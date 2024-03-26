namespace AdapterCycler
{
    partial class Window
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.adapterNameTextBox = new System.Windows.Forms.TextBox();
            this.disableButton = new System.Windows.Forms.Button();
            this.adapterName2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adapterNameTextBox
            // 
            this.adapterNameTextBox.Location = new System.Drawing.Point(25, 45);
            this.adapterNameTextBox.Name = "adapterNameTextBox";
            this.adapterNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.adapterNameTextBox.TabIndex = 0;
            // 
            // disableButton
            // 
            this.disableButton.Location = new System.Drawing.Point(111, 116);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(75, 23);
            this.disableButton.TabIndex = 1;
            this.disableButton.Text = "Cycle";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // adapterName2TextBox
            // 
            this.adapterName2TextBox.Location = new System.Drawing.Point(182, 45);
            this.adapterName2TextBox.Name = "adapterName2TextBox";
            this.adapterName2TextBox.Size = new System.Drawing.Size(100, 20);
            this.adapterName2TextBox.TabIndex = 2;
            // 
            // Window
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(304, 239);
            this.Controls.Add(this.adapterName2TextBox);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.adapterNameTextBox);
            this.Name = "Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox adapterNameTextBox;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.TextBox adapterName2TextBox;
    }
}

