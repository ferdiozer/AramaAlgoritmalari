using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AramaAlgoritma
{
    class AColussi : AnimasyonBase
    {

        Colussi AramaAlgoritmasi = null;
        public AColussi(string Metin, string AramaMetin) : base(Metin, AramaMetin)
        {
            Yarat(base.Metin, base.AramaMetin);
        }

        private void Yarat(string Metin, string AramaMetin) {
            AramaAlgoritmasi = new Colussi(base.Metin, base.AramaMetin);
        }

        public override void Basla() {
            
            Form form = LabelOlustur();form.Show();
            if (AramaAlgoritmasi == null){ Yarat(base.Metin, base.AramaMetin); }
            else if (!Fonksiyon.Kontrol(Kontrol.Bos_Mu, AramaAlgoritmasi.AramaMetin, AramaAlgoritmasi.Metin)){ Yarat(base.Metin, base.AramaMetin);}
            
            int nd = AramaAlgoritmasi.PreFixOlustur();
            Task.Factory.StartNew(() =>
            {
                int i = 0, j = 0 , Karsilastirma = 0;
                int last = -1;
                while (j <= Metin.Length - AramaMetin.Length)
                {
                    LabelMetin[j + AramaAlgoritmasi.h[i]].BackColor = HataColor;
                    while (i < AramaMetin.Length && ++Karsilastirma >= 0 && last < j + AramaAlgoritmasi.h[i] && AramaMetin[AramaAlgoritmasi.h[i]] == Metin[j + AramaAlgoritmasi.h[i]]) {
                        LabelAramaMetin[AramaAlgoritmasi.h[i]].BackColor = EslesmeColor; LabelMetin[j + AramaAlgoritmasi.h[i]].BackColor = EslesmeColor; i++;
                        Thread.Sleep(ThreadSure);
                        }
                    LabelAramaMetin[AramaAlgoritmasi.h[i]].BackColor = EslesmeColor;
                    Thread.Sleep(ThreadSure / 2);

                    if (i >= AramaMetin.Length || last >= j + AramaAlgoritmasi.h[i]){ LabelAramaMetinBCTemizle(); MetinBulunduBoya(j); i = AramaMetin.Length; }
                    if (i > nd) { last = j + AramaMetin.Length - 1; }

                    j += AramaAlgoritmasi.shift[i];
                    i = AramaAlgoritmasi.next[i];
                    AramaMetinKaydır(j + AramaAlgoritmasi.h[i]);
                    try
                    {
                        LabelMetin[j + AramaAlgoritmasi.h[i]].BackColor = EslesmeColor;
                    }
                    catch (Exception)
                    {

                    }
                    LabelAramaMetinBCTemizle();
                    Thread.Sleep(ThreadSure);
                }
                AramaAlgoritmasi = null;
            });
            
        }
    }
}
