using System.Drawing;

namespace AramaAlgoritma
{
    public interface IAnimasyon
    {
        int AnimasyonMetinLimit { get; }
        int AnimasyonAramaMetinLimit { get; }
        int ThreadSure { get; }
        string AramaMetin { get; }
        string Metin { get; }
        System.Windows.Forms.Form Form { get; }
        int LabelWidth { get; }
        int LabelHeight { get; }
        int FormTopBottomBosluk { get; }
        int FormBoyutKırpWidth { get; }
        int FormBoyutKırpHeight { get; }
        Color BulunduColor{ get; }
        Color HataColor{ get; }
        Color EslesmeColor { get; }
        Color LabelTextColor{ get; }
        Color VarsayilanColor { get; }
        //T AramaAlgoritmasi{ get; }
        void Basla();
    }
}
