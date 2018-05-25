namespace Buchführung
{
    partial class Ausgabe
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelSummeAus = new System.Windows.Forms.Label();
            this.labelSummeEin = new System.Windows.Forms.Label();
            this.richTextAusgabe = new System.Windows.Forms.RichTextBox();
            this.richTextEinnahme = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.richTextSalden = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.labelSaldoVergleich = new System.Windows.Forms.Label();
            this.labelSaldoJahr = new System.Windows.Forms.Label();
            this.richTextVergleich = new System.Windows.Forms.RichTextBox();
            this.richTextJahr = new System.Windows.Forms.RichTextBox();
            this.labelJahr2 = new System.Windows.Forms.Label();
            this.labelJahr1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelJahr = new System.Windows.Forms.Label();
            this.labelVergleich = new System.Windows.Forms.Label();
            this.labelMonat = new System.Windows.Forms.Label();
            this.comboBoxJahr = new System.Windows.Forms.ComboBox();
            this.comboBoxVergleich = new System.Windows.Forms.ComboBox();
            this.comboBoxMonat = new System.Windows.Forms.ComboBox();
            this.buttonZurueck = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Controls.Add(this.tab3);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(673, 325);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.labelSaldo);
            this.tab1.Controls.Add(this.labelSummeAus);
            this.tab1.Controls.Add(this.labelSummeEin);
            this.tab1.Controls.Add(this.richTextAusgabe);
            this.tab1.Controls.Add(this.richTextEinnahme);
            this.tab1.Controls.Add(this.label6);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Location = new System.Drawing.Point(4, 34);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(665, 287);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Monatsausgabe";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(11, 239);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(85, 25);
            this.labelSaldo.TabIndex = 17;
            this.labelSaldo.Text = "Saldo = ";
            // 
            // labelSummeAus
            // 
            this.labelSummeAus.AutoSize = true;
            this.labelSummeAus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummeAus.Location = new System.Drawing.Point(326, 189);
            this.labelSummeAus.Name = "labelSummeAus";
            this.labelSummeAus.Size = new System.Drawing.Size(102, 25);
            this.labelSummeAus.TabIndex = 16;
            this.labelSummeAus.Text = "Summe = ";
            // 
            // labelSummeEin
            // 
            this.labelSummeEin.AutoSize = true;
            this.labelSummeEin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummeEin.Location = new System.Drawing.Point(11, 189);
            this.labelSummeEin.Name = "labelSummeEin";
            this.labelSummeEin.Size = new System.Drawing.Size(102, 25);
            this.labelSummeEin.TabIndex = 15;
            this.labelSummeEin.Text = "Summe = ";
            // 
            // richTextAusgabe
            // 
            this.richTextAusgabe.Location = new System.Drawing.Point(331, 31);
            this.richTextAusgabe.Name = "richTextAusgabe";
            this.richTextAusgabe.ReadOnly = true;
            this.richTextAusgabe.Size = new System.Drawing.Size(315, 155);
            this.richTextAusgabe.TabIndex = 14;
            this.richTextAusgabe.Text = "";
            // 
            // richTextEinnahme
            // 
            this.richTextEinnahme.Location = new System.Drawing.Point(11, 31);
            this.richTextEinnahme.Name = "richTextEinnahme";
            this.richTextEinnahme.ReadOnly = true;
            this.richTextEinnahme.Size = new System.Drawing.Size(315, 155);
            this.richTextEinnahme.TabIndex = 13;
            this.richTextEinnahme.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(326, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ausgaben";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Einnahmen";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.richTextSalden);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Location = new System.Drawing.Point(4, 34);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(665, 287);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Jahressalden";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // richTextSalden
            // 
            this.richTextSalden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.richTextSalden.Location = new System.Drawing.Point(11, 31);
            this.richTextSalden.Name = "richTextSalden";
            this.richTextSalden.ReadOnly = true;
            this.richTextSalden.Size = new System.Drawing.Size(637, 253);
            this.richTextSalden.TabIndex = 16;
            this.richTextSalden.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salden";
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.labelSaldoVergleich);
            this.tab3.Controls.Add(this.labelSaldoJahr);
            this.tab3.Controls.Add(this.richTextVergleich);
            this.tab3.Controls.Add(this.richTextJahr);
            this.tab3.Controls.Add(this.labelJahr2);
            this.tab3.Controls.Add(this.labelJahr1);
            this.tab3.Location = new System.Drawing.Point(4, 34);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(665, 287);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Vergleich";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // labelSaldoVergleich
            // 
            this.labelSaldoVergleich.AutoSize = true;
            this.labelSaldoVergleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoVergleich.Location = new System.Drawing.Point(327, 245);
            this.labelSaldoVergleich.Name = "labelSaldoVergleich";
            this.labelSaldoVergleich.Size = new System.Drawing.Size(102, 25);
            this.labelSaldoVergleich.TabIndex = 23;
            this.labelSaldoVergleich.Text = "Summe = ";
            // 
            // labelSaldoJahr
            // 
            this.labelSaldoJahr.AutoSize = true;
            this.labelSaldoJahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoJahr.Location = new System.Drawing.Point(6, 245);
            this.labelSaldoJahr.Name = "labelSaldoJahr";
            this.labelSaldoJahr.Size = new System.Drawing.Size(102, 25);
            this.labelSaldoJahr.TabIndex = 22;
            this.labelSaldoJahr.Text = "Summe = ";
            // 
            // richTextVergleich
            // 
            this.richTextVergleich.Location = new System.Drawing.Point(332, 31);
            this.richTextVergleich.Name = "richTextVergleich";
            this.richTextVergleich.ReadOnly = true;
            this.richTextVergleich.Size = new System.Drawing.Size(315, 211);
            this.richTextVergleich.TabIndex = 21;
            this.richTextVergleich.Text = "";
            // 
            // richTextJahr
            // 
            this.richTextJahr.Location = new System.Drawing.Point(11, 31);
            this.richTextJahr.Name = "richTextJahr";
            this.richTextJahr.ReadOnly = true;
            this.richTextJahr.Size = new System.Drawing.Size(315, 211);
            this.richTextJahr.TabIndex = 20;
            this.richTextJahr.Text = "";
            // 
            // labelJahr2
            // 
            this.labelJahr2.AutoSize = true;
            this.labelJahr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.labelJahr2.Location = new System.Drawing.Point(327, 3);
            this.labelJahr2.Name = "labelJahr2";
            this.labelJahr2.Size = new System.Drawing.Size(102, 25);
            this.labelJahr2.TabIndex = 19;
            this.labelJahr2.Text = "Ausgaben";
            // 
            // labelJahr1
            // 
            this.labelJahr1.AutoSize = true;
            this.labelJahr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.labelJahr1.Location = new System.Drawing.Point(6, 3);
            this.labelJahr1.Name = "labelJahr1";
            this.labelJahr1.Size = new System.Drawing.Size(111, 25);
            this.labelJahr1.TabIndex = 18;
            this.labelJahr1.Text = "Einnahmen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Datum";
            // 
            // labelJahr
            // 
            this.labelJahr.AutoSize = true;
            this.labelJahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelJahr.Location = new System.Drawing.Point(7, 378);
            this.labelJahr.Name = "labelJahr";
            this.labelJahr.Size = new System.Drawing.Size(51, 25);
            this.labelJahr.TabIndex = 11;
            this.labelJahr.Text = "Jahr";
            // 
            // labelVergleich
            // 
            this.labelVergleich.AutoSize = true;
            this.labelVergleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelVergleich.Location = new System.Drawing.Point(7, 417);
            this.labelVergleich.Name = "labelVergleich";
            this.labelVergleich.Size = new System.Drawing.Size(136, 25);
            this.labelVergleich.TabIndex = 12;
            this.labelVergleich.Text = "Vergleichsjahr";
            // 
            // labelMonat
            // 
            this.labelMonat.AutoSize = true;
            this.labelMonat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelMonat.Location = new System.Drawing.Point(7, 456);
            this.labelMonat.Name = "labelMonat";
            this.labelMonat.Size = new System.Drawing.Size(67, 25);
            this.labelMonat.TabIndex = 13;
            this.labelMonat.Text = "Monat";
            // 
            // comboBoxJahr
            // 
            this.comboBoxJahr.DropDownHeight = 150;
            this.comboBoxJahr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBoxJahr.FormattingEnabled = true;
            this.comboBoxJahr.IntegralHeight = false;
            this.comboBoxJahr.Location = new System.Drawing.Point(154, 375);
            this.comboBoxJahr.Name = "comboBoxJahr";
            this.comboBoxJahr.Size = new System.Drawing.Size(151, 33);
            this.comboBoxJahr.TabIndex = 14;
            this.comboBoxJahr.SelectedIndexChanged += new System.EventHandler(this.comboBoxJahr_SelectedIndexChanged);
            // 
            // comboBoxVergleich
            // 
            this.comboBoxVergleich.DropDownHeight = 100;
            this.comboBoxVergleich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVergleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBoxVergleich.FormattingEnabled = true;
            this.comboBoxVergleich.IntegralHeight = false;
            this.comboBoxVergleich.Location = new System.Drawing.Point(154, 414);
            this.comboBoxVergleich.Name = "comboBoxVergleich";
            this.comboBoxVergleich.Size = new System.Drawing.Size(151, 33);
            this.comboBoxVergleich.TabIndex = 15;
            this.comboBoxVergleich.SelectedIndexChanged += new System.EventHandler(this.comboBoxVergleich_SelectedIndexChanged);
            // 
            // comboBoxMonat
            // 
            this.comboBoxMonat.DropDownHeight = 100;
            this.comboBoxMonat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBoxMonat.FormattingEnabled = true;
            this.comboBoxMonat.IntegralHeight = false;
            this.comboBoxMonat.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "März",
            "April",
            "Mai",
            "Juni",
            "Juli",
            "August",
            "September",
            "Oktober",
            "November",
            "Dezember"});
            this.comboBoxMonat.Location = new System.Drawing.Point(154, 453);
            this.comboBoxMonat.Name = "comboBoxMonat";
            this.comboBoxMonat.Size = new System.Drawing.Size(151, 33);
            this.comboBoxMonat.TabIndex = 16;
            this.comboBoxMonat.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonat_SelectedIndexChanged);
            // 
            // buttonZurueck
            // 
            this.buttonZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonZurueck.Location = new System.Drawing.Point(519, 435);
            this.buttonZurueck.Name = "buttonZurueck";
            this.buttonZurueck.Size = new System.Drawing.Size(166, 51);
            this.buttonZurueck.TabIndex = 5;
            this.buttonZurueck.Text = "Zurück";
            this.buttonZurueck.UseVisualStyleBackColor = true;
            this.buttonZurueck.Click += new System.EventHandler(this.buttonZurueck_Click);
            // 
            // Ausgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 498);
            this.Controls.Add(this.comboBoxJahr);
            this.Controls.Add(this.comboBoxVergleich);
            this.Controls.Add(this.labelJahr);
            this.Controls.Add(this.comboBoxMonat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZurueck);
            this.Controls.Add(this.labelVergleich);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelMonat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ausgabe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ausgabe";
            this.Load += new System.EventHandler(this.Ausgabe_Load);
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.ComboBox comboBoxMonat;
        private System.Windows.Forms.ComboBox comboBoxVergleich;
        private System.Windows.Forms.ComboBox comboBoxJahr;
        private System.Windows.Forms.Label labelMonat;
        private System.Windows.Forms.Label labelVergleich;
        private System.Windows.Forms.Label labelJahr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonZurueck;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelSummeAus;
        private System.Windows.Forms.Label labelSummeEin;
        private System.Windows.Forms.RichTextBox richTextAusgabe;
        private System.Windows.Forms.RichTextBox richTextEinnahme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextSalden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSaldoVergleich;
        private System.Windows.Forms.Label labelSaldoJahr;
        private System.Windows.Forms.RichTextBox richTextVergleich;
        private System.Windows.Forms.RichTextBox richTextJahr;
        private System.Windows.Forms.Label labelJahr2;
        private System.Windows.Forms.Label labelJahr1;
    }
}