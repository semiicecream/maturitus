namespace _4.Stopky
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxTimes = new System.Windows.Forms.TextBox();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonTimeAdd = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelStatistics = new System.Windows.Forms.Label();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(128, 31);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            // 
            // textBoxTimes
            // 
            this.textBoxTimes.Location = new System.Drawing.Point(12, 43);
            this.textBoxTimes.Multiline = true;
            this.textBoxTimes.Name = "textBoxTimes";
            this.textBoxTimes.ReadOnly = true;
            this.textBoxTimes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTimes.Size = new System.Drawing.Size(128, 395);
            this.textBoxTimes.TabIndex = 1;
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.Location = new System.Drawing.Point(155, 17);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(84, 23);
            this.buttonStartPause.TabIndex = 2;
            this.buttonStartPause.Text = "Spustit";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(335, 17);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Vynulovat";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(155, 120);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Uložit časy";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(155, 149);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(84, 23);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Načíst časy";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(155, 178);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(84, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Vymazat časy";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonTimeAdd
            // 
            this.buttonTimeAdd.Location = new System.Drawing.Point(245, 17);
            this.buttonTimeAdd.Name = "buttonTimeAdd";
            this.buttonTimeAdd.Size = new System.Drawing.Size(84, 23);
            this.buttonTimeAdd.TabIndex = 7;
            this.buttonTimeAdd.Text = "Mezičas";
            this.buttonTimeAdd.UseVisualStyleBackColor = true;
            this.buttonTimeAdd.Click += new System.EventHandler(this.buttonTimeAdd_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatistics.Location = new System.Drawing.Point(152, 213);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(281, 112);
            this.labelStatistics.TabIndex = 8;
            this.labelStatistics.Text = resources.GetString("labelStatistics.Text");
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(155, 91);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(84, 23);
            this.buttonStatistics.TabIndex = 9;
            this.buttonStatistics.Text = "Statistika";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.labelStatistics);
            this.Controls.Add(this.buttonTimeAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStartPause);
            this.Controls.Add(this.textBoxTimes);
            this.Controls.Add(this.labelTime);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxTimes;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonTimeAdd;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.Button buttonStatistics;
    }
}

