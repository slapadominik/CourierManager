namespace Kuznia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdminRole = new System.Windows.Forms.Button();
            this.btnCourierRole = new System.Windows.Forms.Button();
            this.btnClientRole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminRole
            // 
            this.btnAdminRole.Location = new System.Drawing.Point(183, 198);
            this.btnAdminRole.Name = "btnAdminRole";
            this.btnAdminRole.Size = new System.Drawing.Size(105, 32);
            this.btnAdminRole.TabIndex = 0;
            this.btnAdminRole.Text = "Administrator";
            this.btnAdminRole.UseVisualStyleBackColor = true;
            this.btnAdminRole.Click += new System.EventHandler(this.btnAdminRole_Click);
            // 
            // btnCourierRole
            // 
            this.btnCourierRole.Location = new System.Drawing.Point(183, 290);
            this.btnCourierRole.Name = "btnCourierRole";
            this.btnCourierRole.Size = new System.Drawing.Size(105, 32);
            this.btnCourierRole.TabIndex = 1;
            this.btnCourierRole.Text = "Kurier";
            this.btnCourierRole.UseVisualStyleBackColor = true;
            // 
            // btnClientRole
            // 
            this.btnClientRole.Location = new System.Drawing.Point(183, 379);
            this.btnClientRole.Name = "btnClientRole";
            this.btnClientRole.Size = new System.Drawing.Size(105, 32);
            this.btnClientRole.TabIndex = 2;
            this.btnClientRole.Text = "Klient";
            this.btnClientRole.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kim jesteś?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClientRole);
            this.Controls.Add(this.btnCourierRole);
            this.Controls.Add(this.btnAdminRole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminRole;
        private System.Windows.Forms.Button btnCourierRole;
        private System.Windows.Forms.Button btnClientRole;
        private System.Windows.Forms.Label label1;
    }
}

