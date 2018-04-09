namespace Kuznia
{
    partial class ManageUsersAsAdminForm
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
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(47, 54);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(98, 37);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Dodaj";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(184, 54);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 37);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(438, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // usersGridView
            // 
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Location = new System.Drawing.Point(86, 133);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.Size = new System.Drawing.Size(428, 386);
            this.usersGridView.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(428, 543);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 36);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Wyloguj";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Status";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManageUsersAsAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.usersGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddClient);
            this.Name = "ManageUsersAsAdminForm";
            this.Text = "AdminManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button button1;
    }
}