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
            this.btnReturn = new System.Windows.Forms.Button();
            this.labelNoPackage = new System.Windows.Forms.Label();
            this.labelErrorId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckStatus.Location = new System.Drawing.Point(573, 174);
            this.btnCheckStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(144, 48);
            this.btnCheckStatus.TabIndex = 0;
            this.btnCheckStatus.Text = "Sprawdź";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // textBoxPackageId
            // 
            this.textBoxPackageId.Location = new System.Drawing.Point(334, 183);
            this.textBoxPackageId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPackageId.Name = "textBoxPackageId";
            this.textBoxPackageId.Size = new System.Drawing.Size(181, 30);
            this.textBoxPackageId.TabIndex = 1;
            // 
            // dataGridViewPackages
            // 
            this.dataGridViewPackages.AllowUserToAddRows = false;
            this.dataGridViewPackages.AllowUserToDeleteRows = false;
            this.dataGridViewPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPackages.Location = new System.Drawing.Point(167, 319);
            this.dataGridViewPackages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPackages.Name = "dataGridViewPackages";
            this.dataGridViewPackages.Size = new System.Drawing.Size(550, 195);
            this.dataGridViewPackages.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numer paczki";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(774, 589);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 48);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // labelNoPackage
            // 
            this.labelNoPackage.AutoSize = true;
            this.labelNoPackage.ForeColor = System.Drawing.Color.Red;
            this.labelNoPackage.Location = new System.Drawing.Point(330, 266);
            this.labelNoPackage.Name = "labelNoPackage";
            this.labelNoPackage.Size = new System.Drawing.Size(53, 25);
            this.labelNoPackage.TabIndex = 5;
            this.labelNoPackage.Text = "label";
            // 
            // labelErrorId
            // 
            this.labelErrorId.AutoSize = true;
            this.labelErrorId.ForeColor = System.Drawing.Color.Red;
            this.labelErrorId.Location = new System.Drawing.Point(330, 228);
            this.labelErrorId.Name = "labelErrorId";
            this.labelErrorId.Size = new System.Drawing.Size(64, 25);
            this.labelErrorId.TabIndex = 6;
            this.labelErrorId.Text = "label2";
            // 
            // ClientPackageStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(908, 649);
            this.Controls.Add(this.labelErrorId);
            this.Controls.Add(this.labelNoPackage);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPackages);
            this.Controls.Add(this.textBoxPackageId);
            this.Controls.Add(this.btnCheckStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientPackageStatusForm";
            this.Text = "DPD - firma kurierska";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.TextBox textBoxPackageId;
        private System.Windows.Forms.DataGridView dataGridViewPackages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label labelNoPackage;
        private System.Windows.Forms.Label labelErrorId;
    }
}