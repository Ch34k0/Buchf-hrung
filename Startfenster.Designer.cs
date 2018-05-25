namespace Buchführung
{
    partial class Startfenster
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
            this.buttonEingabe = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAusgabe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEingabe
            // 
            this.buttonEingabe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonEingabe.Location = new System.Drawing.Point(12, 12);
            this.buttonEingabe.Name = "buttonEingabe";
            this.buttonEingabe.Size = new System.Drawing.Size(260, 70);
            this.buttonEingabe.TabIndex = 0;
            this.buttonEingabe.Text = "Eingabe";
            this.buttonEingabe.UseVisualStyleBackColor = true;
            this.buttonEingabe.Click += new System.EventHandler(this.buttonEingabe_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonClose.Location = new System.Drawing.Point(12, 179);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(260, 70);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Beenden";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAusgabe
            // 
            this.buttonAusgabe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonAusgabe.Location = new System.Drawing.Point(12, 88);
            this.buttonAusgabe.Name = "buttonAusgabe";
            this.buttonAusgabe.Size = new System.Drawing.Size(260, 70);
            this.buttonAusgabe.TabIndex = 2;
            this.buttonAusgabe.Text = "Ausgabe";
            this.buttonAusgabe.UseVisualStyleBackColor = true;
            this.buttonAusgabe.Click += new System.EventHandler(this.buttonAusgabe_Click);
            // 
            // Startfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonAusgabe);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonEingabe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Startfenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buchführung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEingabe;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAusgabe;
    }
}

