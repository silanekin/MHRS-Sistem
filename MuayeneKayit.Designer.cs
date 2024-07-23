namespace _210601046_Şilan_Ekin_veri_finalproje
{
    partial class MuayeneKayit
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
            this.dtimeMuayeneTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcNO = new System.Windows.Forms.TextBox();
            this.BtnMuayeneKayit = new System.Windows.Forms.Button();
            this.dtGridMuayeneKayit = new System.Windows.Forms.DataGridView();
            this.BtnMuayeneEkrani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMuayeneKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // dtimeMuayeneTarih
            // 
            this.dtimeMuayeneTarih.Location = new System.Drawing.Point(113, 24);
            this.dtimeMuayeneTarih.Name = "dtimeMuayeneTarih";
            this.dtimeMuayeneTarih.Size = new System.Drawing.Size(200, 22);
            this.dtimeMuayeneTarih.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "TC Kimlik No:";
            // 
            // txtTcNO
            // 
            this.txtTcNO.Location = new System.Drawing.Point(113, 60);
            this.txtTcNO.Name = "txtTcNO";
            this.txtTcNO.Size = new System.Drawing.Size(200, 22);
            this.txtTcNO.TabIndex = 12;
            // 
            // BtnMuayeneKayit
            // 
            this.BtnMuayeneKayit.BackColor = System.Drawing.Color.Bisque;
            this.BtnMuayeneKayit.Location = new System.Drawing.Point(51, 108);
            this.BtnMuayeneKayit.Name = "BtnMuayeneKayit";
            this.BtnMuayeneKayit.Size = new System.Drawing.Size(209, 66);
            this.BtnMuayeneKayit.TabIndex = 14;
            this.BtnMuayeneKayit.Text = "Muayene Kaydı Oluştur";
            this.BtnMuayeneKayit.UseVisualStyleBackColor = false;
            this.BtnMuayeneKayit.Click += new System.EventHandler(this.BtnMuayeneKayit_Click);
            // 
            // dtGridMuayeneKayit
            // 
            this.dtGridMuayeneKayit.BackgroundColor = System.Drawing.Color.Bisque;
            this.dtGridMuayeneKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridMuayeneKayit.Location = new System.Drawing.Point(322, 12);
            this.dtGridMuayeneKayit.Name = "dtGridMuayeneKayit";
            this.dtGridMuayeneKayit.RowHeadersWidth = 51;
            this.dtGridMuayeneKayit.RowTemplate.Height = 24;
            this.dtGridMuayeneKayit.Size = new System.Drawing.Size(1237, 273);
            this.dtGridMuayeneKayit.TabIndex = 15;
            // 
            // BtnMuayeneEkrani
            // 
            this.BtnMuayeneEkrani.BackColor = System.Drawing.Color.Bisque;
            this.BtnMuayeneEkrani.Location = new System.Drawing.Point(51, 193);
            this.BtnMuayeneEkrani.Name = "BtnMuayeneEkrani";
            this.BtnMuayeneEkrani.Size = new System.Drawing.Size(209, 66);
            this.BtnMuayeneEkrani.TabIndex = 16;
            this.BtnMuayeneEkrani.Text = "Muayene Ekranına Git";
            this.BtnMuayeneEkrani.UseVisualStyleBackColor = false;
            this.BtnMuayeneEkrani.Click += new System.EventHandler(this.BtnMuayeneEkrani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Muayene Tarihi";
            // 
            // MuayeneKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1571, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnMuayeneEkrani);
            this.Controls.Add(this.dtGridMuayeneKayit);
            this.Controls.Add(this.BtnMuayeneKayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTcNO);
            this.Controls.Add(this.dtimeMuayeneTarih);
            this.Name = "MuayeneKayit";
            this.Text = "MuayeneKayit";
            this.Load += new System.EventHandler(this.MuayeneKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMuayeneKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtimeMuayeneTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTcNO;
        private System.Windows.Forms.Button BtnMuayeneKayit;
        private System.Windows.Forms.DataGridView dtGridMuayeneKayit;
        private System.Windows.Forms.Button BtnMuayeneEkrani;
        private System.Windows.Forms.Label label2;
    }
}