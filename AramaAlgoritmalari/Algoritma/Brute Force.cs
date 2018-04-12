namespace AramaAlgoritma
{
    /// <summary>
    /// İçindeki kodlar http://www-igm.univ-mlv.fr/~lecroq/string/node10.html sitesindene alınmıştır. Düzenlenilmiştir.
    /// </summary>
    class Brute_Force : AlgoritmaBase
    {
        #region Ctor

        public Brute_Force(string Text, string Pattern) : base(Text, Pattern) { }

        #endregion

        public override void Basla()
        {
            var m_Stopwatch = new System.Diagnostics.Stopwatch();
            m_Stopwatch.Start();

            /*Alttaki kodu çöz sorununu..*/

            //int j = 0;
            //for (int i = 0; i < Metin.Length; i++)
            //{
            //    if (j > AramaMetin.Length - 1) { j = 0; }
            //    for (; j < AramaMetin.Length; j++)
            //    {
            //        if (Metin[i] == AramaMetin[j]) { j++; m_Match += $"{Metin[i]}"; }
            //        else { j = 0; m_Match = ""; }
            //        Karsilastirma++;
            //        break;
            //    }
            //    if (Match == AramaMetin)
            //    {
            //        int localIndex = i - (AramaMetin.Length - 1);
            //        if (localIndex < 0) { localIndex = 0; }
            //        EslesenIndexEkle(localIndex); m_Match = "";
            //    }
            //}

            int i, j;
            for (j = 0; j <= Metin.Length - AramaMetin.Length; ++j)
            {
                for (i = 0; i < AramaMetin.Length && ++Karsilastirma >= 0 && AramaMetin[i] == Metin[i + j]; ++i) ;
                if (i >= AramaMetin.Length)
                    EslesenIndexEkle(j);
            }
            m_Stopwatch.Stop();
            ZamanKaydet(m_Stopwatch);
        }

        public bool PrefixOlustur()
        {
            throw new System.NotImplementedException();
        }
    }
}
