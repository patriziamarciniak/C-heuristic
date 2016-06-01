namespace Projekt_Zaawansowane_Programowanie
{
    partial class TabuSearch
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAlgorithm = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLimit = new System.Windows.Forms.ComboBox();
            this.comboBoxLittleReset = new System.Windows.Forms.ComboBox();
            this.comboBoxBigReset = new System.Windows.Forms.ComboBox();
            this.buttonStartTS = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartScore = new System.Windows.Forms.TextBox();
            this.txtBestTurn = new System.Windows.Forms.TextBox();
            this.txtBestScore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageAlgorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAlgorithm);
            this.tabControl1.Controls.Add(this.tabPageResult);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAlgorithm
            // 
            this.tabPageAlgorithm.BackColor = System.Drawing.Color.Black;
            this.tabPageAlgorithm.Controls.Add(this.textBox4);
            this.tabPageAlgorithm.Controls.Add(this.label7);
            this.tabPageAlgorithm.Controls.Add(this.txtBestScore);
            this.tabPageAlgorithm.Controls.Add(this.txtBestTurn);
            this.tabPageAlgorithm.Controls.Add(this.txtStartScore);
            this.tabPageAlgorithm.Controls.Add(this.label6);
            this.tabPageAlgorithm.Controls.Add(this.label5);
            this.tabPageAlgorithm.Controls.Add(this.label3);
            this.tabPageAlgorithm.Controls.Add(this.progressBar1);
            this.tabPageAlgorithm.Controls.Add(this.buttonStartTS);
            this.tabPageAlgorithm.Controls.Add(this.comboBoxBigReset);
            this.tabPageAlgorithm.Controls.Add(this.comboBoxLittleReset);
            this.tabPageAlgorithm.Controls.Add(this.comboBoxLimit);
            this.tabPageAlgorithm.Controls.Add(this.label4);
            this.tabPageAlgorithm.Controls.Add(this.label2);
            this.tabPageAlgorithm.Controls.Add(this.label1);
            this.tabPageAlgorithm.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlgorithm.Name = "tabPageAlgorithm";
            this.tabPageAlgorithm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlgorithm.Size = new System.Drawing.Size(726, 542);
            this.tabPageAlgorithm.TabIndex = 0;
            this.tabPageAlgorithm.Text = "Obliczenia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(146, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Limit kroków algorytmu";
            // 
            // tabPageResult
            // 
            this.tabPageResult.BackColor = System.Drawing.Color.Black;
            this.tabPageResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(726, 542);
            this.tabPageResult.TabIndex = 1;
            this.tabPageResult.Text = "Wynik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(146, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Limit ruchów bez poprawy wyniku - duży reset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(146, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Limit ruchów bez poprawy wyniku - mały reset";
            // 
            // comboBoxLimit
            // 
            this.comboBoxLimit.FormattingEnabled = true;
            this.comboBoxLimit.Location = new System.Drawing.Point(555, 24);
            this.comboBoxLimit.Name = "comboBoxLimit";
            this.comboBoxLimit.Size = new System.Drawing.Size(62, 21);
            this.comboBoxLimit.TabIndex = 16;
            // 
            // comboBoxLittleReset
            // 
            this.comboBoxLittleReset.FormattingEnabled = true;
            this.comboBoxLittleReset.Location = new System.Drawing.Point(555, 63);
            this.comboBoxLittleReset.Name = "comboBoxLittleReset";
            this.comboBoxLittleReset.Size = new System.Drawing.Size(62, 21);
            this.comboBoxLittleReset.TabIndex = 17;
            // 
            // comboBoxBigReset
            // 
            this.comboBoxBigReset.FormattingEnabled = true;
            this.comboBoxBigReset.Location = new System.Drawing.Point(555, 101);
            this.comboBoxBigReset.Name = "comboBoxBigReset";
            this.comboBoxBigReset.Size = new System.Drawing.Size(62, 21);
            this.comboBoxBigReset.TabIndex = 18;
            // 
            // buttonStartTS
            // 
            this.buttonStartTS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStartTS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonStartTS.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.buttonStartTS.FlatAppearance.BorderSize = 5;
            this.buttonStartTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonStartTS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartTS.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartTS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStartTS.Location = new System.Drawing.Point(268, 159);
            this.buttonStartTS.Name = "buttonStartTS";
            this.buttonStartTS.Padding = new System.Windows.Forms.Padding(1);
            this.buttonStartTS.Size = new System.Drawing.Size(248, 30);
            this.buttonStartTS.TabIndex = 19;
            this.buttonStartTS.Text = "Start Tabu Search";
            this.buttonStartTS.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 515);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(729, 30);
            this.progressBar1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Wynik startowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Najlepszy wynik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(17, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Uzyskany w turze";
            // 
            // txtStartScore
            // 
            this.txtStartScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStartScore.Location = new System.Drawing.Point(172, 222);
            this.txtStartScore.Name = "txtStartScore";
            this.txtStartScore.Size = new System.Drawing.Size(71, 20);
            this.txtStartScore.TabIndex = 24;
            // 
            // txtBestTurn
            // 
            this.txtBestTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBestTurn.Location = new System.Drawing.Point(172, 290);
            this.txtBestTurn.Name = "txtBestTurn";
            this.txtBestTurn.Size = new System.Drawing.Size(71, 20);
            this.txtBestTurn.TabIndex = 25;
            // 
            // txtBestScore
            // 
            this.txtBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBestScore.Location = new System.Drawing.Point(172, 256);
            this.txtBestScore.Name = "txtBestScore";
            this.txtBestScore.Size = new System.Drawing.Size(71, 20);
            this.txtBestScore.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(17, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Aktualna tura";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(172, 323);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(71, 20);
            this.textBox4.TabIndex = 28;
            // 
            // TabuSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 568);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "TabuSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlgorithm.ResumeLayout(false);
            this.tabPageAlgorithm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAlgorithm;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBigReset;
        private System.Windows.Forms.ComboBox comboBoxLittleReset;
        private System.Windows.Forms.ComboBox comboBoxLimit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBestScore;
        private System.Windows.Forms.TextBox txtBestTurn;
        private System.Windows.Forms.TextBox txtStartScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonStartTS;
    }
}