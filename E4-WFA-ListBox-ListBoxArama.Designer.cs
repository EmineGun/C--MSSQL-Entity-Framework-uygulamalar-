namespace E4_WFA_ListBox
{
    partial class ListBoxArama
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
            this.lblArama = new System.Windows.Forms.Label();
            this.lstArama = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(13, 13);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(45, 13);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "ARAMA";
            // 
            // lstArama
            // 
            this.lstArama.FormattingEnabled = true;
            this.lstArama.Location = new System.Drawing.Point(16, 76);
            this.lstArama.Name = "lstArama";
            this.lstArama.Size = new System.Drawing.Size(120, 160);
            this.lstArama.TabIndex = 1;
            this.lstArama.SelectedIndexChanged += new System.EventHandler(this.llstArama_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(152, 29);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(16, 242);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(120, 23);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "AKTAR";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(12, 29);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(124, 20);
            this.txtArama.TabIndex = 4;
            // 
            // ListBoxArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 285);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lstArama);
            this.Controls.Add(this.lblArama);
            this.Name = "ListBoxArama";
            this.Text = "ListBoxArama";
            this.Load += new System.EventHandler(this.ListBoxArama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.ListBox lstArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.TextBox txtArama;
    }
}