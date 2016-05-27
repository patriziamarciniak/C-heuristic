namespace Projekt_Zaawansowane_Programowanie
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTurns = new System.Windows.Forms.ComboBox();
            this.comboBoxRestarts = new System.Windows.Forms.ComboBox();
            this.buttonGenerateInstance = new System.Windows.Forms.Button();
            this.labelLocalSearchScore = new System.Windows.Forms.Label();
            this.labelPrimarySolution = new System.Windows.Forms.Label();
            this.textBoxLocalSearchScore = new System.Windows.Forms.TextBox();
            this.dataGridViewLocalSearch = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxLocalSearchScore);
            this.panel1.Controls.Add(this.labelPrimarySolution);
            this.panel1.Controls.Add(this.labelLocalSearchScore);
            this.panel1.Controls.Add(this.buttonGenerateInstance);
            this.panel1.Controls.Add(this.comboBoxRestarts);
            this.panel1.Controls.Add(this.comboBoxTurns);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 194);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(138, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Liczba tur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(138, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Liczba restartów";
            // 
            // comboBoxTurns
            // 
            this.comboBoxTurns.FormattingEnabled = true;
            this.comboBoxTurns.Location = new System.Drawing.Point(304, 26);
            this.comboBoxTurns.Name = "comboBoxTurns";
            this.comboBoxTurns.Size = new System.Drawing.Size(62, 21);
            this.comboBoxTurns.TabIndex = 13;
            // 
            // comboBoxRestarts
            // 
            this.comboBoxRestarts.FormattingEnabled = true;
            this.comboBoxRestarts.Location = new System.Drawing.Point(304, 57);
            this.comboBoxRestarts.Name = "comboBoxRestarts";
            this.comboBoxRestarts.Size = new System.Drawing.Size(62, 21);
            this.comboBoxRestarts.TabIndex = 14;
            // 
            // buttonGenerateInstance
            // 
            this.buttonGenerateInstance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGenerateInstance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGenerateInstance.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.buttonGenerateInstance.FlatAppearance.BorderSize = 5;
            this.buttonGenerateInstance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonGenerateInstance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateInstance.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateInstance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGenerateInstance.Location = new System.Drawing.Point(164, 106);
            this.buttonGenerateInstance.Name = "buttonGenerateInstance";
            this.buttonGenerateInstance.Padding = new System.Windows.Forms.Padding(1);
            this.buttonGenerateInstance.Size = new System.Drawing.Size(192, 30);
            this.buttonGenerateInstance.TabIndex = 15;
            this.buttonGenerateInstance.Text = "Generuj instancję";
            this.buttonGenerateInstance.UseVisualStyleBackColor = false;
            // 
            // labelLocalSearchScore
            // 
            this.labelLocalSearchScore.AutoSize = true;
            this.labelLocalSearchScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelLocalSearchScore.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelLocalSearchScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLocalSearchScore.Location = new System.Drawing.Point(378, 168);
            this.labelLocalSearchScore.Name = "labelLocalSearchScore";
            this.labelLocalSearchScore.Size = new System.Drawing.Size(62, 17);
            this.labelLocalSearchScore.TabIndex = 16;
            this.labelLocalSearchScore.Text = "Wynik:";
            this.labelLocalSearchScore.Visible = false;
            // 
            // labelPrimarySolution
            // 
            this.labelPrimarySolution.AutoSize = true;
            this.labelPrimarySolution.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelPrimarySolution.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelPrimarySolution.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrimarySolution.Location = new System.Drawing.Point(3, 168);
            this.labelPrimarySolution.Name = "labelPrimarySolution";
            this.labelPrimarySolution.Size = new System.Drawing.Size(280, 17);
            this.labelPrimarySolution.TabIndex = 17;
            this.labelPrimarySolution.Text = "Wygenerowane rozwiązanie wstępne:";
            this.labelPrimarySolution.Visible = false;
            // 
            // textBoxLocalSearchScore
            // 
            this.textBoxLocalSearchScore.BackColor = System.Drawing.Color.Black;
            this.textBoxLocalSearchScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLocalSearchScore.Location = new System.Drawing.Point(453, 165);
            this.textBoxLocalSearchScore.Name = "textBoxLocalSearchScore";
            this.textBoxLocalSearchScore.Size = new System.Drawing.Size(66, 20);
            this.textBoxLocalSearchScore.TabIndex = 18;
            // 
            // dataGridViewLocalSearch
            // 
            this.dataGridViewLocalSearch.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewLocalSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalSearch.Location = new System.Drawing.Point(0, 195);
            this.dataGridViewLocalSearch.Name = "dataGridViewLocalSearch";
            this.dataGridViewLocalSearch.Size = new System.Drawing.Size(531, 289);
            this.dataGridViewLocalSearch.TabIndex = 1;
            // 
            // LocalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(531, 484);
            this.Controls.Add(this.dataGridViewLocalSearch);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button buttonGenerateInstance;
        private System.Windows.Forms.DataGridView dataGridViewLocalSearch;
    }
}