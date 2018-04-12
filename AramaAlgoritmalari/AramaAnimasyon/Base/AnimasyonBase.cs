using System;
using System.Drawing;
using System.Windows.Forms;

namespace AramaAlgoritma
{
    abstract class AnimasyonBase : IAnimasyon 
    {
        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Metin"></param>
        /// <param name="AramaMetin"></param>
        public AnimasyonBase(string Metin, string AramaMetin)
        {
            this.Metin = Metin;
            this.AramaMetin = AramaMetin;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnimasyonBase()
        {

        }
        #endregion

        #region Private Değişken
        private static int m_FormBoyutKırpWidth = 250;
        private static int m_FormBoyutKırpHeight = 150;
        private int m_AnimasyonMetinLimit = 25;
        private int m_AnimasyonAramaMetinLimit = 10;
        private int m_LabelWidth = 32;
        private int m_LabelHeight = 32;
        private int m_FormTopBottomBosluk = 20;
        private int m_EkranGenislikMax = Screen.PrimaryScreen.Bounds.Width - m_FormBoyutKırpWidth;
        private int m_EkranUzunlukMax = Screen.PrimaryScreen.Bounds.Height - m_FormBoyutKırpHeight;
        private int m_ThreadSure = 500;
        private Color m_BulunduColor = Color.Green;
        private Color m_HataColor = Color.Blue;
        private Color m_EslesmeColor = Color.Yellow;
        private Color m_LabelTextColor = Color.Black;
        private Color m_VarsayilanColor = Color.White;
        private Form m_Form = null;
        private System.Drawing.Font LabelFont = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private string m_Metin = "";
        private string m_AramaMetin = "";
        private Label[] m_LabelAramaMetin = null;
        private Label[] m_LabelMetin = null;
        #endregion

        #region Public Değişken
        
        public int AnimasyonMetinLimit { get => m_AnimasyonMetinLimit; set { m_AnimasyonMetinLimit = value; } }
        public int AnimasyonAramaMetinLimit { get => m_AnimasyonAramaMetinLimit;  set { m_AnimasyonAramaMetinLimit = value; } }
        public string AramaMetin{ get => m_AramaMetin; set {value = OzelKarakterKutuphanesi.OzelKarakterleriTemizle(value); if (value.Length>m_AnimasyonAramaMetinLimit){ value = value.Substring(0, m_AnimasyonAramaMetinLimit); } m_AramaMetin = value.ToLower(); } }
        public string Metin { get => m_Metin; set { value = OzelKarakterKutuphanesi.OzelKarakterleriTemizle(value); if (value.Length > m_AnimasyonMetinLimit) { value = value.Substring(0, m_AnimasyonMetinLimit); } m_Metin = value.ToLower(); } }
        public Label[] LabelAramaMetin { get => m_LabelAramaMetin; }
        public Label[] LabelMetin { get => m_LabelMetin; }
        public int ThreadSure { get => m_ThreadSure; set => m_ThreadSure = value; }
        public Form Form { get => m_Form; }
        public int LabelWidth { get => m_LabelWidth; protected set => m_LabelWidth = value; }
        public int LabelHeight { get => m_LabelHeight; protected set => m_LabelHeight = value; }
        public int FormTopBottomBosluk { get => m_FormTopBottomBosluk; protected set => m_FormTopBottomBosluk = value; }
        public int FormBoyutKırpWidth { get => m_FormBoyutKırpWidth;protected set => m_FormBoyutKırpWidth = value; }
        public int FormBoyutKırpHeight { get => m_FormBoyutKırpHeight; protected set => m_FormBoyutKırpHeight = value; }
        public int EkranGenislikMax { get => m_EkranGenislikMax; }
        public int EkranUzunlukMax { get => m_EkranUzunlukMax; }
        public Color BulunduColor { get => m_BulunduColor;  }
        public Color HataColor { get => m_HataColor; }
        public Color EslesmeColor { get => m_EslesmeColor; }
        public Color LabelTextColor { get => m_LabelTextColor; }
        public Color VarsayilanColor { get => m_VarsayilanColor; }

        #endregion

        #region Private Fonksiyon

        private void MetinLabelOlustur() {
            string LocalNameText = "MetinAni";
            var LocalText = Metin;
            m_LabelMetin = new Label[LocalText.Length];
            for (int i = 0; i < LocalText.Length; i++)
            {
                var LocalLabel = new Label();
                LocalLabel.Name = $"{LocalNameText}_{i}";
                LocalLabel.Width = LabelWidth;
                LocalLabel.Height = LabelHeight;
                LocalLabel.ForeColor = LabelTextColor;
                LocalLabel.BackColor = VarsayilanColor;
                LocalLabel.Font = LabelFont;
                LocalLabel.Text = LocalText[i].ToString();
                LocalLabel.Left = LocalLabel.Width * (i+1);
                LocalLabel.Top = FormTopBottomBosluk;
                Form.Controls.Add(LocalLabel);
                m_LabelMetin[i] = LocalLabel;
            }
        }

        private void AramaMetinLabelOlustur() {

            string LocalNameText = "AramaMetinAni";
            var LocalText = AramaMetin+" ";
            m_LabelAramaMetin = new Label[LocalText.Length];
            for (int i = 0; i < LocalText.Length; i++)
            {
                var LocalLabel = new Label();
                LocalLabel.Name = $"{LocalNameText}_{i}";
                LocalLabel.Width = LabelWidth;
                LocalLabel.Height = LabelHeight;
                LocalLabel.BackColor = VarsayilanColor;
                LocalLabel.ForeColor = LabelTextColor;
                LocalLabel.Font = LabelFont;
                LocalLabel.Text = LocalText[i].ToString();
                LocalLabel.Left = LocalLabel.Width * (i+1);
                LocalLabel.Top = FormTopBottomBosluk + LocalLabel.Height;
                Form.Controls.Add(LocalLabel);
                m_LabelAramaMetin[i] = LocalLabel;
            }
        }

        private int LabelGenislikBul() {
            // TODO : Belki bir ara.. AS:D
            //var test = (((AramaMetin.Length + 1)*2 + (Metin.Length + 1))) * LabelWidth;
            //if (EkranGenislikMax > test)
            //{ LabelHeight = LabelWidth; return LabelWidth; }else { LabelWidth = (LabelWidth*2) / 3; return LabelGenislikBul(); }
            return LabelWidth;
        }

        private void EkranaGoreBoyutlarıDuzenle() {
            Form.Height = (LabelHeight + (FormTopBottomBosluk * 2)) * 2;
            Form.Width = LabelWidth * (LabelAramaMetin.Length + LabelMetin.Length);
        }
        #endregion

        #region Public Fonksiyon
        public abstract void Basla();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Metin"></param>
        /// <param name="AramaMetin"></param>
        public void Metin_AramaMetin_Ekle(string Metin, string AramaMetin)
        {
            this.Metin = Metin; this.AramaMetin = AramaMetin;
        }
    #endregion

        #region Protected Fonksiyon
        protected Form LabelOlustur() {
            m_Form = new Animasyon();
            LabelGenislikBul();
            AramaMetinLabelOlustur(); MetinLabelOlustur();
            EkranaGoreBoyutlarıDuzenle();
            return Form; }

        /// <summary>
        /// AramaMetin eşleşme boyaması yapıldığı zamandan sonra temizlenmesi için gerektiğinde çağırılır.
        /// </summary>
        protected void LabelAramaMetinBCTemizle()
        {
            for (int k = 0; k < AramaMetin.Length; k++)
            { LabelAramaMetin[k].BackColor = VarsayilanColor; }
        }

        /// <summary>
        /// Bulunan index değeri verildiğinde o indexten itibaren metini boyar.
        /// </summary>
        /// <param name="Index">Index</param>
        protected void MetinBulunduBoya(int Index)
        {
            for (int k = 0; k < AramaMetin.Length; k++)
            { LabelMetin[Index + k].BackColor = BulunduColor; }
        }

        /// <summary>
        /// Kaç index sağa kaydırması gerektiğini söyle ona göre kaydırır.
        /// </summary>
        /// <param name="j">Kaç index sağa</param>
        protected void AramaMetinKaydır(int j)
        {
            if (AramaMetin.Length == 1) { ++j; }
            for (int yy = 0; yy < LabelAramaMetin.Length; yy++)
            {
                LabelAramaMetin[yy].Left = LabelAramaMetin[yy].Width * (j + yy);
                LabelAramaMetin[yy].BackColor = VarsayilanColor;
            }
        }
        #endregion

    }
}