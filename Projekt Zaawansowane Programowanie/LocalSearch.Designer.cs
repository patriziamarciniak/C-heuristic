﻿namespace Projekt_Zaawansowane_Programowanie
{
    partial class LocalSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxStartScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTabuSearch = new System.Windows.Forms.Button();
            this.textBoxLocalSearchScore = new System.Windows.Forms.TextBox();
            this.labelPrimarySolution = new System.Windows.Forms.Label();
            this.labelLocalSearchScore = new System.Windows.Forms.Label();
            this.buttonGenerateLS = new System.Windows.Forms.Button();
            this.comboBoxRestarts = new System.Windows.Forms.ComboBox();
            this.comboBoxTurns = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewLocalSearch = new System.Windows.Forms.DataGridView();
            this.czas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.czas);
            this.panel1.Controls.Add(this.textBoxStartScore);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonTabuSearch);
            this.panel1.Controls.Add(this.textBoxLocalSearchScore);
            this.panel1.Controls.Add(this.labelPrimarySolution);
            this.panel1.Controls.Add(this.labelLocalSearchScore);
            this.panel1.Controls.Add(this.buttonGenerateLS);
            this.panel1.Controls.Add(this.comboBoxRestarts);
            this.panel1.Controls.Add(this.comboBoxTurns);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 194);
            this.panel1.TabIndex = 0;
            // 
            // textBoxStartScore
            // 
            this.textBoxStartScore.BackColor = System.Drawing.Color.Black;
            this.textBoxStartScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStartScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxStartScore.Location = new System.Drawing.Point(644, 23);
            this.textBoxStartScore.Name = "textBoxStartScore";
            this.textBoxStartScore.Size = new System.Drawing.Size(66, 19);
            this.textBoxStartScore.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(422, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Wynik przed Local Search:";
            // 
            // buttonTabuSearch
            // 
            this.buttonTabuSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabuSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonTabuSearch.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.buttonTabuSearch.FlatAppearance.BorderSize = 5;
            this.buttonTabuSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonTabuSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTabuSearch.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabuSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTabuSearch.Location = new System.Drawing.Point(425, 116);
            this.buttonTabuSearch.Name = "buttonTabuSearch";
            this.buttonTabuSearch.Padding = new System.Windows.Forms.Padding(1);
            this.buttonTabuSearch.Size = new System.Drawing.Size(248, 30);
            this.buttonTabuSearch.TabIndex = 19;
            this.buttonTabuSearch.Text = "Dalej -> Tabu Search";
            this.buttonTabuSearch.UseVisualStyleBackColor = false;
            this.buttonTabuSearch.Click += new System.EventHandler(this.buttonTabuSearch_Click);
            // 
            // textBoxLocalSearchScore
            // 
            this.textBoxLocalSearchScore.BackColor = System.Drawing.Color.Black;
            this.textBoxLocalSearchScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLocalSearchScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLocalSearchScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxLocalSearchScore.Location = new System.Drawing.Point(644, 57);
            this.textBoxLocalSearchScore.Name = "textBoxLocalSearchScore";
            this.textBoxLocalSearchScore.Size = new System.Drawing.Size(66, 19);
            this.textBoxLocalSearchScore.TabIndex = 18;
            // 
            // labelPrimarySolution
            // 
            this.labelPrimarySolution.AutoSize = true;
            this.labelPrimarySolution.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelPrimarySolution.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelPrimarySolution.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrimarySolution.Location = new System.Drawing.Point(12, 175);
            this.labelPrimarySolution.Name = "labelPrimarySolution";
            this.labelPrimarySolution.Size = new System.Drawing.Size(280, 17);
            this.labelPrimarySolution.TabIndex = 17;
            this.labelPrimarySolution.Text = "Wygenerowane rozwiązanie wstępne:";
            this.labelPrimarySolution.Visible = false;
            // 
            // labelLocalSearchScore
            // 
            this.labelLocalSearchScore.AutoSize = true;
            this.labelLocalSearchScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelLocalSearchScore.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelLocalSearchScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLocalSearchScore.Location = new System.Drawing.Point(422, 62);
            this.labelLocalSearchScore.Name = "labelLocalSearchScore";
            this.labelLocalSearchScore.Size = new System.Drawing.Size(182, 17);
            this.labelLocalSearchScore.TabIndex = 16;
            this.labelLocalSearchScore.Text = "Wynik po Local Search:";
            // 
            // buttonGenerateLS
            // 
            this.buttonGenerateLS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGenerateLS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGenerateLS.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.buttonGenerateLS.FlatAppearance.BorderSize = 5;
            this.buttonGenerateLS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonGenerateLS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateLS.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateLS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGenerateLS.Location = new System.Drawing.Point(69, 116);
            this.buttonGenerateLS.Name = "buttonGenerateLS";
            this.buttonGenerateLS.Padding = new System.Windows.Forms.Padding(1);
            this.buttonGenerateLS.Size = new System.Drawing.Size(248, 30);
            this.buttonGenerateLS.TabIndex = 15;
            this.buttonGenerateLS.Text = "Generuj rozwiązanie wstępne";
            this.buttonGenerateLS.UseVisualStyleBackColor = false;
            this.buttonGenerateLS.Click += new System.EventHandler(this.buttonGenerateInstance_Click);
            // 
            // comboBoxRestarts
            // 
            this.comboBoxRestarts.FormattingEnabled = true;
            this.comboBoxRestarts.Location = new System.Drawing.Point(246, 55);
            this.comboBoxRestarts.Name = "comboBoxRestarts";
            this.comboBoxRestarts.Size = new System.Drawing.Size(62, 21);
            this.comboBoxRestarts.TabIndex = 14;
            // 
            // comboBoxTurns
            // 
            this.comboBoxTurns.FormattingEnabled = true;
            this.comboBoxTurns.Location = new System.Drawing.Point(246, 24);
            this.comboBoxTurns.Name = "comboBoxTurns";
            this.comboBoxTurns.Size = new System.Drawing.Size(62, 21);
            this.comboBoxTurns.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(80, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Liczba restartów";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(80, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Liczba tur";
            // 
            // dataGridViewLocalSearch
            // 
            this.dataGridViewLocalSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLocalSearch.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewLocalSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalSearch.Location = new System.Drawing.Point(0, 195);
            this.dataGridViewLocalSearch.Name = "dataGridViewLocalSearch";
            this.dataGridViewLocalSearch.Size = new System.Drawing.Size(735, 371);
            this.dataGridViewLocalSearch.TabIndex = 1;
            // 
            // czas
            // 
            this.czas.BackColor = System.Drawing.Color.Black;
            this.czas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.czas.Location = new System.Drawing.Point(644, 91);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(66, 19);
            this.czas.TabIndex = 22;
            // 
            // LocalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(734, 568);
            this.Controls.Add(this.dataGridViewLocalSearch);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "LocalSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Start Local Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRestarts;
        private System.Windows.Forms.ComboBox comboBoxTurns;
        private System.Windows.Forms.TextBox textBoxLocalSearchScore;
        private System.Windows.Forms.Label labelPrimarySolution;
        private System.Windows.Forms.Label labelLocalSearchScore;
        private System.Windows.Forms.Button buttonGenerateLS;
        private System.Windows.Forms.DataGridView dataGridViewLocalSearch;
        private System.Windows.Forms.Button buttonTabuSearch;
        private System.Windows.Forms.TextBox textBoxStartScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox czas;
    }
}