namespace Kuznia
{
    partial class MenuForm
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
            this.btnClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCourier = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClient.Location = new System.Drawing.Point(257, 190);
            this.btnClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(87, 32);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Klient";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(266, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witaj!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(247, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kim jesteś?";
            // 
            // btnCourier
            // 
            this.btnCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCourier.Location = new System.Drawing.Point(257, 267);
            this.btnCourier.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourier.Name = "btnCourier";
            this.btnCourier.Size = new System.Drawing.Size(87, 32);
            this.btnCourier.TabIndex = 3;
            this.btnCourier.Text = "Kurier";
            this.btnCourier.UseVisualStyleBackColor = true;
            this.btnCourier.Click += new System.EventHandler(this.btnCourier_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmin.Location = new System.Drawing.Point(247, 344);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(111, 32);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 558);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnCourier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCourier;
        private System.Windows.Forms.Button btnAdmin;
    }
}