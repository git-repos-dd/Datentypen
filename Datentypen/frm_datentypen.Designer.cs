
namespace Datentypen
{
    partial class frm_datentypen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_datentypen_anzeigen = new System.Windows.Forms.Button();
            this.lbl_datentypen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_datentypen_anzeigen
            // 
            this.btn_datentypen_anzeigen.Location = new System.Drawing.Point(12, 12);
            this.btn_datentypen_anzeigen.Name = "btn_datentypen_anzeigen";
            this.btn_datentypen_anzeigen.Size = new System.Drawing.Size(138, 23);
            this.btn_datentypen_anzeigen.TabIndex = 0;
            this.btn_datentypen_anzeigen.Text = "Datentypen anzeigen";
            this.btn_datentypen_anzeigen.UseVisualStyleBackColor = true;
            this.btn_datentypen_anzeigen.Click += new System.EventHandler(this.btn_datentypen_anzeigen_Click);
            // 
            // lbl_datentypen
            // 
            this.lbl_datentypen.AutoSize = true;
            this.lbl_datentypen.Location = new System.Drawing.Point(13, 42);
            this.lbl_datentypen.Name = "lbl_datentypen";
            this.lbl_datentypen.Size = new System.Drawing.Size(68, 13);
            this.lbl_datentypen.TabIndex = 1;
            this.lbl_datentypen.Text = "... Platzhalter";
            // 
            // frm_datentypen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_datentypen);
            this.Controls.Add(this.btn_datentypen_anzeigen);
            this.Name = "frm_datentypen";
            this.Text = "Datentypen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_datentypen_anzeigen;
        private System.Windows.Forms.Label lbl_datentypen;
    }
}

