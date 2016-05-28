using System.Linq;

namespace Projekt_Zaawansowane_Programowanie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGoLocalSearch = new System.Windows.Forms.Button();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnUserInstance = new System.Windows.Forms.Button();
            this.buttonGenerateErrors = new System.Windows.Forms.Button();
            this.buttonGenerateInstance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSamples = new System.Windows.Forms.Label();
            this.comboBoxErrors = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaces = new System.Windows.Forms.ComboBox();
            this.comboBoxSamples = new System.Windows.Forms.ComboBox();
            this.openFileInput = new System.Windows.Forms.OpenFileDialog();
            this.saveFileInput = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewInput);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 568);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInput.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInput.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewInput.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.Size = new System.Drawing.Size(439, 544);
            this.dataGridViewInput.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemReadFile,
            this.MenuItemSaveFile});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem1.Text = "Instancja";
            // 
            // MenuItemReadFile
            // 
            this.MenuItemReadFile.Name = "MenuItemReadFile";
            this.MenuItemReadFile.Size = new System.Drawing.Size(162, 22);
            this.MenuItemReadFile.Text = "Wczytaj z pliku";
            this.MenuItemReadFile.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // MenuItemSaveFile
            // 
            this.MenuItemSaveFile.Name = "MenuItemSaveFile";
            this.MenuItemSaveFile.Size = new System.Drawing.Size(162, 22);
            this.MenuItemSaveFile.Text = "Zapisz do pliku";
            this.MenuItemSaveFile.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnGoLocalSearch);
            this.panel2.Controls.Add(this.comboBoxLevel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnShuffle);
            this.panel2.Controls.Add(this.btnUserInstance);
            this.panel2.Controls.Add(this.buttonGenerateErrors);
            this.panel2.Controls.Add(this.buttonGenerateInstance);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelSamples);
            this.panel2.Controls.Add(this.comboBoxErrors);
            this.panel2.Controls.Add(this.comboBoxPlaces);
            this.panel2.Controls.Add(this.comboBoxSamples);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(440, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 568);
            this.panel2.TabIndex = 1;
            // 
            // btnGoLocalSearch
            // 
            this.btnGoLocalSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoLocalSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGoLocalSearch.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.btnGoLocalSearch.FlatAppearance.BorderSize = 5;
            this.btnGoLocalSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGoLocalSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoLocalSearch.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoLocalSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGoLocalSearch.Location = new System.Drawing.Point(20, 514);
            this.btnGoLocalSearch.Name = "btnGoLocalSearch";
            this.btnGoLocalSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btnGoLocalSearch.Size = new System.Drawing.Size(259, 30);
            this.btnGoLocalSearch.TabIndex = 12;
            this.btnGoLocalSearch.Text = "Dalej -> Rozwiązanie początkowe";
            this.btnGoLocalSearch.UseVisualStyleBackColor = false;
            this.btnGoLocalSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Łatwy",
            "Średni",
            "Trudny"});
            this.comboBoxLevel.Location = new System.Drawing.Point(186, 104);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(93, 21);
            this.comboBoxLevel.TabIndex = 11;
            this.comboBoxLevel.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Poziom trudności";
            // 
            // btnShuffle
            // 
            this.btnShuffle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShuffle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShuffle.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.btnShuffle.FlatAppearance.BorderSize = 5;
            this.btnShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShuffle.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShuffle.Location = new System.Drawing.Point(85, 408);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Padding = new System.Windows.Forms.Padding(1);
            this.btnShuffle.Size = new System.Drawing.Size(148, 62);
            this.btnShuffle.TabIndex = 9;
            this.btnShuffle.Text = "Generuj losową kolejność kolumn";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnUserInstance
            // 
            this.btnUserInstance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUserInstance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUserInstance.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.btnUserInstance.FlatAppearance.BorderSize = 5;
            this.btnUserInstance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUserInstance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserInstance.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInstance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUserInstance.Location = new System.Drawing.Point(85, 217);
            this.btnUserInstance.Name = "btnUserInstance";
            this.btnUserInstance.Padding = new System.Windows.Forms.Padding(1);
            this.btnUserInstance.Size = new System.Drawing.Size(148, 30);
            this.btnUserInstance.TabIndex = 8;
            this.btnUserInstance.Text = "Moja instancja";
            this.btnUserInstance.UseVisualStyleBackColor = false;
            this.btnUserInstance.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGenerateErrors
            // 
            this.buttonGenerateErrors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGenerateErrors.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGenerateErrors.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.buttonGenerateErrors.FlatAppearance.BorderSize = 5;
            this.buttonGenerateErrors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonGenerateErrors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateErrors.Font = new System.Drawing.Font("Georgia Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateErrors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGenerateErrors.Location = new System.Drawing.Point(85, 334);
            this.buttonGenerateErrors.Name = "buttonGenerateErrors";
            this.buttonGenerateErrors.Padding = new System.Windows.Forms.Padding(1);
            this.buttonGenerateErrors.Size = new System.Drawing.Size(148, 30);
            this.buttonGenerateErrors.TabIndex = 7;
            this.buttonGenerateErrors.Text = "Generuj błędy";
            this.buttonGenerateErrors.UseVisualStyleBackColor = false;
            this.buttonGenerateErrors.Click += new System.EventHandler(this.buttonGenerateErrors_Click);
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
            this.buttonGenerateInstance.Location = new System.Drawing.Point(85, 172);
            this.buttonGenerateInstance.Name = "buttonGenerateInstance";
            this.buttonGenerateInstance.Padding = new System.Windows.Forms.Padding(1);
            this.buttonGenerateInstance.Size = new System.Drawing.Size(148, 30);
            this.buttonGenerateInstance.TabIndex = 6;
            this.buttonGenerateInstance.Text = "Generuj instancję";
            this.buttonGenerateInstance.UseVisualStyleBackColor = false;
            this.buttonGenerateInstance.Click += new System.EventHandler(this.buttonGenerateInstance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liczba miejsc hybrydyzacji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(82, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liczba błędów";
            // 
            // labelSamples
            // 
            this.labelSamples.AutoSize = true;
            this.labelSamples.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSamples.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelSamples.Location = new System.Drawing.Point(5, 33);
            this.labelSamples.Name = "labelSamples";
            this.labelSamples.Size = new System.Drawing.Size(131, 17);
            this.labelSamples.TabIndex = 3;
            this.labelSamples.Text = "Liczba sekwencji";
            // 
            // comboBoxErrors
            // 
            this.comboBoxErrors.FormattingEnabled = true;
            this.comboBoxErrors.Location = new System.Drawing.Point(217, 269);
            this.comboBoxErrors.Name = "comboBoxErrors";
            this.comboBoxErrors.Size = new System.Drawing.Size(62, 21);
            this.comboBoxErrors.TabIndex = 2;
            // 
            // comboBoxPlaces
            // 
            this.comboBoxPlaces.FormattingEnabled = true;
            this.comboBoxPlaces.Location = new System.Drawing.Point(217, 66);
            this.comboBoxPlaces.Name = "comboBoxPlaces";
            this.comboBoxPlaces.Size = new System.Drawing.Size(62, 21);
            this.comboBoxPlaces.TabIndex = 1;
            // 
            // comboBoxSamples
            // 
            this.comboBoxSamples.FormattingEnabled = true;
            this.comboBoxSamples.Location = new System.Drawing.Point(217, 29);
            this.comboBoxSamples.Name = "comboBoxSamples";
            this.comboBoxSamples.Size = new System.Drawing.Size(62, 21);
            this.comboBoxSamples.TabIndex = 0;
            // 
            // openFileInput
            // 
            this.openFileInput.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaawansowane Programowanie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.Label labelSamples;
        private System.Windows.Forms.ComboBox comboBoxErrors;
        private System.Windows.Forms.ComboBox comboBoxPlaces;
        private System.Windows.Forms.ComboBox comboBoxSamples;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerateInstance;
        private System.Windows.Forms.Button buttonGenerateErrors;
        private System.Windows.Forms.Button btnUserInstance;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReadFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileInput;
        private System.Windows.Forms.SaveFileDialog saveFileInput;
        private System.Windows.Forms.Button btnGoLocalSearch;
    }
}

