namespace F1_CheckedListBox
{
    partial class Form1
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
            this.chListBox = new System.Windows.Forms.CheckedListBox();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnTumunuSec = new System.Windows.Forms.Button();
            this.btnSecimiKaldir = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chListBox
            // 
            this.chListBox.CheckOnClick = true;
            this.chListBox.FormattingEnabled = true;
            this.chListBox.Location = new System.Drawing.Point(13, 18);
            this.chListBox.Name = "chListBox";
            this.chListBox.Size = new System.Drawing.Size(120, 214);
            this.chListBox.TabIndex = 0;
            this.chListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chListBox_ItemCheck);
            this.chListBox.SelectedIndexChanged += new System.EventHandler(this.chListBox_SelectedIndexChanged);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(152, 18);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(150, 212);
            this.lstListe.TabIndex = 1;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(20, 246);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(35, 13);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "label1";
            // 
            // btnTumunuSec
            // 
            this.btnTumunuSec.Location = new System.Drawing.Point(23, 277);
            this.btnTumunuSec.Name = "btnTumunuSec";
            this.btnTumunuSec.Size = new System.Drawing.Size(75, 23);
            this.btnTumunuSec.TabIndex = 3;
            this.btnTumunuSec.Text = "Tümünü seç";
            this.btnTumunuSec.UseVisualStyleBackColor = true;
            this.btnTumunuSec.Click += new System.EventHandler(this.btnTumunuSec_Click);
            // 
            // btnSecimiKaldir
            // 
            this.btnSecimiKaldir.Location = new System.Drawing.Point(104, 277);
            this.btnSecimiKaldir.Name = "btnSecimiKaldir";
            this.btnSecimiKaldir.Size = new System.Drawing.Size(75, 23);
            this.btnSecimiKaldir.TabIndex = 3;
            this.btnSecimiKaldir.Text = "Seçimi Kaldır";
            this.btnSecimiKaldir.UseVisualStyleBackColor = true;
            this.btnSecimiKaldir.Click += new System.EventHandler(this.btnSecimiKaldir_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(185, 277);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(117, 23);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "Seçili Olanları Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 405);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnSecimiKaldir);
            this.Controls.Add(this.btnTumunuSec);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.chListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chListBox;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnTumunuSec;
        private System.Windows.Forms.Button btnSecimiKaldir;
        private System.Windows.Forms.Button btnAktar;
    }
}

