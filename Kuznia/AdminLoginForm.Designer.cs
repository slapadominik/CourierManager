﻿namespace Kuznia
{
    partial class AdminLoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(236, 446);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(224, 337);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(148, 26);
            this.txtboxPassword.TabIndex = 1;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(224, 257);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(148, 26);
            this.txtboxUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(140, 391);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(51, 20);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "label3";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(449, 658);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 44);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 758);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnReturn;
    }
}