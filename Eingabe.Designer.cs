namespace Buchführung
{
    partial class Eingabe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioEinnahme = new System.Windows.Forms.RadioButton();
            this.radioAusgabe = new System.Windows.Forms.RadioButton();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonZurueck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxGrund = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericBetrag = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetrag)).BeginInit();
            this.SuspendLayout();
            // 
            // radioEinnahme
            // 
            this.radioEinnahme.AutoSize = true;
            this.radioEinnahme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioEinnahme.Location = new System.Drawing.Point(12, 204);
            this.radioEinnahme.Name = "radioEinnahme";
            this.radioEinnahme.Size = new System.Drawing.Size(129, 29);
            this.radioEinnahme.TabIndex = 1;
            this.radioEinnahme.TabStop = true;
            this.radioEinnahme.Text = "Einnahmen";
            this.radioEinnahme.UseVisualStyleBackColor = true;
            // 
            // radioAusgabe
            // 
            this.radioAusgabe.AutoSize = true;
            this.radioAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioAusgabe.Location = new System.Drawing.Point(12, 239);
            this.radioAusgabe.Name = "radioAusgabe";
            this.radioAusgabe.Size = new System.Drawing.Size(120, 29);
            this.radioAusgabe.TabIndex = 2;
            this.radioAusgabe.TabStop = true;
            this.radioAusgabe.Text = "Ausgaben";
            this.radioAusgabe.UseVisualStyleBackColor = true;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSpeichern.Location = new System.Drawing.Point(12, 279);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(180, 51);
            this.buttonSpeichern.TabIndex = 3;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // buttonZurueck
            // 
            this.buttonZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonZurueck.Location = new System.Drawing.Point(198, 279);
            this.buttonZurueck.Name = "buttonZurueck";
            this.buttonZurueck.Size = new System.Drawing.Size(166, 51);
            this.buttonZurueck.TabIndex = 4;
            this.buttonZurueck.Text = "Zurück";
            this.buttonZurueck.UseVisualStyleBackColor = true;
            this.buttonZurueck.Click += new System.EventHandler(this.buttonZurueck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grund";
            // 
            // dateDatum
            // 
            this.dateDatum.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDatum.Location = new System.Drawing.Point(17, 98);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(347, 30);
            this.dateDatum.TabIndex = 7;
            // 
            // textBoxGrund
            // 
            this.textBoxGrund.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxGrund.Location = new System.Drawing.Point(17, 37);
            this.textBoxGrund.Name = "textBoxGrund";
            this.textBoxGrund.Size = new System.Drawing.Size(347, 30);
            this.textBoxGrund.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Betrag";
            // 
            // numericBetrag
            // 
            this.numericBetrag.DecimalPlaces = 2;
            this.numericBetrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericBetrag.Location = new System.Drawing.Point(17, 159);
            this.numericBetrag.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericBetrag.Name = "numericBetrag";
            this.numericBetrag.Size = new System.Drawing.Size(200, 30);
            this.numericBetrag.TabIndex = 5;
            // 
            // Eingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGrund);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericBetrag);
            this.Controls.Add(this.buttonZurueck);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.radioAusgabe);
            this.Controls.Add(this.radioEinnahme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Eingabe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eingabe";
            ((System.ComponentModel.ISupportInitialize)(this.numericBetrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioEinnahme;
        private System.Windows.Forms.RadioButton radioAusgabe;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonZurueck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDatum;
        private System.Windows.Forms.TextBox textBoxGrund;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericBetrag;
    }
}