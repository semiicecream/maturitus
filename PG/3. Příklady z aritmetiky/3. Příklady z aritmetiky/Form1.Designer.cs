namespace _3.Příklady_z_aritmetiky
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
            this.numericUpDownMinimum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaximum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.labelExercise = new System.Windows.Forms.Label();
            this.numericUpDownResult = new System.Windows.Forms.NumericUpDown();
            this.buttonExercise = new System.Windows.Forms.Button();
            this.textBoxFailedExercises = new System.Windows.Forms.TextBox();
            this.buttonClearFailedExercises = new System.Windows.Forms.Button();
            this.buttonLoadFailedExercises = new System.Windows.Forms.Button();
            this.buttonSaveFailedExercises = new System.Windows.Forms.Button();
            this.labelNumberOfExercises = new System.Windows.Forms.Label();
            this.labelSuccessfulExercises = new System.Windows.Forms.Label();
            this.labelFailedExercises = new System.Windows.Forms.Label();
            this.labelPercentageExercises = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Čísla od: ";
            // 
            // numericUpDownMinimum
            // 
            this.numericUpDownMinimum.Location = new System.Drawing.Point(70, 7);
            this.numericUpDownMinimum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMinimum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownMinimum.Name = "numericUpDownMinimum";
            this.numericUpDownMinimum.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownMinimum.TabIndex = 2;
            // 
            // numericUpDownMaximum
            // 
            this.numericUpDownMaximum.Location = new System.Drawing.Point(214, 7);
            this.numericUpDownMaximum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMaximum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownMaximum.Name = "numericUpDownMaximum";
            this.numericUpDownMaximum.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownMaximum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Čísla do: ";
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "Součet",
            "Rozdíl",
            "Součin",
            "Podíl"});
            this.comboBoxOperation.Location = new System.Drawing.Point(301, 6);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(93, 21);
            this.comboBoxOperation.TabIndex = 5;
            this.comboBoxOperation.Text = "Součet";
            // 
            // labelExercise
            // 
            this.labelExercise.AutoSize = true;
            this.labelExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExercise.Location = new System.Drawing.Point(12, 50);
            this.labelExercise.Name = "labelExercise";
            this.labelExercise.Size = new System.Drawing.Size(0, 18);
            this.labelExercise.TabIndex = 6;
            // 
            // numericUpDownResult
            // 
            this.numericUpDownResult.Location = new System.Drawing.Point(70, 50);
            this.numericUpDownResult.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownResult.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownResult.Name = "numericUpDownResult";
            this.numericUpDownResult.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownResult.TabIndex = 7;
            // 
            // buttonExercise
            // 
            this.buttonExercise.Location = new System.Drawing.Point(12, 86);
            this.buttonExercise.Name = "buttonExercise";
            this.buttonExercise.Size = new System.Drawing.Size(117, 23);
            this.buttonExercise.TabIndex = 8;
            this.buttonExercise.Text = "Generuj příklad";
            this.buttonExercise.UseVisualStyleBackColor = true;
            this.buttonExercise.Click += new System.EventHandler(this.buttonExercise_Click);
            // 
            // textBoxFailedExercises
            // 
            this.textBoxFailedExercises.ForeColor = System.Drawing.Color.Red;
            this.textBoxFailedExercises.Location = new System.Drawing.Point(12, 127);
            this.textBoxFailedExercises.Multiline = true;
            this.textBoxFailedExercises.Name = "textBoxFailedExercises";
            this.textBoxFailedExercises.ReadOnly = true;
            this.textBoxFailedExercises.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFailedExercises.Size = new System.Drawing.Size(138, 311);
            this.textBoxFailedExercises.TabIndex = 9;
            // 
            // buttonClearFailedExercises
            // 
            this.buttonClearFailedExercises.Location = new System.Drawing.Point(156, 127);
            this.buttonClearFailedExercises.Name = "buttonClearFailedExercises";
            this.buttonClearFailedExercises.Size = new System.Drawing.Size(139, 23);
            this.buttonClearFailedExercises.TabIndex = 10;
            this.buttonClearFailedExercises.Text = "Smazat špatné výpočty";
            this.buttonClearFailedExercises.UseVisualStyleBackColor = true;
            this.buttonClearFailedExercises.Click += new System.EventHandler(this.buttonClearFailedExercises_Click);
            // 
            // buttonLoadFailedExercises
            // 
            this.buttonLoadFailedExercises.Location = new System.Drawing.Point(156, 156);
            this.buttonLoadFailedExercises.Name = "buttonLoadFailedExercises";
            this.buttonLoadFailedExercises.Size = new System.Drawing.Size(139, 23);
            this.buttonLoadFailedExercises.TabIndex = 11;
            this.buttonLoadFailedExercises.Text = "Načíst špatné výpočty";
            this.buttonLoadFailedExercises.UseVisualStyleBackColor = true;
            this.buttonLoadFailedExercises.Click += new System.EventHandler(this.buttonLoadFailedExercises_Click);
            // 
            // buttonSaveFailedExercises
            // 
            this.buttonSaveFailedExercises.Location = new System.Drawing.Point(156, 185);
            this.buttonSaveFailedExercises.Name = "buttonSaveFailedExercises";
            this.buttonSaveFailedExercises.Size = new System.Drawing.Size(139, 23);
            this.buttonSaveFailedExercises.TabIndex = 12;
            this.buttonSaveFailedExercises.Text = "Uložit špatné výpočty";
            this.buttonSaveFailedExercises.UseVisualStyleBackColor = true;
            this.buttonSaveFailedExercises.Click += new System.EventHandler(this.buttonSaveFailedExercises_Click);
            // 
            // labelNumberOfExercises
            // 
            this.labelNumberOfExercises.AutoSize = true;
            this.labelNumberOfExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumberOfExercises.Location = new System.Drawing.Point(156, 222);
            this.labelNumberOfExercises.Name = "labelNumberOfExercises";
            this.labelNumberOfExercises.Size = new System.Drawing.Size(100, 16);
            this.labelNumberOfExercises.TabIndex = 13;
            this.labelNumberOfExercises.Text = "Počet příkladů: ";
            // 
            // labelSuccessfulExercises
            // 
            this.labelSuccessfulExercises.AutoSize = true;
            this.labelSuccessfulExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSuccessfulExercises.ForeColor = System.Drawing.Color.Green;
            this.labelSuccessfulExercises.Location = new System.Drawing.Point(156, 247);
            this.labelSuccessfulExercises.Name = "labelSuccessfulExercises";
            this.labelSuccessfulExercises.Size = new System.Drawing.Size(126, 16);
            this.labelSuccessfulExercises.TabIndex = 14;
            this.labelSuccessfulExercises.Text = "Správné odpovědi: ";
            // 
            // labelFailedExercises
            // 
            this.labelFailedExercises.AutoSize = true;
            this.labelFailedExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFailedExercises.ForeColor = System.Drawing.Color.Red;
            this.labelFailedExercises.Location = new System.Drawing.Point(156, 273);
            this.labelFailedExercises.Name = "labelFailedExercises";
            this.labelFailedExercises.Size = new System.Drawing.Size(118, 16);
            this.labelFailedExercises.TabIndex = 15;
            this.labelFailedExercises.Text = "Špatné odpovědi: ";
            // 
            // labelPercentageExercises
            // 
            this.labelPercentageExercises.AutoSize = true;
            this.labelPercentageExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPercentageExercises.Location = new System.Drawing.Point(156, 299);
            this.labelPercentageExercises.Name = "labelPercentageExercises";
            this.labelPercentageExercises.Size = new System.Drawing.Size(79, 16);
            this.labelPercentageExercises.TabIndex = 16;
            this.labelPercentageExercises.Text = "Úspěšnost: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.labelPercentageExercises);
            this.Controls.Add(this.labelFailedExercises);
            this.Controls.Add(this.labelSuccessfulExercises);
            this.Controls.Add(this.labelNumberOfExercises);
            this.Controls.Add(this.buttonSaveFailedExercises);
            this.Controls.Add(this.buttonLoadFailedExercises);
            this.Controls.Add(this.buttonClearFailedExercises);
            this.Controls.Add(this.textBoxFailedExercises);
            this.Controls.Add(this.buttonExercise);
            this.Controls.Add(this.numericUpDownResult);
            this.Controls.Add(this.labelExercise);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownMaximum);
            this.Controls.Add(this.numericUpDownMinimum);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3. Příklady z aritmetiky";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimum;
        private System.Windows.Forms.NumericUpDown numericUpDownMaximum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Label labelExercise;
        private System.Windows.Forms.NumericUpDown numericUpDownResult;
        private System.Windows.Forms.Button buttonExercise;
        private System.Windows.Forms.TextBox textBoxFailedExercises;
        private System.Windows.Forms.Button buttonClearFailedExercises;
        private System.Windows.Forms.Button buttonLoadFailedExercises;
        private System.Windows.Forms.Button buttonSaveFailedExercises;
        private System.Windows.Forms.Label labelNumberOfExercises;
        private System.Windows.Forms.Label labelSuccessfulExercises;
        private System.Windows.Forms.Label labelFailedExercises;
        private System.Windows.Forms.Label labelPercentageExercises;
    }
}

