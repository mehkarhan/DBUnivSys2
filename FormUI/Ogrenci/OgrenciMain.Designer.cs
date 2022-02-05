
namespace FormUI.Ogrenci
{
    partial class OgrenciMain
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
            this.btnKisisel = new System.Windows.Forms.Button();
            this.picOmu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblADSoyad = new System.Windows.Forms.Label();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnDers = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOmu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKisisel
            // 
            this.btnKisisel.FlatAppearance.BorderSize = 0;
            this.btnKisisel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisisel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKisisel.ForeColor = System.Drawing.Color.White;
            this.btnKisisel.Location = new System.Drawing.Point(1, 131);
            this.btnKisisel.Name = "btnKisisel";
            this.btnKisisel.Size = new System.Drawing.Size(200, 57);
            this.btnKisisel.TabIndex = 0;
            this.btnKisisel.Text = "Kişisel Bilgiler";
            this.btnKisisel.UseVisualStyleBackColor = true;
            this.btnKisisel.Click += new System.EventHandler(this.btnKisisel_Click);
            // 
            // picOmu
            // 
            this.picOmu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picOmu.BackColor = System.Drawing.Color.Transparent;
            this.picOmu.Image = global::FormUI.Properties.Resources.Omu_logo;
            this.picOmu.Location = new System.Drawing.Point(26, 512);
            this.picOmu.Name = "picOmu";
            this.picOmu.Size = new System.Drawing.Size(140, 131);
            this.picOmu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOmu.TabIndex = 0;
            this.picOmu.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 1319);
            this.label1.MaximumSize = new System.Drawing.Size(153, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mehmet KARAHAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.lblADSoyad);
            this.panel1.Controls.Add(this.btnNot);
            this.panel1.Controls.Add(this.btnDers);
            this.panel1.Controls.Add(this.btnKisisel);
            this.panel1.Controls.Add(this.btnOturumKapat);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.picOmu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 750);
            this.panel1.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(58, 696);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(56, 18);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Öğrenci";
            // 
            // lblADSoyad
            // 
            this.lblADSoyad.AutoSize = true;
            this.lblADSoyad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblADSoyad.Location = new System.Drawing.Point(12, 656);
            this.lblADSoyad.Name = "lblADSoyad";
            this.lblADSoyad.Size = new System.Drawing.Size(16, 24);
            this.lblADSoyad.TabIndex = 5;
            this.lblADSoyad.Text = "-";
            this.lblADSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNot
            // 
            this.btnNot.FlatAppearance.BorderSize = 0;
            this.btnNot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNot.ForeColor = System.Drawing.Color.White;
            this.btnNot.Location = new System.Drawing.Point(0, 286);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(200, 57);
            this.btnNot.TabIndex = 4;
            this.btnNot.Text = "Not Görüntüle";
            this.btnNot.UseVisualStyleBackColor = true;
            // 
            // btnDers
            // 
            this.btnDers.FlatAppearance.BorderSize = 0;
            this.btnDers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDers.ForeColor = System.Drawing.Color.White;
            this.btnDers.Location = new System.Drawing.Point(0, 204);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(200, 57);
            this.btnDers.TabIndex = 0;
            this.btnDers.Text = "Ders İşlemleri";
            this.btnDers.UseVisualStyleBackColor = true;
            this.btnDers.Click += new System.EventHandler(this.btnDers_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 57);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 1369);
            this.label2.MaximumSize = new System.Drawing.Size(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 110);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Paneli";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainpanel.Location = new System.Drawing.Point(206, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(994, 750);
            this.mainpanel.TabIndex = 8;
            // 
            // btnOturumKapat
            // 
            this.btnOturumKapat.FlatAppearance.BorderSize = 0;
            this.btnOturumKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOturumKapat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOturumKapat.ForeColor = System.Drawing.Color.White;
            this.btnOturumKapat.Location = new System.Drawing.Point(0, 386);
            this.btnOturumKapat.Name = "btnOturumKapat";
            this.btnOturumKapat.Size = new System.Drawing.Size(200, 57);
            this.btnOturumKapat.TabIndex = 0;
            this.btnOturumKapat.Text = "Oturumu Kapat";
            this.btnOturumKapat.UseVisualStyleBackColor = true;
            this.btnOturumKapat.Click += new System.EventHandler(this.btnOturumKapat_Click);
            // 
            // OgrenciMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciMain";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.OgrenciMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOmu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKisisel;
        private System.Windows.Forms.PictureBox picOmu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnDers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label lblADSoyad;
        private System.Windows.Forms.Button btnOturumKapat;
    }
}