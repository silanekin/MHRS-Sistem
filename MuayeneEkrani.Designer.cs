namespace _210601046_Şilan_Ekin_veri_finalproje
{
    partial class MuayeneEkrani
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
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.txtTani = new System.Windows.Forms.TextBox();
            this.dtGridSikayetKayit = new System.Windows.Forms.DataGridView();
            this.BtnHastalikKayit = new System.Windows.Forms.Button();
            this.BtnReceteYaz = new System.Windows.Forms.Button();
            this.BtnAnaMenu = new System.Windows.Forms.Button();
            this.txtTedavi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtimemuayene = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSikayetKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "TC Kimlik No:";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(111, 12);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(200, 22);
            this.txtTCNo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şikayet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tanı:";
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(121, 190);
            this.txtSikayet.Multiline = true;
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(190, 48);
            this.txtSikayet.TabIndex = 19;
            // 
            // txtTani
            // 
            this.txtTani.Location = new System.Drawing.Point(121, 249);
            this.txtTani.Multiline = true;
            this.txtTani.Name = "txtTani";
            this.txtTani.Size = new System.Drawing.Size(190, 47);
            this.txtTani.TabIndex = 20;
            // 
            // dtGridSikayetKayit
            // 
            this.dtGridSikayetKayit.BackgroundColor = System.Drawing.Color.Bisque;
            this.dtGridSikayetKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSikayetKayit.Location = new System.Drawing.Point(347, 15);
            this.dtGridSikayetKayit.Name = "dtGridSikayetKayit";
            this.dtGridSikayetKayit.RowHeadersWidth = 51;
            this.dtGridSikayetKayit.RowTemplate.Height = 24;
            this.dtGridSikayetKayit.Size = new System.Drawing.Size(804, 325);
            this.dtGridSikayetKayit.TabIndex = 21;
            // 
            // BtnHastalikKayit
            // 
            this.BtnHastalikKayit.BackColor = System.Drawing.Color.Bisque;
            this.BtnHastalikKayit.Location = new System.Drawing.Point(121, 375);
            this.BtnHastalikKayit.Name = "BtnHastalikKayit";
            this.BtnHastalikKayit.Size = new System.Drawing.Size(190, 40);
            this.BtnHastalikKayit.TabIndex = 23;
            this.BtnHastalikKayit.Text = "Bilgileri Kaydet";
            this.BtnHastalikKayit.UseVisualStyleBackColor = false;
            this.BtnHastalikKayit.Click += new System.EventHandler(this.BtnHastalikKayit_Click);
            // 
            // BtnReceteYaz
            // 
            this.BtnReceteYaz.BackColor = System.Drawing.Color.Bisque;
            this.BtnReceteYaz.Location = new System.Drawing.Point(446, 370);
            this.BtnReceteYaz.Name = "BtnReceteYaz";
            this.BtnReceteYaz.Size = new System.Drawing.Size(148, 50);
            this.BtnReceteYaz.TabIndex = 24;
            this.BtnReceteYaz.Text = "Reçete Yaz";
            this.BtnReceteYaz.UseVisualStyleBackColor = false;
            this.BtnReceteYaz.Click += new System.EventHandler(this.BtnReceteYaz_Click);
            // 
            // BtnAnaMenu
            // 
            this.BtnAnaMenu.BackColor = System.Drawing.Color.Bisque;
            this.BtnAnaMenu.Location = new System.Drawing.Point(621, 370);
            this.BtnAnaMenu.Name = "BtnAnaMenu";
            this.BtnAnaMenu.Size = new System.Drawing.Size(125, 50);
            this.BtnAnaMenu.TabIndex = 25;
            this.BtnAnaMenu.Text = "Ana Menüye Dön";
            this.BtnAnaMenu.UseVisualStyleBackColor = false;
            // 
            // txtTedavi
            // 
            this.txtTedavi.Location = new System.Drawing.Point(121, 308);
            this.txtTedavi.Multiline = true;
            this.txtTedavi.Name = "txtTedavi";
            this.txtTedavi.Size = new System.Drawing.Size(190, 47);
            this.txtTedavi.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tedavi:";
            // 
            // dtimemuayene
            // 
            this.dtimemuayene.Location = new System.Drawing.Point(111, 50);
            this.dtimemuayene.Name = "dtimemuayene";
            this.dtimemuayene.Size = new System.Drawing.Size(200, 22);
            this.dtimemuayene.TabIndex = 28;
            // 
            // MuayeneEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.dtimemuayene);
            this.Controls.Add(this.txtTedavi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAnaMenu);
            this.Controls.Add(this.BtnReceteYaz);
            this.Controls.Add(this.BtnHastalikKayit);
            this.Controls.Add(this.dtGridSikayetKayit);
            this.Controls.Add(this.txtTani);
            this.Controls.Add(this.txtSikayet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTCNo);
            this.Name = "MuayeneEkrani";
            this.Text = "MuayeneEkrani";
            this.Load += new System.EventHandler(this.MuayeneEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSikayetKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.TextBox txtTani;
        private System.Windows.Forms.DataGridView dtGridSikayetKayit;
        private System.Windows.Forms.Button BtnHastalikKayit;
        private System.Windows.Forms.Button BtnReceteYaz;
        private System.Windows.Forms.Button BtnAnaMenu;
        private System.Windows.Forms.TextBox txtTedavi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtimemuayene;
    }
}