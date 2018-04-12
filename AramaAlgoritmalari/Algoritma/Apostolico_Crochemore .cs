using System;

namespace AramaAlgoritma
{
    /// <summary>
    /// İçindeki kodlar http://www-igm.univ-mlv.fr/~lecroq/string/node10.html sitesindene alınmıştır. Düzenlenilmiştir.
    /// </summary>
    class Apostolico_Crochemore : Knuth_Morris_Pratt
    {
        private int[] m_kmpNext = null;

        public Apostolico_Crochemore(string Metin, string AramaMetin) : base(Metin, AramaMetin)
        {

        }

        private void AramaYap()
        {
            int ell;
            for (ell = 1; ++Karsilastirma >= 0 && ell< AramaMetin.Length && AramaMetin[ell - 1] == AramaMetin[ell]; ell++)
            {
                if (ell == AramaMetin.Length)
                    ell = 0;
            }

            int i = ell;
            int j = 0, k = 0;
            while (j <= Metin.Length - AramaMetin.Length)
            {
                while (i < AramaMetin.Length && ++Karsilastirma >= 0 && AramaMetin[i] == Metin[i + j])
                    ++i;
                if (i >= AramaMetin.Length)
                {
                    while (k < ell && ++Karsilastirma >= 0 && AramaMetin[k] == Metin[j + k])
                        ++k;
                    if (k >= ell)
                        EslesenIndexEkle(j);
                }
                j += (i - kmpNext[i]);
                if (i == ell)
                    k = Math.Max(0, k - 1);
                else
                   if (kmpNext[i] <= ell)
                {
                    k = Math.Max(0, kmpNext[i]);
                    i = ell;
                }
                else
                {
                    k = ell;
                    i = kmpNext[i];
                }
            }
        }

        public override void Basla()
        {
            var m_Stopwatch = new System.Diagnostics.Stopwatch();
            m_Stopwatch.Start();
            PrefixOlustur_KMP();
            m_kmpNext = base.kmpNext;
            AramaYap();
            m_Stopwatch.Stop();
            ZamanKaydet(m_Stopwatch);
            DiziIcerikEkleme("kmpNext", m_kmpNext);
        }
    }
}
