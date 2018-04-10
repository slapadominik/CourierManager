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
            this.btnCheckStatusForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckStatusForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheckStatusForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckStatusForm.Location = new System.Drawing.Point(259, 218);
            this.btnCheckStatusForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckStatusForm.Name = "btnCheckStatusForm";
            this.btnCheckStatusForm.Size = new System.Drawing.Size(229, 66);
            this.btnCheckStatusForm.TabIndex = 0;
            this.btnCheckStatusForm.Text = "Sprawdź status paczki";
            this.btnCheckStatusForm.UseVisualStyleBackColor = true;
            this.btnCheckStatusForm.Click += new System.EventHandler(this.btnCheckStatusForm_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Location = new System.Drawing.Point(293, 405);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(153, 52);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ClientMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(761, 593);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckStatusForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientMenuForm";
            this.Text = "DPD - firma kurierska";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckStatusForm;
        private System.Windows.Forms.Button btnReturn;
    }
}