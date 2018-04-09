namespace Kuznia.Views
{
    partial class ClientPackageStatusForm
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
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.textBoxPackageId = new System.Windows.Forms.TextBox();
            this.dataGridViewPackages = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(382, 113);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(96, 31);
            this.btnCheckStatus.TabIndex = 0;
            this.btnCheckStatus.Text = "Sprawdź";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // textBoxPackageId
            // 
            this.textBoxPackageId.Location = new System.Drawing.Point(223, 119);
            this.textBoxPackageId.Name = "textBoxPackageId";
            this.textBoxPackageId.Size = new System.Drawing.Size(122, 20);
            this.textBoxPackageId.TabIndex = 1;
            // 
            // dataGridViewPackages
            // 
            this.dataGridViewPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPackages.Location = new System.Drawing.Point(111, 188);
            this.dataGridViewPackages.Name = "dataGridViewPackages";
            this.dataGridViewPackages.Size = new System.Drawing.Size(367, 127);
            this.dataGridViewPackages.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numer paczki";
            // 
            // ClientPackageStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPackages);
            this.Controls.Add(this.textBoxPackageId);
            this.Controls.Add(this.btnCheckStatus);
            this.Name = "ClientPackageStatusForm";
            this.Text = "ClientCheckPackageStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.TextBox textBoxPackageId;
        private System.Windows.Forms.DataGridView dataGridViewPackages;
        private System.Windows.Forms.Label label1;
    }
}