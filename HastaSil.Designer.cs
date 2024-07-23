namespace _210601046_Şilan_Ekin_veri_finalproje
{
    partial class HastaSil
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
            this.txttcNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnHastaSil = new System.Windows.Forms.Button();
            this.Btniptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silmek istediğiniz hastanın TC kimlik numarasını giriniz:";
            // 
            // txttcNo
            // 
            this.txttcNo.Location = new System.Drawing.Point(509, 25);
            this.txttcNo.Name = "txttcNo";
            this.txttcNo.Size = new System.Drawing.Size(242, 22);
            this.txttcNo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 193);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnHastaSil
            // 
            this.BtnHastaSil.BackColor = System.Drawing.Color.Bisque;
            this.BtnHastaSil.Location = new System.Drawing.Point(591, 94);
            this.BtnHastaSil.Name = "BtnHastaSil";
            this.BtnHastaSil.Size = new System.Drawing.Size(160, 57);
            this.BtnHastaSil.TabIndex = 3;
            this.BtnHastaSil.Text = "Hasta Sil";
            this.BtnHastaSil.UseVisualStyleBackColor = false;
            this.BtnHastaSil.Click += new System.EventHandler(this.BtnHastaSil_Click);
            // 
            // Btniptal
            // 
            this.Btniptal.BackColor = System.Drawing.Color.Bisque;
            this.Btniptal.Location = new System.Drawing.Point(624, 383);
            this.Btniptal.Name = "Btniptal";
            this.Btniptal.Size = new System.Drawing.Size(127, 55);
            this.Btniptal.TabIndex = 4;
            this.Btniptal.Text = "İptal";
            this.Btniptal.UseVisualStyleBackColor = false;
            this.Btniptal.Click += new System.EventHandler(this.Btniptal_Click);
            // 
            // HastaSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btniptal);
            this.Controls.Add(this.BtnHastaSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttcNo);
            this.Controls.Add(this.label1);
            this.Name = "HastaSil";
            this.Text = "HastaSil";
            this.Load += new System.EventHandler(this.HastaSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttcNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnHastaSil;
        private System.Windows.Forms.Button Btniptal;
    }
}