namespace SigarasızHayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Giris = new System.Windows.Forms.Button();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_kadiniz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbar_sigara = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_sigara)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Giris.Location = new System.Drawing.Point(322, 464);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(176, 45);
            this.btn_Giris.TabIndex = 1;
            this.btn_Giris.Text = "GİRİŞ";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_kayit.Location = new System.Drawing.Point(322, 515);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(176, 47);
            this.btn_kayit.TabIndex = 2;
            this.btn_kayit.Text = "KAYIT";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // txt_kadiniz
            // 
            this.txt_kadiniz.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.txt_kadiniz.Location = new System.Drawing.Point(321, 398);
            this.txt_kadiniz.Name = "txt_kadiniz";
            this.txt_kadiniz.Size = new System.Drawing.Size(176, 26);
            this.txt_kadiniz.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(318, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "KULLANICI ADINIZ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(215, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "BUGÜN NE KADAR SİGARA İÇMEK İSTEDİNİZ";
            // 
            // tbar_sigara
            // 
            this.tbar_sigara.BackColor = System.Drawing.Color.Black;
            this.tbar_sigara.Location = new System.Drawing.Point(218, 609);
            this.tbar_sigara.Maximum = 5;
            this.tbar_sigara.Name = "tbar_sigara";
            this.tbar_sigara.Size = new System.Drawing.Size(388, 45);
            this.tbar_sigara.TabIndex = 19;
            this.tbar_sigara.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar_sigara.Scroll += new System.EventHandler(this.tbar_sigara_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbar_sigara);
            this.Controls.Add(this.txt_kadiniz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.btn_Giris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SigarasızHayat";
            ((System.ComponentModel.ISupportInitialize)(this.tbar_sigara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox txt_kadiniz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbar_sigara;
    }
}

