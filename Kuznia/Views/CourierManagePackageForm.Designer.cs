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
            this.dataGridViewPackages = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPackages
            // 
            this.dataGridViewPackages.AllowUserToAddRows = false;
            this.dataGridViewPackages.AllowUserToDeleteRows = false;
            this.dataGridViewPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPackages.Location = new System.Drawing.Point(123, 173);
            this.dataGridViewPackages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPackages.Name = "dataGridViewPackages";
            this.dataGridViewPackages.Size = new System.Drawing.Size(567, 516);
            this.dataGridViewPackages.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(570, 712);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 54);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPackage.Location = new System.Drawing.Point(123, 71);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(166, 65);
            this.btnAddPackage.TabIndex = 3;
            this.btnAddPackage.Text = "Dodaj paczkę";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePackage.Location = new System.Drawing.Point(324, 71);
            this.btnDeletePackage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(160, 65);
            this.btnDeletePackage.TabIndex = 4;
            this.btnDeletePackage.Text = "Usuń paczkę";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPackage.Location = new System.Drawing.Point(528, 71);
            this.btnEditPackage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(162, 65);
            this.btnEditPackage.TabIndex = 5;
            this.btnEditPackage.Text = "Edytuj paczkę";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // CourierManagePackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(828, 780);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dataGridViewPackages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CourierManagePackageForm";
            this.Text = "DPD - firma kurierska";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPackages;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Button btnEditPackage;
    }
}