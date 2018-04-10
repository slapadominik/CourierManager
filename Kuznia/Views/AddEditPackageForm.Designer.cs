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
            this.label1.Location = new System.Drawing.Point(57, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer paczki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status paczki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data dostarczenia";
            // 
            // txtBoxPackageId
            // 
            this.txtBoxPackageId.Location = new System.Drawing.Point(256, 239);
            this.txtBoxPackageId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBoxPackageId.Name = "txtBoxPackageId";
            this.txtBoxPackageId.Size = new System.Drawing.Size(181, 30);
            this.txtBoxPackageId.TabIndex = 3;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPackage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPackage.Location = new System.Drawing.Point(456, 562);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(124, 39);
            this.btnAddPackage.TabIndex = 6;
            this.btnAddPackage.Text = "Dodaj";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPackage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditPackage.Location = new System.Drawing.Point(456, 644);
            this.btnEditPackage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(124, 39);
            this.btnEditPackage.TabIndex = 7;
            this.btnEditPackage.Text = "Edytuj";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(256, 440);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(331, 30);
            this.dateTimePicker.TabIndex = 9;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(256, 349);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 33);
            this.comboBoxStatus.TabIndex = 10;
            // 
            // AddEditPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(643, 758);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.txtBoxPackageId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "AddEditPackageForm";
            this.Text = "DPD - firma kurierska";
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