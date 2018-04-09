using System;
using System.Windows.Forms;
using Kuznia.Helpers;
using Kuznia.Models.Enums;

namespace Kuznia.Views
{
    partial class AddEditPackageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPackageId = new System.Windows.Forms.TextBox();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer paczki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status paczki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data dostarczenia";
            // 
            // txtBoxPackageId
            // 
            this.txtBoxPackageId.Location = new System.Drawing.Point(153, 141);
            this.txtBoxPackageId.Name = "txtBoxPackageId";
            this.txtBoxPackageId.Size = new System.Drawing.Size(110, 20);
            this.txtBoxPackageId.TabIndex = 3;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(273, 332);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(75, 23);
            this.btnAddPackage.TabIndex = 6;
            this.btnAddPackage.Text = "Dodaj";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(273, 380);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(75, 23);
            this.btnEditPackage.TabIndex = 7;
            this.btnEditPackage.Text = "Edytuj";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(153, 255);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(153, 206);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 10;
            // 
            // AddEditPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 448);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.txtBoxPackageId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditPackageForm";
            this.Text = "AddEditPackageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPackageId;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnEditPackage;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxStatus;
    }
}