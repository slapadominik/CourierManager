namespace Kuznia.Views
{
    partial class ClientMenuForm
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
            this.btnCheckStatusForm = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckStatusForm
            // 
            this.btnCheckStatusForm.Location = new System.Drawing.Point(251, 214);
            this.btnCheckStatusForm.Name = "btnCheckStatusForm";
            this.btnCheckStatusForm.Size = new System.Drawing.Size(129, 40);
            this.btnCheckStatusForm.TabIndex = 0;
            this.btnCheckStatusForm.Text = "Sprawdź status paczki";
            this.btnCheckStatusForm.UseVisualStyleBackColor = true;
            this.btnCheckStatusForm.Click += new System.EventHandler(this.btnCheckStatusForm_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(266, 399);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 34);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ClientMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 529);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckStatusForm);
            this.Name = "ClientMenuForm";
            this.Text = "ClientMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckStatusForm;
        private System.Windows.Forms.Button btnReturn;
    }
}