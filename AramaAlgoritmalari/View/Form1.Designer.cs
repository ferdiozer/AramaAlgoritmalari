namespace AramaAlgoritma
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
            this.lbl_Zaman = new System.Windows.Forms.Label();
            this.lbl_Karsilastirma = new System.Windows.Forms.Label();
            this.lbl_Index = new System.Windows.Forms.Label();
            this.richText_Metin = new System.Windows.Forms.RichTextBox();
            this.richText_AramaMetin = new System.Windows.Forms.RichTextBox();
            this.lbl_metin = new System.Windows.Forms.Label();
            this.lbl_arama_metin = new System.Windows.Forms.Label();
            this.richText_txtYolu = new System.Windows.Forms.RichTextBox();
            this.lbl_txtYolu = new System.Windows.Forms.Label();
            this.btn_baslat_txtYolu = new System.Windows.Forms.Button();
            this.btn_Sec = new System.Windows.Forms.Button();
            this.openFile_txt = new System.Windows.Forms.OpenFileDialog();
            this.richText_Index = new System.Windows.Forms.RichTextBox();
            this.richText_OlusanDiziler = new System.Windows.Forms.RichTextBox();
            this.lbl_Diziler = new System.Windows.Forms.Label();
            this.lbl_AvgTickMs = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.combobox_algoritma = new System.Windows.Forms.ComboBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btn_animasyon = new System.Windows.Forms.Button();
            this.lbl_AnimasyonAyar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Zaman
            // 
            this.lbl_Zaman.AutoSize = true;
            this.lbl_Zaman.ForeColor = System.Drawing.Color.Green;
            this.lbl_Zaman.Location = new System.Drawing.Point(284, 9);
            this.lbl_Zaman.Name = "lbl_Zaman";
            this.lbl_Zaman.Size = new System.Drawing.Size(80, 17);
            this.lbl_Zaman.TabIndex = 1;
            this.lbl_Zaman.Text = "dummyText";
            // 
            // lbl_Karsilastirma
            // 
            this.lbl_Karsilastirma.AutoSize = true;
            this.lbl_Karsilastirma.Location = new System.Drawing.Point(284, 39);
            this.lbl_Karsilastirma.Name = "lbl_Karsilastirma";
            this.lbl_Karsilastirma.Size = new System.Drawing.Size(80, 17);
            this.lbl_Karsilastirma.TabIndex = 1;
            this.lbl_Karsilastirma.Text = "dummyText";
            // 
            // lbl_Index
            // 
            this.lbl_Index.AutoSize = true;
            this.lbl_Index.Location = new System.Drawing.Point(9, 561);
            this.lbl_Index.Name = "lbl_Index";
            this.lbl_Index.Size = new System.Drawing.Size(114, 17);
            this.lbl_Index.TabIndex = 1;
            this.lbl_Index.Text = "Index Numaraları";
            // 
            // richText_Metin
            // 
            this.richText_Metin.Location = new System.Drawing.Point(12, 242);
            this.richText_Metin.Name = "richText_Metin";
            this.richText_Metin.Size = new System.Drawing.Size(302, 316);
            this.richText_Metin.TabIndex = 2;
            this.richText_Metin.Text = "";
            this.richText_Metin.TextChanged += new System.EventHandler(this.richText_Metin_TextChanged);
            this.richText_Metin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richText_KeyDown);
            // 
            // richText_AramaMetin
            // 
            this.richText_AramaMetin.Location = new System.Drawing.Point(12, 169);
            this.richText_AramaMetin.Name = "richText_AramaMetin";
            this.richText_AramaMetin.Size = new System.Drawing.Size(302, 50);
            this.richText_AramaMetin.TabIndex = 2;
            this.richText_AramaMetin.Text = "";
            this.richText_AramaMetin.TextChanged += new System.EventHandler(this.richText_AramaMetin_TextChanged);
            this.richText_AramaMetin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richText_KeyDown);
            // 
            // lbl_metin
            // 
            this.lbl_metin.AutoSize = true;
            this.lbl_metin.Location = new System.Drawing.Point(12, 222);
            this.lbl_metin.Name = "lbl_metin";
            this.lbl_metin.Size = new System.Drawing.Size(42, 17);
            this.lbl_metin.TabIndex = 1;
            this.lbl_metin.Text = "Metin";
            // 
            // lbl_arama_metin
            // 
            this.lbl_arama_metin.AutoSize = true;
            this.lbl_arama_metin.Location = new System.Drawing.Point(12, 149);
            this.lbl_arama_metin.Name = "lbl_arama_metin";
            this.lbl_arama_metin.Size = new System.Drawing.Size(114, 17);
            this.lbl_arama_metin.TabIndex = 1;
            this.lbl_arama_metin.Text = "Aranacak Kelime";
            // 
            // richText_txtYolu
            // 
            this.richText_txtYolu.Location = new System.Drawing.Point(14, 88);
            this.richText_txtYolu.Name = "richText_txtYolu";
            this.richText_txtYolu.Size = new System.Drawing.Size(239, 58);
            this.richText_txtYolu.TabIndex = 2;
            this.richText_txtYolu.Text = "";
            this.richText_txtYolu.TextChanged += new System.EventHandler(this.richText_txtYolu_TextChanged);
            // 
            // lbl_txtYolu
            // 
            this.lbl_txtYolu.AutoSize = true;
            this.lbl_txtYolu.Location = new System.Drawing.Point(12, 66);
            this.lbl_txtYolu.Name = "lbl_txtYolu";
            this.lbl_txtYolu.Size = new System.Drawing.Size(54, 17);
            this.lbl_txtYolu.TabIndex = 1;
            this.lbl_txtYolu.Text = "txt Yolu";
            // 
            // btn_baslat_txtYolu
            // 
            this.btn_baslat_txtYolu.Location = new System.Drawing.Point(320, 88);
            this.btn_baslat_txtYolu.Name = "btn_baslat_txtYolu";
            this.btn_baslat_txtYolu.Size = new System.Drawing.Size(128, 58);
            this.btn_baslat_txtYolu.TabIndex = 0;
            this.btn_baslat_txtYolu.Text = "Baslat";
            this.btn_baslat_txtYolu.UseVisualStyleBackColor = true;
            this.btn_baslat_txtYolu.Click += new System.EventHandler(this.btn_txtYolu_Click);
            // 
            // btn_Sec
            // 
            this.btn_Sec.Location = new System.Drawing.Point(259, 88);
            this.btn_Sec.Name = "btn_Sec";
            this.btn_Sec.Size = new System.Drawing.Size(55, 58);
            this.btn_Sec.TabIndex = 0;
            this.btn_Sec.Text = "Seç";
            this.btn_Sec.UseVisualStyleBackColor = true;
            this.btn_Sec.Click += new System.EventHandler(this.btn_Sec_Click);
            // 
            // openFile_txt
            // 
            this.openFile_txt.FileName = "NAN";
            // 
            // richText_Index
            // 
            this.richText_Index.Location = new System.Drawing.Point(12, 581);
            this.richText_Index.Name = "richText_Index";
            this.richText_Index.ReadOnly = true;
            this.richText_Index.Size = new System.Drawing.Size(715, 125);
            this.richText_Index.TabIndex = 2;
            this.richText_Index.Text = "";
            // 
            // richText_OlusanDiziler
            // 
            this.richText_OlusanDiziler.Location = new System.Drawing.Point(454, 88);
            this.richText_OlusanDiziler.Name = "richText_OlusanDiziler";
            this.richText_OlusanDiziler.ReadOnly = true;
            this.richText_OlusanDiziler.Size = new System.Drawing.Size(273, 470);
            this.richText_OlusanDiziler.TabIndex = 2;
            this.richText_OlusanDiziler.Text = "";
            // 
            // lbl_Diziler
            // 
            this.lbl_Diziler.AutoSize = true;
            this.lbl_Diziler.Location = new System.Drawing.Point(618, 68);
            this.lbl_Diziler.Name = "lbl_Diziler";
            this.lbl_Diziler.Size = new System.Drawing.Size(106, 17);
            this.lbl_Diziler.TabIndex = 1;
            this.lbl_Diziler.Text = "Olusmus Diziler";
            // 
            // lbl_AvgTickMs
            // 
            this.lbl_AvgTickMs.AutoSize = true;
            this.lbl_AvgTickMs.ForeColor = System.Drawing.Color.Green;
            this.lbl_AvgTickMs.Location = new System.Drawing.Point(564, 36);
            this.lbl_AvgTickMs.Name = "lbl_AvgTickMs";
            this.lbl_AvgTickMs.Size = new System.Drawing.Size(80, 17);
            this.lbl_AvgTickMs.TabIndex = 1;
            this.lbl_AvgTickMs.Text = "dummyText";
            // 
            // combobox_algoritma
            // 
            this.combobox_algoritma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_algoritma.FormattingEnabled = true;
            this.combobox_algoritma.Location = new System.Drawing.Point(15, 18);
            this.combobox_algoritma.Name = "combobox_algoritma";
            this.combobox_algoritma.Size = new System.Drawing.Size(238, 24);
            this.combobox_algoritma.TabIndex = 3;
            this.combobox_algoritma.SelectedIndexChanged += new System.EventHandler(this.combobox_algoritma_SelectedIndexChanged);
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Info.Location = new System.Drawing.Point(173, 149);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(80, 17);
            this.lbl_Info.TabIndex = 1;
            this.lbl_Info.Text = "dummyText";
            // 
            // btn_animasyon
            // 
            this.btn_animasyon.Location = new System.Drawing.Point(320, 169);
            this.btn_animasyon.Name = "btn_animasyon";
            this.btn_animasyon.Size = new System.Drawing.Size(92, 50);
            this.btn_animasyon.TabIndex = 0;
            this.btn_animasyon.Text = "Animasyon Baslat";
            this.btn_animasyon.UseVisualStyleBackColor = true;
            this.btn_animasyon.Visible = false;
            this.btn_animasyon.Click += new System.EventHandler(this.btn_animasyon_Click);
            // 
            // lbl_AnimasyonAyar
            // 
            this.lbl_AnimasyonAyar.AutoSize = true;
            this.lbl_AnimasyonAyar.ForeColor = System.Drawing.Color.Green;
            this.lbl_AnimasyonAyar.Image = global::AramaAlgoritma.Properties.Resources.settings_work_tool;
            this.lbl_AnimasyonAyar.Location = new System.Drawing.Point(416, 180);
            this.lbl_AnimasyonAyar.MinimumSize = new System.Drawing.Size(32, 32);
            this.lbl_AnimasyonAyar.Name = "lbl_AnimasyonAyar";
            this.lbl_AnimasyonAyar.Size = new System.Drawing.Size(32, 32);
            this.lbl_AnimasyonAyar.TabIndex = 4;
            this.lbl_AnimasyonAyar.Visible = false;
            this.lbl_AnimasyonAyar.Click += new System.EventHandler(this.lbl_AnimasyonAyar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 718);
            this.Controls.Add(this.lbl_AnimasyonAyar);
            this.Controls.Add(this.combobox_algoritma);
            this.Controls.Add(this.richText_txtYolu);
            this.Controls.Add(this.richText_AramaMetin);
            this.Controls.Add(this.richText_Index);
            this.Controls.Add(this.richText_OlusanDiziler);
            this.Controls.Add(this.richText_Metin);
            this.Controls.Add(this.lbl_Index);
            this.Controls.Add(this.lbl_Diziler);
            this.Controls.Add(this.lbl_arama_metin);
            this.Controls.Add(this.lbl_txtYolu);
            this.Controls.Add(this.lbl_metin);
            this.Controls.Add(this.lbl_Karsilastirma);
            this.Controls.Add(this.lbl_AvgTickMs);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_Zaman);
            this.Controls.Add(this.btn_Sec);
            this.Controls.Add(this.btn_animasyon);
            this.Controls.Add(this.btn_baslat_txtYolu);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama Algoritmaları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Zaman;
        private System.Windows.Forms.Label lbl_Karsilastirma;
        private System.Windows.Forms.Label lbl_Index;
        private System.Windows.Forms.RichTextBox richText_Metin;
        private System.Windows.Forms.RichTextBox richText_AramaMetin;
        private System.Windows.Forms.Label lbl_metin;
        private System.Windows.Forms.Label lbl_arama_metin;
        private System.Windows.Forms.RichTextBox richText_txtYolu;
        private System.Windows.Forms.Label lbl_txtYolu;
        private System.Windows.Forms.Button btn_baslat_txtYolu;
        private System.Windows.Forms.Button btn_Sec;
        private System.Windows.Forms.OpenFileDialog openFile_txt;
        private System.Windows.Forms.RichTextBox richText_Index;
        private System.Windows.Forms.RichTextBox richText_OlusanDiziler;
        private System.Windows.Forms.Label lbl_Diziler;
        private System.Windows.Forms.Label lbl_AvgTickMs;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ComboBox combobox_algoritma;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Button btn_animasyon;
        private System.Windows.Forms.Label lbl_AnimasyonAyar;
    }
}

