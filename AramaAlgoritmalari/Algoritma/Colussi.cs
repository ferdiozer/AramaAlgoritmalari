namespace AramaAlgoritma
{
    /// <summary>
    /// İçindeki kodlar http://www-igm.univ-mlv.fr/~lecroq/string/node10.html sitesindene alınmıştır. Düzenlenilmiştir.
    /// </summary>
    class Colussi : Knuth_Morris_Pratt
    {
        private int[] m_shift = null;
        private int[] m_next = null;
        private int[] m_hmax = null;
        private int[] m_kmin = null;
        private int[] m_nhd0 = null;
        private int[] m_rmin = null;
        private int[] m_h = null;
        private int[] m_kmpNext = null;
        private int m_nd = 0;

        public int[] shift { get => m_shift; }
        public int[] next { get => m_next; }
        public int[] hmax { get => m_hmax; }
        public int[] kmin { get => m_kmin; }
        public int[] nhd0 { get => m_nhd0; }
        public int[] rmin { get => m_rmin; }
        public int[] h { get => m_h; }
        public int nd { get => m_nd; }

        public Colussi(string Metin, string AramaMetin) : base(Metin, AramaMetin)
        {

        }

        /// <summary>
        /// Colussi de oluşan dizileri out ile dışarı veren ve return olarak nd değerini döndüren fonksiyon.
        /// </summary>
        /// <param name="kmpNext"></param>
        /// <param name="kmin"></param>
        /// <param name="h"></param>
        /// <param name="next"></param>
        /// <param name="shift"></param>
        /// <param name="hmax"></param>
        /// <param name="rmin"></param>
        /// <param name="ndh0"></param>
        /// <returns>nd değerini döndürür</returns>
        protected int PreFixOlustur_Colussi(out int[] kmpNext , out int[] kmin , out int[] h, out int[] next , out int[] shift , out int[] hmax , out int[] rmin , out int[] ndh0) {
            int nd = PreFixOlustur();
            kmpNext = m_kmpNext;
            kmin = m_kmin;
            h = m_h;
            next = m_next;
            shift = m_shift;
            hmax = m_hmax;
            rmin = m_rmin;
            ndh0 = m_nhd0; 
            return nd;
        }
        
        /// <summary>
        /// Colussi de oluşan dizileri out ile dışarı veren ve return olarak nd değerini döndüren fonksiyon.
        /// </summary>
        /// <returns>nd değerini döndürür</returns>
        public int PreFixOlustur()
        {
            int Boyut = AramaMetin.Length + 1;
            m_shift = new int[Boyut];
            m_next = new int[Boyut];
            m_hmax = new int[Boyut];
            m_kmin = new int[Boyut];
            m_nhd0 = new int[Boyut];
            m_rmin = new int[Boyut];
            m_h = new int[Boyut];
            m_kmpNext = new int[Boyut];
            //
            int i = 0;
            int j = m_kmpNext[0] = -1;
            PrefixOlustur_KMP();
            m_kmpNext = base.kmpNext;
            //
            i = 1;
            int k = 1;
            int q = 0;
            while (k <= AramaMetin.Length)
            {
                while (i < AramaMetin.Length && AramaMetin[i] == AramaMetin[i - k]) { i++; }
                hmax[k] = i;
                q = k + 1;
                while (hmax[q - k] + k < i){ hmax[q] = hmax[q - k] + k; q++; }
                k = q;
                if (k == i + 1) { i = k; }
            }
            //
            for (i = AramaMetin.Length; i >= 1; --i)
            {
                if (hmax[i] < AramaMetin.Length) { kmin[hmax[i]] = i; }
            }
            //
            int r = 0;
            for (i = AramaMetin.Length - 1; i >= 0; --i)
            {
                if (hmax[i + 1] == AramaMetin.Length) { r = i + 1; }
                if (kmin[i] == 0) { rmin[i] = r; }
            }
            //
            int s = -1;
            r = AramaMetin.Length;
            for (i = 0; i < AramaMetin.Length; ++i) { if (kmin[i] == 0) { h[--r] = i; } else { h[++s] = i; } }
            //
            //
            int nd = s;
            for (i = 0; i <= nd; ++i) { shift[i] = kmin[h[i]]; }
            for (i = nd + 1; i < AramaMetin.Length; ++i){ shift[i] = rmin[h[i]]; }
            shift[AramaMetin.Length] = rmin[0];
            //
            s = 0;
            for (i = 0; i < AramaMetin.Length; ++i){ nhd0[i] = s; if (kmin[i] > 0) { s++; } }
            //
            for (i = 0; i <= nd; ++i) { next[i] = nhd0[h[i] - kmin[h[i]]]; }
            for (i = nd + 1; i < AramaMetin.Length; ++i) { next[i] = nhd0[AramaMetin.Length - rmin[h[i]]]; }
            next[AramaMetin.Length] = nhd0[AramaMetin.Length - rmin[h[AramaMetin.Length - 1]]];
            //
            m_nd = nd;
            return (nd);
        }

        private void AramaYap(int nd)
        {
            int i = 0, j = 0;
            int last = -1;
            while (j <= Metin.Length - AramaMetin.Length)
            {
                 while (i < AramaMetin.Length && ++Karsilastirma >= 0 /**/ && last < j + h[i] && AramaMetin[h[i]] == Metin[j + h[i]]){ i++; }
                if (i >= AramaMetin.Length || last >= j + h[i])
                {
                    EslesenIndexEkle(j);
                    i = AramaMetin.Length;
                }
                if (i > nd)
                    last = j + AramaMetin.Length - 1;
                j += shift[i];
                i = next[i];
            }
        }

        private void DiziEkleme(){
            DiziIcerikEkleme("kmpNext", m_kmpNext);
            DiziIcerikEkleme("kmin", m_kmin);
            DiziIcerikEkleme("h", m_h);
            DiziIcerikEkleme("next", m_next);
            DiziIcerikEkleme("shift", m_shift);
            DiziIcerikEkleme("hmax", m_hmax);
            DiziIcerikEkleme("rmin", m_rmin);
            DiziIcerikEkleme("nhd0", m_nhd0);
        }

        /// <summary>
        /// 
        /// </summary>
        protected void DiziEkleme_Colussi() {
            DiziEkleme();
        }

        public override void Basla()
        {
            AramaYap(PreFixOlustur());
            DiziEkleme();
        }

    }
}

