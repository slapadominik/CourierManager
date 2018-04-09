namespace Kuznia.Views
{
    partial class CourierManagePackageForm
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
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.dataGridViewPackages = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(451, 46);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(101, 37);
            this.btnChangeStatus.TabIndex = 0;
            this.btnChangeStatus.Text = "Zmień status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // dataGridViewPackages
            // 
            this.dataGridViewPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPackages.Location = new System.Drawing.Point(100, 119);
            this.dataGridViewPackages.Name = "dataGridViewPackages";
            this.dataGridViewPackages.Size = new System.Drawing.Size(452, 383);
            this.dataGridViewPackages.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(539, 557);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(80, 35);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(100, 46);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(98, 36);
            this.btnAddPackage.TabIndex = 3;
            this.btnAddPackage.Text = "Dodaj paczkę";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Location = new System.Drawing.Point(221, 46);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(96, 36);
            this.btnDeletePackage.TabIndex = 4;
            this.btnDeletePackage.Text = "Usuń paczkę";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(336, 46);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(91, 36);
            this.btnEditPackage.TabIndex = 5;
            this.btnEditPackage.Text = "Edytuj paczkę";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // CourierManagePackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 604);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dataGridViewPackages);
            this.Controls.Add(this.btnChangeStatus);
            this.Name = "CourierManagePackageForm";
            this.Text = "CourierManagePackageForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.DataGridView dataGridViewPackages;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Button btnEditPackage;
    }
}