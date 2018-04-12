using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AramaAlgoritma
{
    class AMaximal_Shift : AnimasyonBase
    {
        private ErdincHoca.MaximalShift maximalShift = null;
        public AMaximal_Shift(string Metin, string AramaMetin) : base(Metin, AramaMetin)
        {
            Yarat(base.Metin, base.AramaMetin);
        }

        private void Yarat(string Metin, string AramaMetin)
        {
            maximalShift = new ErdincHoca.MaximalShift(base.Metin, base.AramaMetin);
        }

        public override void Basla()
        {

            Form form = LabelOlustur(); form.Show();
            if (maximalShift == null) { Yarat(base.Metin, base.AramaMetin); }
            else if (!Fonksiyon.Kontrol(Kontrol.Bos_Mu, maximalShift.AramaMetin, maximalShift.Metin)) { Yarat(base.Metin, base.AramaMetin); }
            maximalShift.PrefixOlustur();
            Task.Factory.StartNew(() =>
            {
                int j = 0, i = 0;
                while (j <= Metin.Length - AramaMetin.Length)
                {
                    i = 0;
                    LabelMetin[j + maximalShift.pat[i].loc].BackColor = HataColor;
                    while (i < AramaMetin.Length && maximalShift.pat[i].c == Metin[j + maximalShift.pat[i].loc])
                    {
                        LabelAramaMetin[maximalShift.pat[i].loc].BackColor = EslesmeColor; LabelMetin[j + maximalShift.pat[i].loc].BackColor = EslesmeColor;
                        ++i;
                        Thread.Sleep(ThreadSure);
                    }
                    try
                    {
                        LabelAramaMetin[maximalShift.pat[i].loc].BackColor = EslesmeColor;
                    }
                    catch (Exception) { }

                    Thread.Sleep(ThreadSure / 2);
                    if (i >= AramaMetin.Length){ MetinBulunduBoya(j); Thread.Sleep(ThreadSure); }

                    if (j < Metin.Length - AramaMetin.Length){ j += Math.Max(maximalShift.adaptedGs[i], maximalShift.qsBc[Metin[j + AramaMetin.Length]]); }
                    else { j += maximalShift.adaptedGs[i]; }

                    try
                    {
                        LabelMetin[j + maximalShift.pat[i].loc].BackColor = EslesmeColor;
                    }
                    catch (Exception) {}
                    AramaMetinKaydır(j+1);
                    LabelAramaMetinBCTemizle();
                    Thread.Sleep(ThreadSure);
                }
                maximalShift = null;
            });

        }
    }
}
