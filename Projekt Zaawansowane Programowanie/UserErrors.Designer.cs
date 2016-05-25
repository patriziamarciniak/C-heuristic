namespace Projekt_Zaawansowane_Programowanie
{
    partial class UserErrors
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
            this.btnAcceptUserError = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textUserErrors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcceptUserError
            // 
            this.btnAcceptUserError.Location = new System.Drawing.Point(70, 135);
            this.btnAcceptUserError.Name = "btnAcceptUserError";
            this.btnAcceptUserError.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptUserError.TabIndex = 0;
            this.btnAcceptUserError.Text = "Zatwierdź";
            this.btnAcceptUserError.UseVisualStyleBackColor = true;
            this.btnAcceptUserError.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba wprowadzonych błędów: ";
            // 
            // textUserErrors
            // 
            this.textUserErrors.Location = new System.Drawing.Point(70, 76);
            this.textUserErrors.Name = "textUserErrors";
            this.textUserErrors.Size = new System.Drawing.Size(75, 20);
            this.textUserErrors.TabIndex = 2;
            // 
            // UserErrors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 170);
            this.Controls.Add(this.textUserErrors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceptUserError);
            this.Name = "UserErrors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserErrors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceptUserError;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textUserErrors;
    }
}