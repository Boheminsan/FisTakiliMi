namespace Fiş_Takılı
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblKere = new System.Windows.Forms.Label();
            this.lblKacKere = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSuAn = new System.Windows.Forms.Label();
            this.lblTakiliMi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(385, 420);
            this.listBox1.TabIndex = 0;
            // 
            // lblKere
            // 
            this.lblKere.AutoSize = true;
            this.lblKere.Location = new System.Drawing.Point(313, 10);
            this.lblKere.Name = "lblKere";
            this.lblKere.Size = new System.Drawing.Size(42, 13);
            this.lblKere.TabIndex = 1;
            this.lblKere.Text = "Toplam";
            // 
            // lblKacKere
            // 
            this.lblKacKere.AutoSize = true;
            this.lblKacKere.Location = new System.Drawing.Point(361, 10);
            this.lblKacKere.Name = "lblKacKere";
            this.lblKacKere.Size = new System.Drawing.Size(36, 13);
            this.lblKacKere.TabIndex = 2;
            this.lblKacKere.Text = "x kere";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSuAn
            // 
            this.lblSuAn.AutoSize = true;
            this.lblSuAn.Location = new System.Drawing.Point(12, 9);
            this.lblSuAn.Name = "lblSuAn";
            this.lblSuAn.Size = new System.Drawing.Size(86, 13);
            this.lblSuAn.TabIndex = 3;
            this.lblSuAn.Text = "Şu anki Durumu:";
            // 
            // lblTakiliMi
            // 
            this.lblTakiliMi.AutoSize = true;
            this.lblTakiliMi.Location = new System.Drawing.Point(104, 9);
            this.lblTakiliMi.Name = "lblTakiliMi";
            this.lblTakiliMi.Size = new System.Drawing.Size(35, 13);
            this.lblTakiliMi.TabIndex = 4;
            this.lblTakiliMi.Text = "label1";
            this.lblTakiliMi.TextChanged += new System.EventHandler(this.lblTakiliMi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.lblTakiliMi);
            this.Controls.Add(this.lblSuAn);
            this.Controls.Add(this.lblKacKere);
            this.Controls.Add(this.lblKere);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Güç Kesintisi Takip Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblKere;
        private System.Windows.Forms.Label lblKacKere;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSuAn;
        private System.Windows.Forms.Label lblTakiliMi;
    }
}

