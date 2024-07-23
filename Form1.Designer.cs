namespace _210601046_Şilan_Ekin_veri_finalproje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hastaEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneKaydıOluşturmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaBilgileriniGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.kayıtDefteriniGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaEklemeToolStripMenuItem,
            this.muayeneKaydıOluşturmaToolStripMenuItem,
            this.hastaSToolStripMenuItem,
            this.hastaBilgileriniGüncellemeToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.ilaçToolStripMenuItem,
            this.kayıtDefteriniGörüntüleToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1288, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // hastaEklemeToolStripMenuItem
            // 
            this.hastaEklemeToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.hastaEklemeToolStripMenuItem.Name = "hastaEklemeToolStripMenuItem";
            this.hastaEklemeToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.hastaEklemeToolStripMenuItem.Text = "Hasta Ekleme";
            this.hastaEklemeToolStripMenuItem.Click += new System.EventHandler(this.hastaEklemeToolStripMenuItem_Click);
            // 
            // muayeneKaydıOluşturmaToolStripMenuItem
            // 
            this.muayeneKaydıOluşturmaToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.muayeneKaydıOluşturmaToolStripMenuItem.Name = "muayeneKaydıOluşturmaToolStripMenuItem";
            this.muayeneKaydıOluşturmaToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.muayeneKaydıOluşturmaToolStripMenuItem.Text = "Muayene Kaydı Oluşturma ";
            this.muayeneKaydıOluşturmaToolStripMenuItem.Click += new System.EventHandler(this.muayeKaydıOluşturmaToolStripMenuItem_Click);
            // 
            // hastaSToolStripMenuItem
            // 
            this.hastaSToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.hastaSToolStripMenuItem.Name = "hastaSToolStripMenuItem";
            this.hastaSToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hastaSToolStripMenuItem.Text = "Hasta Sil";
            this.hastaSToolStripMenuItem.Click += new System.EventHandler(this.hastaSToolStripMenuItem_Click);
            // 
            // hastaBilgileriniGüncellemeToolStripMenuItem
            // 
            this.hastaBilgileriniGüncellemeToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.hastaBilgileriniGüncellemeToolStripMenuItem.Name = "hastaBilgileriniGüncellemeToolStripMenuItem";
            this.hastaBilgileriniGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.hastaBilgileriniGüncellemeToolStripMenuItem.Text = "Hasta Bilgilerini Güncelleme";
            this.hastaBilgileriniGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.hastaBilgileriniGüncellemeToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // ilaçToolStripMenuItem
            // 
            this.ilaçToolStripMenuItem.Name = "ilaçToolStripMenuItem";
            this.ilaçToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.ilaçToolStripMenuItem.Text = "İlaç ekle";
            this.ilaçToolStripMenuItem.Click += new System.EventHandler(this.ilaçToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(286, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aile Sağlığı Merkezi Sistemine Hoşgeldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kayıtDefteriniGörüntüleToolStripMenuItem
            // 
            this.kayıtDefteriniGörüntüleToolStripMenuItem.Name = "kayıtDefteriniGörüntüleToolStripMenuItem";
            this.kayıtDefteriniGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.kayıtDefteriniGörüntüleToolStripMenuItem.Text = "Kayıt Defterini Görüntüle";
            this.kayıtDefteriniGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.kayıtDefteriniGörüntüleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1288, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hastaEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneKaydıOluşturmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaBilgileriniGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ilaçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtDefteriniGörüntüleToolStripMenuItem;
    }
}

