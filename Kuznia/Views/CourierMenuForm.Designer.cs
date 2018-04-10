namespace Kuznia
{
    partial class CourierMenuForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnOpenCourierForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(272, 506);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 52);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnOpenCourierForm
            // 
            this.btnOpenCourierForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCourierForm.Location = new System.Drawing.Point(235, 299);
            this.btnOpenCourierForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenCourierForm.Name = "btnOpenCourierForm";
            this.btnOpenCourierForm.Size = new System.Drawing.Size(233, 58);
            this.btnOpenCourierForm.TabIndex = 1;
            this.btnOpenCourierForm.Text = "Zarządzaj paczkami";
            this.btnOpenCourierForm.UseVisualStyleBackColor = true;
            this.btnOpenCourierForm.Click += new System.EventHandler(this.btnOpenCourierForm_Click);
            // 
            // CourierMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(693, 663);
            this.Controls.Add(this.btnOpenCourierForm);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CourierMenuForm";
            this.Text = "DPD - firma kurierska";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnOpenCourierForm;
    }
}