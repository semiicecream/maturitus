namespace _2.Grafický_editor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTvar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPlocha = new System.Windows.Forms.RadioButton();
            this.radioButtonObrys = new System.Windows.Forms.RadioButton();
            this.buttonBarvaVyber = new System.Windows.Forms.Button();
            this.buttonNacist = new System.Windows.Forms.Button();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.buttonSmazat = new System.Windows.Forms.Button();
            this.buttonVykreslit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSirka = new System.Windows.Forms.TextBox();
            this.labelSirka = new System.Windows.Forms.Label();
            this.labelVyska = new System.Windows.Forms.Label();
            this.textBoxVyska = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSouradniceY = new System.Windows.Forms.TextBox();
            this.textBoxSouradniceX = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tvar:";
            // 
            // comboBoxTvar
            // 
            this.comboBoxTvar.FormattingEnabled = true;
            this.comboBoxTvar.Items.AddRange(new object[] {
            "Elipsa",
            "Obdélník",
            "Přímka"});
            this.comboBoxTvar.Location = new System.Drawing.Point(50, 21);
            this.comboBoxTvar.Name = "comboBoxTvar";
            this.comboBoxTvar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTvar.TabIndex = 1;
            this.comboBoxTvar.Text = "Elipsa";
            this.comboBoxTvar.SelectedIndexChanged += new System.EventHandler(this.comboBoxTvar_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPlocha);
            this.groupBox1.Controls.Add(this.radioButtonObrys);
            this.groupBox1.Location = new System.Drawing.Point(183, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(83, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vykreslit";
            // 
            // radioButtonPlocha
            // 
            this.radioButtonPlocha.AutoSize = true;
            this.radioButtonPlocha.Location = new System.Drawing.Point(6, 42);
            this.radioButtonPlocha.Name = "radioButtonPlocha";
            this.radioButtonPlocha.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPlocha.TabIndex = 1;
            this.radioButtonPlocha.Text = "Plochu";
            this.radioButtonPlocha.UseVisualStyleBackColor = true;
            // 
            // radioButtonObrys
            // 
            this.radioButtonObrys.AutoSize = true;
            this.radioButtonObrys.Checked = true;
            this.radioButtonObrys.Location = new System.Drawing.Point(6, 19);
            this.radioButtonObrys.Name = "radioButtonObrys";
            this.radioButtonObrys.Size = new System.Drawing.Size(52, 17);
            this.radioButtonObrys.TabIndex = 0;
            this.radioButtonObrys.TabStop = true;
            this.radioButtonObrys.Text = "Obrys";
            this.radioButtonObrys.UseVisualStyleBackColor = true;
            // 
            // buttonBarvaVyber
            // 
            this.buttonBarvaVyber.Location = new System.Drawing.Point(15, 52);
            this.buttonBarvaVyber.Name = "buttonBarvaVyber";
            this.buttonBarvaVyber.Size = new System.Drawing.Size(156, 23);
            this.buttonBarvaVyber.TabIndex = 3;
            this.buttonBarvaVyber.Text = "Výběr barvy";
            this.buttonBarvaVyber.UseVisualStyleBackColor = true;
            this.buttonBarvaVyber.Click += new System.EventHandler(this.buttonBarvaVyber_Click);
            // 
            // buttonNacist
            // 
            this.buttonNacist.Location = new System.Drawing.Point(651, 19);
            this.buttonNacist.Name = "buttonNacist";
            this.buttonNacist.Size = new System.Drawing.Size(75, 23);
            this.buttonNacist.TabIndex = 4;
            this.buttonNacist.Text = "Načíst";
            this.buttonNacist.UseVisualStyleBackColor = true;
            this.buttonNacist.Click += new System.EventHandler(this.buttonNacist_Click);
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(651, 45);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(75, 23);
            this.buttonUlozit.TabIndex = 5;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // buttonSmazat
            // 
            this.buttonSmazat.Location = new System.Drawing.Point(570, 19);
            this.buttonSmazat.Name = "buttonSmazat";
            this.buttonSmazat.Size = new System.Drawing.Size(75, 23);
            this.buttonSmazat.TabIndex = 6;
            this.buttonSmazat.Text = "Smazat";
            this.buttonSmazat.UseVisualStyleBackColor = true;
            this.buttonSmazat.Click += new System.EventHandler(this.buttonSmazat_Click);
            // 
            // buttonVykreslit
            // 
            this.buttonVykreslit.Location = new System.Drawing.Point(570, 45);
            this.buttonVykreslit.Name = "buttonVykreslit";
            this.buttonVykreslit.Size = new System.Drawing.Size(75, 23);
            this.buttonVykreslit.TabIndex = 7;
            this.buttonVykreslit.Text = "Vykreslit";
            this.buttonVykreslit.UseVisualStyleBackColor = true;
            this.buttonVykreslit.Click += new System.EventHandler(this.buttonVykreslit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 364);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSirka
            // 
            this.textBoxSirka.Location = new System.Drawing.Point(368, 21);
            this.textBoxSirka.Name = "textBoxSirka";
            this.textBoxSirka.Size = new System.Drawing.Size(54, 20);
            this.textBoxSirka.TabIndex = 9;
            // 
            // labelSirka
            // 
            this.labelSirka.AutoSize = true;
            this.labelSirka.Location = new System.Drawing.Point(272, 24);
            this.labelSirka.Name = "labelSirka";
            this.labelSirka.Size = new System.Drawing.Size(37, 13);
            this.labelSirka.TabIndex = 10;
            this.labelSirka.Text = "Šířka:";
            // 
            // labelVyska
            // 
            this.labelVyska.AutoSize = true;
            this.labelVyska.Location = new System.Drawing.Point(272, 50);
            this.labelVyska.Name = "labelVyska";
            this.labelVyska.Size = new System.Drawing.Size(39, 13);
            this.labelVyska.TabIndex = 11;
            this.labelVyska.Text = "Výška:";
            // 
            // textBoxVyska
            // 
            this.textBoxVyska.Location = new System.Drawing.Point(368, 47);
            this.textBoxVyska.Name = "textBoxVyska";
            this.textBoxVyska.Size = new System.Drawing.Size(54, 20);
            this.textBoxVyska.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Souřadnice X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Souřadnice Y:";
            // 
            // textBoxSouradniceY
            // 
            this.textBoxSouradniceY.Location = new System.Drawing.Point(509, 47);
            this.textBoxSouradniceY.Name = "textBoxSouradniceY";
            this.textBoxSouradniceY.Size = new System.Drawing.Size(54, 20);
            this.textBoxSouradniceY.TabIndex = 16;
            // 
            // textBoxSouradniceX
            // 
            this.textBoxSouradniceX.Location = new System.Drawing.Point(509, 21);
            this.textBoxSouradniceX.Name = "textBoxSouradniceX";
            this.textBoxSouradniceX.Size = new System.Drawing.Size(54, 20);
            this.textBoxSouradniceX.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.textBoxSouradniceY);
            this.Controls.Add(this.textBoxSouradniceX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVyska);
            this.Controls.Add(this.labelVyska);
            this.Controls.Add(this.labelSirka);
            this.Controls.Add(this.textBoxSirka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVykreslit);
            this.Controls.Add(this.buttonSmazat);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.buttonNacist);
            this.Controls.Add(this.buttonBarvaVyber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxTvar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "2. Grafický editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPlocha;
        private System.Windows.Forms.RadioButton radioButtonObrys;
        private System.Windows.Forms.Button buttonBarvaVyber;
        private System.Windows.Forms.Button buttonNacist;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Button buttonSmazat;
        private System.Windows.Forms.Button buttonVykreslit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSirka;
        private System.Windows.Forms.Label labelSirka;
        private System.Windows.Forms.Label labelVyska;
        private System.Windows.Forms.TextBox textBoxVyska;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSouradniceY;
        private System.Windows.Forms.TextBox textBoxSouradniceX;
    }
}

