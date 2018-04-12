namespace AramaAlgoritma
{
    public interface IAlgoritma
    {
        string AramaMetin { get; }
        int Karsilastirma { get ;}
        string EslesmeIndex { get; }
        string Metin { get; }
        string Zaman { get; }
        string DiziIcerik { get; }
        void EslesenIndexEkle(int Index);
        void DiziIcerikEkleme<T>(string DiziDegiskenAdı, T[] DizininKendisi);
        void ZamanKaydet(System.Diagnostics.Stopwatch m_Stopwatch);
        void Basla();
    }
}
