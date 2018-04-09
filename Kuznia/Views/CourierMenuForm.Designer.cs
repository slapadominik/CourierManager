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
            this.btnReturn.Location = new System.Drawing.Point(181, 352);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 34);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnOpenCourierForm
            // 
            this.btnOpenCourierForm.Location = new System.Drawing.Point(163, 169);
            this.btnOpenCourierForm.Name = "btnOpenCourierForm";
            this.btnOpenCourierForm.Size = new System.Drawing.Size(142, 34);
            this.btnOpenCourierForm.TabIndex = 1;
            this.btnOpenCourierForm.Text = "Zarządzaj paczkami";
            this.btnOpenCourierForm.UseVisualStyleBackColor = true;
            this.btnOpenCourierForm.Click += new System.EventHandler(this.btnOpenCourierForm_Click);
            // 
            // CourierMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 468);
            this.Controls.Add(this.btnOpenCourierForm);
            this.Controls.Add(this.btnReturn);
            this.Name = "CourierMenuForm";
            this.Text = "CourierMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnOpenCourierForm;
    }
}