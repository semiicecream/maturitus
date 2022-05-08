namespace _1.Generator_nahodnych_cisel
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxPocet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVystup = new System.Windows.Forms.TextBox();
            this.buttonGeneruj = new System.Windows.Forms.Button();
            this.buttonSeradit = new System.Windows.Forms.Button();
            this.labelVystup = new System.Windows.Forms.Label();
            this.buttonPrumer = new System.Windows.Forms.Button();
            this.buttonNejmensi = new System.Windows.Forms.Button();
            this.buttonNejvetsi = new System.Windows.Forms.Button();
            this.buttonMedian = new System.Windows.Forms.Button();
            this.buttonVariacniRozpeti = new System.Windows.Forms.Button();
            this.buttonOdchylka = new System.Windows.Forms.Button();
            this.buttonNacist = new System.Windows.Forms.Button();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.buttonModus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(42, 6);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(45, 20);
            this.textBoxOd.TabIndex = 0;
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(123, 6);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(45, 20);
            this.textBoxDo.TabIndex = 1;
            // 
            // textBoxPocet
            // 
            this.textBoxPocet.Location = new System.Drawing.Point(225, 6);
            this.textBoxPocet.Name = "textBoxPocet";
            this.textBoxPocet.Size = new System.Drawing.Size(45, 20);
            this.textBoxPocet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Počet:";
            // 
            // textBoxVystup
            // 
            this.textBoxVystup.Location = new System.Drawing.Point(15, 45);
            this.textBoxVystup.Multiline = true;
            this.textBoxVystup.Name = "textBoxVystup";
            this.textBoxVystup.ReadOnly = true;
            this.textBoxVystup.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxVystup.Size = new System.Drawing.Size(153, 248);
            this.textBoxVystup.TabIndex = 6;
            // 
            // buttonGeneruj
            // 
            this.buttonGeneruj.Location = new System.Drawing.Point(276, 4);
            this.buttonGeneruj.Name = "buttonGeneruj";
            this.buttonGeneruj.Size = new System.Drawing.Size(75, 23);
            this.buttonGeneruj.TabIndex = 7;
            this.buttonGeneruj.Text = "Generuj";
            this.buttonGeneruj.UseVisualStyleBackColor = true;
            this.buttonGeneruj.Click += new System.EventHandler(this.buttonGeneruj_Click);
            // 
            // buttonSeradit
            // 
            this.buttonSeradit.Enabled = false;
            this.buttonSeradit.Location = new System.Drawing.Point(174, 33);
            this.buttonSeradit.Name = "buttonSeradit";
            this.buttonSeradit.Size = new System.Drawing.Size(96, 23);
            this.buttonSeradit.TabIndex = 8;
            this.buttonSeradit.Text = "Seřadit";
            this.buttonSeradit.UseVisualStyleBackColor = true;
            this.buttonSeradit.Click += new System.EventHandler(this.buttonSeradit_Click);
            // 
            // labelVystup
            // 
            this.labelVystup.AutoSize = true;
            this.labelVystup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVystup.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelVystup.Location = new System.Drawing.Point(174, 133);
            this.labelVystup.Name = "labelVystup";
            this.labelVystup.Size = new System.Drawing.Size(0, 16);
            this.labelVystup.TabIndex = 9;
            // 
            // buttonPrumer
            // 
            this.buttonPrumer.Enabled = false;
            this.buttonPrumer.Location = new System.Drawing.Point(276, 33);
            this.buttonPrumer.Name = "buttonPrumer";
            this.buttonPrumer.Size = new System.Drawing.Size(131, 23);
            this.buttonPrumer.TabIndex = 10;
            this.buttonPrumer.Text = "Aritmetický průměr";
            this.buttonPrumer.UseVisualStyleBackColor = true;
            this.buttonPrumer.Click += new System.EventHandler(this.buttonPrumer_Click);
            // 
            // buttonNejmensi
            // 
            this.buttonNejmensi.Enabled = false;
            this.buttonNejmensi.Location = new System.Drawing.Point(276, 63);
            this.buttonNejmensi.Name = "buttonNejmensi";
            this.buttonNejmensi.Size = new System.Drawing.Size(131, 23);
            this.buttonNejmensi.TabIndex = 11;
            this.buttonNejmensi.Text = "Nejmenší číslo";
            this.buttonNejmensi.UseVisualStyleBackColor = true;
            this.buttonNejmensi.Click += new System.EventHandler(this.buttonNejmensi_Click);
            // 
            // buttonNejvetsi
            // 
            this.buttonNejvetsi.Enabled = false;
            this.buttonNejvetsi.Location = new System.Drawing.Point(413, 63);
            this.buttonNejvetsi.Name = "buttonNejvetsi";
            this.buttonNejvetsi.Size = new System.Drawing.Size(98, 23);
            this.buttonNejvetsi.TabIndex = 12;
            this.buttonNejvetsi.Text = "Největší číslo";
            this.buttonNejvetsi.UseVisualStyleBackColor = true;
            this.buttonNejvetsi.Click += new System.EventHandler(this.buttonNejvetsi_Click);
            // 
            // buttonMedian
            // 
            this.buttonMedian.Enabled = false;
            this.buttonMedian.Location = new System.Drawing.Point(438, 4);
            this.buttonMedian.Name = "buttonMedian";
            this.buttonMedian.Size = new System.Drawing.Size(73, 23);
            this.buttonMedian.TabIndex = 13;
            this.buttonMedian.Text = "Medián";
            this.buttonMedian.UseVisualStyleBackColor = true;
            this.buttonMedian.Click += new System.EventHandler(this.buttonMedian_Click);
            // 
            // buttonVariacniRozpeti
            // 
            this.buttonVariacniRozpeti.Enabled = false;
            this.buttonVariacniRozpeti.Location = new System.Drawing.Point(413, 33);
            this.buttonVariacniRozpeti.Name = "buttonVariacniRozpeti";
            this.buttonVariacniRozpeti.Size = new System.Drawing.Size(98, 23);
            this.buttonVariacniRozpeti.TabIndex = 14;
            this.buttonVariacniRozpeti.Text = "Variační rozpětí";
            this.buttonVariacniRozpeti.UseVisualStyleBackColor = true;
            this.buttonVariacniRozpeti.Click += new System.EventHandler(this.buttonVariacniRozpeti_Click);
            // 
            // buttonOdchylka
            // 
            this.buttonOdchylka.Enabled = false;
            this.buttonOdchylka.Location = new System.Drawing.Point(276, 92);
            this.buttonOdchylka.Name = "buttonOdchylka";
            this.buttonOdchylka.Size = new System.Drawing.Size(235, 23);
            this.buttonOdchylka.TabIndex = 15;
            this.buttonOdchylka.Text = "Průměrná absolutní odchylka";
            this.buttonOdchylka.UseVisualStyleBackColor = true;
            this.buttonOdchylka.Click += new System.EventHandler(this.buttonOdchylka_Click);
            // 
            // buttonNacist
            // 
            this.buttonNacist.Location = new System.Drawing.Point(174, 63);
            this.buttonNacist.Name = "buttonNacist";
            this.buttonNacist.Size = new System.Drawing.Size(96, 23);
            this.buttonNacist.TabIndex = 16;
            this.buttonNacist.Text = "Načíst";
            this.buttonNacist.UseVisualStyleBackColor = true;
            this.buttonNacist.Click += new System.EventHandler(this.buttonNacist_Click);
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Enabled = false;
            this.buttonUlozit.Location = new System.Drawing.Point(174, 92);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(96, 23);
            this.buttonUlozit.TabIndex = 17;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // buttonModus
            // 
            this.buttonModus.Enabled = false;
            this.buttonModus.Location = new System.Drawing.Point(357, 4);
            this.buttonModus.Name = "buttonModus";
            this.buttonModus.Size = new System.Drawing.Size(75, 23);
            this.buttonModus.TabIndex = 18;
            this.buttonModus.Text = "Modus";
            this.buttonModus.UseVisualStyleBackColor = true;
            this.buttonModus.Click += new System.EventHandler(this.buttonModus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 305);
            this.Controls.Add(this.buttonModus);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.buttonNacist);
            this.Controls.Add(this.buttonOdchylka);
            this.Controls.Add(this.buttonVariacniRozpeti);
            this.Controls.Add(this.buttonMedian);
            this.Controls.Add(this.buttonNejvetsi);
            this.Controls.Add(this.buttonNejmensi);
            this.Controls.Add(this.buttonPrumer);
            this.Controls.Add(this.labelVystup);
            this.Controls.Add(this.buttonSeradit);
            this.Controls.Add(this.buttonGeneruj);
            this.Controls.Add(this.textBoxVystup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPocet);
            this.Controls.Add(this.textBoxDo);
            this.Controls.Add(this.textBoxOd);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generátor náhodných čísel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxPocet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVystup;
        private System.Windows.Forms.Button buttonGeneruj;
        private System.Windows.Forms.Button buttonSeradit;
        private System.Windows.Forms.Label labelVystup;
        private System.Windows.Forms.Button buttonPrumer;
        private System.Windows.Forms.Button buttonNejmensi;
        private System.Windows.Forms.Button buttonNejvetsi;
        private System.Windows.Forms.Button buttonMedian;
        private System.Windows.Forms.Button buttonVariacniRozpeti;
        private System.Windows.Forms.Button buttonOdchylka;
        private System.Windows.Forms.Button buttonNacist;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Button buttonModus;
    }
}

