namespace _210601046_Şilan_Ekin_veri_finalproje
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtilacTip = new System.Windows.Forms.TextBox();
            this.txtilacAd = new System.Windows.Forms.TextBox();
            this.txtbarkodNo = new System.Windows.Forms.TextBox();
            this.dtGridilac = new System.Windows.Forms.DataGridView();
            this.BtnilacEkle = new System.Windows.Forms.Button();
            this.AnaMenuDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridilac)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlaç Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlaç Tipi:";
            // 
            // txtilacTip
            // 
            this.txtilacTip.Location = new System.Drawing.Point(152, 109);
            this.txtilacTip.Name = "txtilacTip";
            this.txtilacTip.Size = new System.Drawing.Size(100, 22);
            this.txtilacTip.TabIndex = 3;
            // 
            // txtilacAd
            // 
            this.txtilacAd.Location = new System.Drawing.Point(152, 62);
            this.txtilacAd.Name = "txtilacAd";
            this.txtilacAd.Size = new System.Drawing.Size(100, 22);
            this.txtilacAd.TabIndex = 4;
            // 
            // txtbarkodNo
            // 
            this.txtbarkodNo.Location = new System.Drawing.Point(152, 21);
            this.txtbarkodNo.Name = "txtbarkodNo";
            this.txtbarkodNo.Size = new System.Drawing.Size(100, 22);
            this.txtbarkodNo.TabIndex = 5;
            // 
            // dtGridilac
            // 
            this.dtGridilac.BackgroundColor = System.Drawing.Color.Bisque;
            this.dtGridilac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridilac.Location = new System.Drawing.Point(20, 208);
            this.dtGridilac.Name = "dtGridilac";
            this.dtGridilac.RowHeadersWidth = 51;
            this.dtGridilac.RowTemplate.Height = 24;
            this.dtGridilac.Size = new System.Drawing.Size(542, 175);
            this.dtGridilac.TabIndex = 6;
            // 
            // BtnilacEkle
            // 
            this.BtnilacEkle.BackColor = System.Drawing.Color.Bisque;
            this.BtnilacEkle.Location = new System.Drawing.Point(278, 129);
            this.BtnilacEkle.Name = "BtnilacEkle";
            this.BtnilacEkle.Size = new System.Drawing.Size(100, 37);
            this.BtnilacEkle.TabIndex = 7;
            this.BtnilacEkle.Text = "İlaç Ekle";
            this.BtnilacEkle.UseVisualStyleBackColor = false;
            this.BtnilacEkle.Click += new System.EventHandler(this.BtnilacEkle_Click);
            // 
            // AnaMenuDon
            // 
            this.AnaMenuDon.BackColor = System.Drawing.Color.Bisque;
            this.AnaMenuDon.Location = new System.Drawing.Point(416, 129);
            this.AnaMenuDon.Name = "AnaMenuDon";
            this.AnaMenuDon.Size = new System.Drawing.Size(146, 37);
            this.AnaMenuDon.TabIndex = 8;
            this.AnaMenuDon.Text = "Ana Menüye Dön";
            this.AnaMenuDon.UseVisualStyleBackColor = false;
            this.AnaMenuDon.Click += new System.EventHandler(this.AnaMenuDon_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(615, 399);
            this.Controls.Add(this.AnaMenuDon);
            this.Controls.Add(this.BtnilacEkle);
            this.Controls.Add(this.dtGridilac);
            this.Controls.Add(this.txtbarkodNo);
            this.Controls.Add(this.txtilacAd);
            this.Controls.Add(this.txtilacTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "a";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridilac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtilacTip;
        private System.Windows.Forms.TextBox txtilacAd;
        private System.Windows.Forms.TextBox txtbarkodNo;
        private System.Windows.Forms.DataGridView dtGridilac;
        private System.Windows.Forms.Button BtnilacEkle;
        private System.Windows.Forms.Button AnaMenuDon;
    }
}