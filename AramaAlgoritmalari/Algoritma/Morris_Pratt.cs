namespace AramaAlgoritma
{
    /// <summary>
    /// İçindeki kodlar http://www-igm.univ-mlv.fr/~lecroq/string/node10.html sitesindene alınmıştır. Düzenlenilmiştir.
    /// </summary>
    class Morris_Pratt : AlgoritmaBase
    {
        private int[] m_kmpNext = null;

        public int[] kmpNext { get => m_kmpNext; }

        public Morris_Pratt(string Metin, string AramaMetin) : base(Metin, AramaMetin)
        {

        }

        public bool PrefixOlustur()
        {
            m_kmpNext = new int[AramaMetin.Length + 1];
            int i, j;

            i = 0;
            j = m_kmpNext[0] = -1;
            while (i < AramaMetin.Length)
            {
                while (j > -1 && AramaMetin[i] != AramaMetin[j])
                    j = m_kmpNext[j];
                i++;
                j++;
                if (i >= AramaMetin.Length)
                { break; }
                if (AramaMetin[i] == AramaMetin[j])
                    m_kmpNext[i] = m_kmpNext[j];
                else
                    m_kmpNext[i] = j;
            }
            return true;
        }

        private void AramaYap()
        {
            int i = 0, j = 0;
            while (AramaMetin.Length < Metin.Length)
            {
                if (j >= Metin.Length) { break; }

                while (i > -1 && ++Karsilastirma>=0 && AramaMetin[i] != Metin[j])
                { i = m_kmpNext[i];  }
                i++; j++;

                if (i >= AramaMetin.Length) { EslesenIndexEkle(j - i); i = m_kmpNext[i]; }
            }
        }

        public override void Basla()
        {
            PrefixOlustur();
            AramaYap();
            DiziIcerikEkleme("kmpNext", m_kmpNext);
        }
    }
}
