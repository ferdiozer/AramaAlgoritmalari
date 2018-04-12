namespace AramaAlgoritma
{
    public abstract class AlgoritmaBase : IAlgoritma
    {

        #region Private Değişken
        private int m_Karsilastirma = 0;
        private string m_EslesmeIndex = "";
        private string m_Metin = "";
        private string m_AramaMetin = "";
        private string m_Zaman = "";
        private string m_DiziIcerik = "";
        #endregion

        #region Public Değişken
        public string AramaMetin { get => m_AramaMetin; protected set => m_AramaMetin = OzelKarakterKutuphanesi.OzelKarakterleriTemizle(value).ToLower(); }
        public int Karsilastirma { get => m_Karsilastirma; protected set => m_Karsilastirma = value; }
        public string EslesmeIndex { get => m_EslesmeIndex; }
        public string Metin { get => m_Metin; protected set => m_Metin = OzelKarakterKutuphanesi.OzelKarakterleriTemizle(value).ToLower(); }
        public string Zaman { get => m_Zaman; }
        public string DiziIcerik { get => m_DiziIcerik;}
        #endregion

        protected AlgoritmaBase(string Metin, string AramaMetin)
        {
            this.Metin = Metin;
            this.AramaMetin = AramaMetin;
        }

        public void EslesenIndexEkle(int Index) {
            m_EslesmeIndex += $"{Index},";
        }
        public void DiziIcerikEkleme<T>(string DiziDegiskenAdı , T[] DizininKendisi) {
            for (int i = 0; i < DizininKendisi.Length; i++)
            {
                m_DiziIcerik += $" {DiziDegiskenAdı}[{i}] : {DizininKendisi[i]}\n";
            }
        }

        public void ZamanKaydet(System.Diagnostics.Stopwatch m_Stopwatch) {
            if (m_Stopwatch != null)
            {
                m_Zaman = $"{m_Stopwatch.Elapsed.Hours} Saat {m_Stopwatch.Elapsed.Minutes} Dakika {m_Stopwatch.Elapsed.Seconds} Saniye {m_Stopwatch.Elapsed.Milliseconds} ms {m_Stopwatch.Elapsed.Ticks} Tick ";
            }
        }

        public abstract void Basla();

    }
}
