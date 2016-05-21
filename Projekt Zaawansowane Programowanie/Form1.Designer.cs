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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonGenerateErrors = new System.Windows.Forms.Button();
            this.buttonGenerateInstance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSamples = new System.Windows.Forms.Label();
            this.comboBoxErrors = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaces = new System.Windows.Forms.ComboBox();
            this.comboBoxSamples = new System.Windows.Forms.ComboBox();
            this.console = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewInput);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 306);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Location = new System.Drawing.Point(0, 2);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.Size = new System.Drawing.Size(659, 301);
            this.dataGridViewInput.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.buttonGenerateErrors);
            this.panel2.Controls.Add(this.buttonGenerateInstance);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelSamples);
            this.panel2.Controls.Add(this.comboBoxErrors);
            this.panel2.Controls.Add(this.comboBoxPlaces);
            this.panel2.Controls.Add(this.comboBoxSamples);
            this.panel2.Location = new System.Drawing.Point(1, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 211);
            this.panel2.TabIndex = 1;
            // 
            // buttonGenerateErrors
            // 
            this.buttonGenerateErrors.AutoSize = true;
            this.buttonGenerateErrors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGenerateErrors.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGenerateErrors.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.buttonGenerateErrors.FlatAppearance.BorderSize = 2;
            this.buttonGenerateErrors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonGenerateErrors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonGenerateErrors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGenerateErrors.Location = new System.Drawing.Point(393, 126);
            this.buttonGenerateErrors.Name = "buttonGenerateErrors";
            this.buttonGenerateErrors.Size = new System.Drawing.Size(108, 28);
            this.buttonGenerateErrors.TabIndex = 7;
            this.buttonGenerateErrors.Text = "Generuj błędy";
            this.buttonGenerateErrors.UseVisualStyleBackColor = false;
            this.buttonGenerateErrors.Click += new System.EventHandler(this.buttonGenerateErrors_Click);
            // 
            // buttonGenerateInstance
            // 
            this.buttonGenerateInstance.AutoSize = true;
            this.buttonGenerateInstance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGenerateInstance.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGenerateInstance.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.buttonGenerateInstance.FlatAppearance.BorderSize = 2;
            this.buttonGenerateInstance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonGenerateInstance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonGenerateInstance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGenerateInstance.Location = new System.Drawing.Point(121, 126);
            this.buttonGenerateInstance.Name = "buttonGenerateInstance";
            this.buttonGenerateInstance.Size = new System.Drawing.Size(132, 28);
            this.buttonGenerateInstance.TabIndex = 6;
            this.buttonGenerateInstance.Text = "Generuj instancję";
            this.buttonGenerateInstance.UseVisualStyleBackColor = false;
            this.buttonGenerateInstance.Click += new System.EventHandler(this.buttonGenerateInstance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liczba miejsc mapowania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(353, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liczba błędów";
            // 
            // labelSamples
            // 
            this.labelSamples.AutoSize = true;
            this.labelSamples.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelSamples.Location = new System.Drawing.Point(81, 34);
            this.labelSamples.Name = "labelSamples";
            this.labelSamples.Size = new System.Drawing.Size(136, 18);
            this.labelSamples.TabIndex = 3;
            this.labelSamples.Text = "Liczba sekwencji";
            // 
            // comboBoxErrors
            // 
            this.comboBoxErrors.FormattingEnabled = true;
            this.comboBoxErrors.Location = new System.Drawing.Point(490, 71);
            this.comboBoxErrors.Name = "comboBoxErrors";
            this.comboBoxErrors.Size = new System.Drawing.Size(62, 21);
            this.comboBoxErrors.TabIndex = 2;
            // 
            // comboBoxPlaces
            // 
            this.comboBoxPlaces.FormattingEnabled = true;
            this.comboBoxPlaces.Location = new System.Drawing.Point(241, 68);
            this.comboBoxPlaces.Name = "comboBoxPlaces";
            this.comboBoxPlaces.Size = new System.Drawing.Size(62, 21);
            this.comboBoxPlaces.TabIndex = 1;
            // 
            // comboBoxSamples
            // 
            this.comboBoxSamples.FormattingEnabled = true;
            this.comboBoxSamples.Location = new System.Drawing.Point(241, 31);
            this.comboBoxSamples.Name = "comboBoxSamples";
            this.comboBoxSamples.Size = new System.Drawing.Size(62, 21);
            this.comboBoxSamples.TabIndex = 0;
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(1, 521);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(659, 46);
            this.console.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 566);
            this.Controls.Add(this.console);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaawansowane Programowanie";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox console;
    }
}

