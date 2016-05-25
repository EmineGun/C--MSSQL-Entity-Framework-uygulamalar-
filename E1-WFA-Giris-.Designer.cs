namespace E1_WFA_Giris
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
            this.btngiris = new System.Windows.Forms.Button();
            this.altFormAc = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnenter = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnEntr = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDialog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAltMesaj = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(12, 75);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(150, 50);
            this.btngiris.TabIndex = 0;
            this.btngiris.TabStop = false;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // altFormAc
            // 
            this.altFormAc.Location = new System.Drawing.Point(12, 147);
            this.altFormAc.Name = "altFormAc";
            this.altFormAc.Size = new System.Drawing.Size(150, 38);
            this.altFormAc.TabIndex = 1;
            this.altFormAc.TabStop = false;
            this.altFormAc.Text = "ALT FORMU AÇ";
            this.altFormAc.UseVisualStyleBackColor = true;
            this.altFormAc.Click += new System.EventHandler(this.altFormAc_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnenter);
            this.panel.Controls.Add(this.txtSoyad);
            this.panel.Controls.Add(this.lblsoyad);
            this.panel.Controls.Add(this.txtAd);
            this.panel.Controls.Add(this.lblAd);
            this.panel.Location = new System.Drawing.Point(12, 191);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(266, 122);
            this.panel.TabIndex = 2;
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(130, 77);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 23);
            this.btnenter.TabIndex = 2;
            this.btnenter.Text = "Giris Yap";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(103, 55);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(32, 58);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(78, 13);
            this.lblsoyad.TabIndex = 0;
            this.lblsoyad.Text = "kullanıcı soyadı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(103, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(32, 32);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(62, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "kullanıcı adı";
            // 
            // btnEntr
            // 
            this.btnEntr.Location = new System.Drawing.Point(12, 319);
            this.btnEntr.Name = "btnEntr";
            this.btnEntr.Size = new System.Drawing.Size(75, 23);
            this.btnEntr.TabIndex = 0;
            this.btnEntr.TabStop = false;
            this.btnEntr.Text = "enter";
            this.btnEntr.UseVisualStyleBackColor = true;
            this.btnEntr.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(203, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(272, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(168, 147);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(110, 38);
            this.btnDialog.TabIndex = 5;
            this.btnDialog.Text = "DIALOG FORMU";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAltMesaj);
            this.panel1.Location = new System.Drawing.Point(17, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 45);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAltMesaj
            // 
            this.lblAltMesaj.AutoSize = true;
            this.lblAltMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblAltMesaj.Location = new System.Drawing.Point(12, 23);
            this.lblAltMesaj.Name = "lblAltMesaj";
            this.lblAltMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblAltMesaj.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(375, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDialog);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEntr);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.altFormAc);
            this.Controls.Add(this.btngiris);
            this.Name = "Form1";
            this.Text = "Ana Form Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button altFormAc;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnEntr;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAltMesaj;
    }
}

