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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAlgorithm = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.labelReady = new System.Windows.Forms.Label();
            this.comboBoxTabuSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTabu = new System.Windows.Forms.DataGridView();
            this.textBoxActualStep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBestScore = new System.Windows.Forms.TextBox();
            this.txtBestTurn = new System.Windows.Forms.TextBox();
            this.txtStartScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStartTS = new System.Windows.Forms.Button();
            this.comboBoxBigReset = new System.Windows.Forms.ComboBox();
            this.comboBoxLittleReset = new System.Windows.Forms.ComboBox();
            this.comboBoxTabuSteps = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPercent = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageAlgorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabu)).BeginInit();
            this.tabPageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAlgorithm);
            this.tabControl1.Controls.Add(this.tabPageResult);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAlgorithm
            // 
            this.tabPageAlgorithm.BackColor = System.Drawing.Color.Black;
            this.tabPageAlgorithm.Controls.Add(this.button2);
            this.tabPageAlgorithm.Controls.Add(this.labelReady);
            this.tabPageAlgorithm.Controls.Add(this.comboBoxTabuSize);
            this.tabPageAlgorithm.Controls.Add(this.label8);
            this.tabPageAlgorithm.Controls.Add(this.chart1);
            this.tabPageAlgorithm.Controls.Add(this.dataGridViewTabu);
            this.tabPageAlgorithm.Controls.Add(this.textBoxActualStep);
            this.tabPageAlgorithm.Controls.Add(this.label7);
            this.tabPageAlgorithm.Controls.Add(this.txtBestScore);
            this.tabPageAlgorithm.Controls.Add(this.txtBestTurn);
            this.tabPageAlgorithm.Controls.Add(this.txtStartScore);
            this.tabPageAlgorithm.Controls.Add(this.label6);
            this.tabPageAlgorithm.Controls.Add(this.label5);
            this.tabPageAlgorithm.Controls.Add(this.label3);
            this.tabPageAlgorithm.Controls.Add(this.buttonStartTS);
            this.tabPageAlgorithm.Controls.Add(this.comboBoxBigReset);
            this.tabPageAlgorithm.Controls.Add(this.comboBoxLittleReset);
            this.tabPageAlgorithm.Controls.Add(this.comboBoxTabuSteps);
            this.tabPageAlgorithm.Controls.Add(this.label4);
            this.tabPageAlgorithm.Controls.Add(this.label2);
            this.tabPageAlgorithm.Controls.Add(this.label1);
            this.tabPageAlgorithm.Location = new System.Drawing.Point(4, 26);
            this.tabPageAlgorithm.Name = "tabPageAlgorithm";
            this.tabPageAlgorithm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlgorithm.Size = new System.Drawing.Size(726, 538);
            this.tabPageAlgorithm.TabIndex = 0;
            this.tabPageAlgorithm.Text = "Obliczenia";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(607, 122);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(1);
            this.button2.Size = new System.Drawing.Size(111, 46);
            this.button2.TabIndex = 42;
            this.button2.Text = "Wczytaj z pliku";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelReady
            // 
            this.labelReady.AutoSize = true;
            this.labelReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelReady.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.labelReady.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReady.Location = new System.Drawing.Point(17, 418);
            this.labelReady.Name = "labelReady";
            this.labelReady.Size = new System.Drawing.Size(0, 29);
            this.labelReady.TabIndex = 33;
            // 
            // comboBoxTabuSize
            // 
            this.comboBoxTabuSize.FormattingEnabled = true;
            this.comboBoxTabuSize.Location = new System.Drawing.Point(268, 63);
            this.comboBoxTabuSize.Name = "comboBoxTabuSize";
            this.comboBoxTabuSize.Size = new System.Drawing.Size(62, 25);
            this.comboBoxTabuSize.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(36, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Długość listy tabu";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(267, 204);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(451, 300);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // dataGridViewTabu
            // 
            this.dataGridViewTabu.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewTabu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabu.Location = new System.Drawing.Point(267, 204);
            this.dataGridViewTabu.Name = "dataGridViewTabu";
            this.dataGridViewTabu.Size = new System.Drawing.Size(457, 311);
            this.dataGridViewTabu.TabIndex = 29;
            // 
            // textBoxActualStep
            // 
            this.textBoxActualStep.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxActualStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxActualStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxActualStep.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxActualStep.Location = new System.Drawing.Point(172, 323);
            this.textBoxActualStep.Name = "textBoxActualStep";
            this.textBoxActualStep.Size = new System.Drawing.Size(71, 16);
            this.textBoxActualStep.TabIndex = 28;
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
            // txtBestScore
            // 
            this.txtBestScore.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBestScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBestScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBestScore.Location = new System.Drawing.Point(172, 256);
            this.txtBestScore.Name = "txtBestScore";
            this.txtBestScore.Size = new System.Drawing.Size(71, 16);
            this.txtBestScore.TabIndex = 26;
            // 
            // txtBestTurn
            // 
            this.txtBestTurn.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBestTurn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBestTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBestTurn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBestTurn.Location = new System.Drawing.Point(172, 290);
            this.txtBestTurn.Name = "txtBestTurn";
            this.txtBestTurn.Size = new System.Drawing.Size(71, 16);
            this.txtBestTurn.TabIndex = 25;
            // 
            // txtStartScore
            // 
            this.txtStartScore.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtStartScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStartScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtStartScore.Location = new System.Drawing.Point(172, 222);
            this.txtStartScore.Name = "txtStartScore";
            this.txtStartScore.Size = new System.Drawing.Size(71, 16);
            this.txtStartScore.TabIndex = 24;
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
            this.buttonStartTS.Location = new System.Drawing.Point(241, 121);
            this.buttonStartTS.Name = "buttonStartTS";
            this.buttonStartTS.Padding = new System.Windows.Forms.Padding(1);
            this.buttonStartTS.Size = new System.Drawing.Size(288, 30);
            this.buttonStartTS.TabIndex = 19;
            this.buttonStartTS.Text = "Start Tabu Search";
            this.buttonStartTS.UseVisualStyleBackColor = false;
            this.buttonStartTS.Click += new System.EventHandler(this.buttonStartTS_Click);
            // 
            // comboBoxBigReset
            // 
            this.comboBoxBigReset.FormattingEnabled = true;
            this.comboBoxBigReset.Location = new System.Drawing.Point(642, 63);
            this.comboBoxBigReset.Name = "comboBoxBigReset";
            this.comboBoxBigReset.Size = new System.Drawing.Size(62, 25);
            this.comboBoxBigReset.TabIndex = 18;
            // 
            // comboBoxLittleReset
            // 
            this.comboBoxLittleReset.FormattingEnabled = true;
            this.comboBoxLittleReset.Location = new System.Drawing.Point(642, 24);
            this.comboBoxLittleReset.Name = "comboBoxLittleReset";
            this.comboBoxLittleReset.Size = new System.Drawing.Size(62, 25);
            this.comboBoxLittleReset.TabIndex = 17;
            // 
            // comboBoxTabuSteps
            // 
            this.comboBoxTabuSteps.FormattingEnabled = true;
            this.comboBoxTabuSteps.Location = new System.Drawing.Point(268, 20);
            this.comboBoxTabuSteps.Name = "comboBoxTabuSteps";
            this.comboBoxTabuSteps.Size = new System.Drawing.Size(62, 25);
            this.comboBoxTabuSteps.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(410, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Limit ruchów - mały reset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(410, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Limit ruchów - duży reset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Limit kroków algorytmu";
            // 
            // tabPageResult
            // 
            this.tabPageResult.BackColor = System.Drawing.Color.Black;
            this.tabPageResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageResult.Controls.Add(this.button1);
            this.tabPageResult.Controls.Add(this.dataGridViewResult);
            this.tabPageResult.Controls.Add(this.label10);
            this.tabPageResult.Controls.Add(this.textBoxPercent);
            this.tabPageResult.Controls.Add(this.textBoxResult);
            this.tabPageResult.Controls.Add(this.label9);
            this.tabPageResult.Controls.Add(this.labelResult);
            this.tabPageResult.Location = new System.Drawing.Point(4, 26);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(726, 538);
            this.tabPageResult.TabIndex = 1;
            this.tabPageResult.Text = "Wynik";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(597, 1);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(1);
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Zapis do pliku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewResult.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridViewResult.Location = new System.Drawing.Point(3, 157);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(716, 374);
            this.dataGridViewResult.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(6, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 27);
            this.label10.TabIndex = 4;
            this.label10.Text = "Rozwiązanie:";
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPercent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPercent.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxPercent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxPercent.Location = new System.Drawing.Point(398, 70);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.Size = new System.Drawing.Size(89, 25);
            this.textBoxPercent.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxResult.Location = new System.Drawing.Point(398, 20);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(89, 25);
            this.textBoxResult.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(109, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Poprawa wyniku (%)";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.labelResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelResult.Location = new System.Drawing.Point(109, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(193, 27);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Uzyskany wynik";
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
            this.Text = "Tabu Search";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlgorithm.ResumeLayout(false);
            this.tabPageAlgorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabu)).EndInit();
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxTabuSteps;
        private System.Windows.Forms.TextBox textBoxActualStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBestScore;
        private System.Windows.Forms.TextBox txtBestTurn;
        private System.Windows.Forms.TextBox txtStartScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStartTS;
        private System.Windows.Forms.DataGridView dataGridViewTabu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxTabuSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelReady;
        private System.Windows.Forms.TextBox textBoxPercent;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}