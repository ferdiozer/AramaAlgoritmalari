using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AramaAlgoritma
{
    public enum HangiButton
    {
        Basla,
        Animasyon
    }

    public partial class Form1 : Form
    {
        /// <summary>
        /// burada belirlenen uzunluk geçildikçe index numarası yazılan text alt satıra geçer.
        /// </summary>
        private const int m_UzunluktaAltaGeç = 90;

        /// <summary>
        /// Ne kadar süre geçtiğini görmek için kullanılan stopwatch.
        /// </summary>
        private static System.Diagnostics.Stopwatch m_Stopwatch = new System.Diagnostics.Stopwatch();

        /// <summary>
        /// Default Fonksiyon
        /// </summary>
        public Form1()
        {
            //Default fonksiyon form elementlerinin gelmesi için.
            InitializeComponent();
            //Program içindeki bilgi gösterecek programların temizlenmesi için
            LBLTemizle();
            // Algoritma içindeki textleri buraya yazılması sağlanıyor.
            combobox_algoritma.DataSource = Enum.GetValues(typeof(Algoritma));
        }
        #region Private Form Özel Fonksiyonlar
        /// <summary>
        /// Program içindeki bilgi gösterecek programların temizlenmesi için
        /// </summary>
        private void LBLTemizle()
        {
            lbl_Karsilastirma.Text = "";
            lbl_Zaman.Text = "";
            lbl_AvgTickMs.Text = "";
            richText_OlusanDiziler.Text = "";
            richText_Index.Text = "";
            lbl_Info.Text = "";
            HepsiEnable();
        }
        /// <summary>
        /// Program içinde çalışırken enablelığı kaldırılabilicek form elementlerinin hepsini true yada readonly olacakları false yapar.
        /// </summary>
        private void HepsiEnable()
        {
            richText_AramaMetin.Enabled = true;
            richText_AramaMetin.ReadOnly = false;
            richText_Metin.Enabled = true;
            richText_Metin.ReadOnly = false;
            richText_txtYolu.Enabled = true;
            richText_txtYolu.ReadOnly = false;
            btn_Sec.Enabled = true;
            btn_baslat_txtYolu.Enabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MetinIndex"></param>
        /// <param name="KarsilastirmaSayisi"></param>
        /// <param name="Zaman"></param>
        private void FormDoldur(string MetinIndex, int KarsilastirmaSayisi, string Zaman , string DiziIcerik)
        {
            var MetinIndexSplit = MetinIndex.Split(',');
            lbl_Index.Text = $"Index Numaraları ({MetinIndexSplit.Length-1} tane)";
            string localMetinIndex = "";
            int silinen = 0;
            for (int i = 0; i < MetinIndexSplit.Length; i++)
            {
                if (MetinIndexSplit.Length - 1 == i) { continue; }
                localMetinIndex += $"{MetinIndexSplit[i]},";
                if ((localMetinIndex.Length - silinen) >= m_UzunluktaAltaGeç) { silinen = localMetinIndex.Length; localMetinIndex += $"\n"; }
            }
            richText_Index.Text = localMetinIndex;
            lbl_Karsilastirma.Text = $"{KarsilastirmaSayisi} tane karşılaştırma yapıldı.";
            lbl_Zaman.Text = $"{Zaman}";
            lbl_metin.Text = $"Metin ({richText_Metin.Text.Length})";
            lbl_arama_metin.Text = $"Aranacak Kelime ({richText_AramaMetin.Text.Length})";
            richText_OlusanDiziler.Text = DiziIcerik;
            HepsiEnable();
        }

        /// <summary>
        /// Bu fonksiyon içinde _Enum içine eklenmiş algoritmaların hangilerinde animasyon olduğunu kontrol etmek amacı için.
        /// </summary>
        private void AnimasyonVarMı() {
            var _Enum = Fonksiyon.GetComboboxEnum<Algoritma>(combobox_algoritma);
            var _Bool = false;
            switch (_Enum)
            {
                case Algoritma.Seçiniz:
                    break;
                case Algoritma.BruteForce:
                    break;
                case Algoritma.Morris_Pratt:
                    break;
                case Algoritma.Knught_Morris_Pratt:
                    break;
                //case Algoritma.Apostolico_Crochemore:
                //    break;
                case Algoritma.Claussi:
                    StaticDegisken.Animasyon = new AColussi("", "");
                    _Bool = true;
                    break;
                //case Algoritma.Maximal_Shift:
                //    StaticDegisken.Animasyon = new AMaximal_Shift("", "");
                //    _Bool = true;
                //    break;
                default:
                    break;
            }
            btn_animasyon.Visible = _Bool;
            lbl_AnimasyonAyar.Visible = _Bool;
        }

        /// <summary>
        /// Programın main fonksiyonu gibidir. Asıl algoritmaların çalıştırıldığı yer.
        /// </summary>
        /// <param name="Metin"></param>
        /// <param name="AramaMetin"></param>
        private void m_Calistir(string Metin, string AramaMetin ,ref System.Diagnostics.Stopwatch ref_Stopwatch)
        {
            // Daha yazılmamış ama gui si olan switchlerde hata verilmesi için..
            bool _TODO = false;

            var _Enum = Fonksiyon.GetComboboxEnum<Algoritma>(combobox_algoritma);
            switch (_Enum) { case Algoritma.Seçiniz: MessageBox.Show("Algoritma Seçiniz."); LBLTemizle(); HepsiEnable(); _TODO = false; break; }

            if (Fonksiyon.Kontrol(Kontrol.Bos_Mu,Metin, AramaMetin))
            {
                AlgoritmaBase _Obj = null;
                lbl_Info.Text = "Başladı";
                switch (_Enum)
                {
                    case Algoritma.BruteForce:
                        _Obj = new Brute_Force(Metin, AramaMetin);
                        break;
                    case Algoritma.Morris_Pratt:
                        _Obj = new Morris_Pratt(Metin, AramaMetin);
                        break;
                    case Algoritma.Knught_Morris_Pratt:
                        _Obj = new Knuth_Morris_Pratt(Metin, AramaMetin);
                        break;
                    //case Algoritma.Apostolico_Crochemore:
                    //    _Obj = new Apostolico_Crochemore(Metin, AramaMetin);
                    //    break;
                    case Algoritma.Claussi:
                        _Obj = new Colussi(Metin, AramaMetin);
                        break;
                    //case Algoritma.Maximal_Shift:
                    //    _Obj = new ErdincHoca.MaximalShift(Metin, AramaMetin);
                    //    break;
                    default:
                        _Obj = null;
                        _TODO = true;
                        break;
                }
                if (!_TODO && _Obj != null) {
                    _Obj.Basla(); 
                    //_Obj.ZamanKaydet(ref_Stopwatch);
                    FormDoldur(_Obj.EslesmeIndex, _Obj.Karsilastirma, _Obj.Zaman,_Obj.DiziIcerik);
                }
                GC.Collect();
            }
            else { MessageBox.Show("Boş veri var.."); LBLTemizle(); }
            if (_TODO){ if (_Enum != Algoritma.Seçiniz){ MessageBox.Show($"{_Enum} Algoritması daha sisteme eklenmedi."); } LBLTemizle();  _TODO = false;}
            ref_Stopwatch.Stop();
            Fonksiyon.ZamaniLabelYaz(ref lbl_Zaman, ref ref_Stopwatch);
            m_Stopwatch = null;
            lbl_Info.Text = "Bitti.";
        }


        /// <summary>
        /// Animasyon kısmının main fonksiyonudur.
        /// </summary>
        /// <param name="Metin"></param>
        /// <param name="AramaMetin"></param>
        private void m_Animasyon(string Metin, string AramaMetin)
        {
            // Daha yazılmamış ama gui si olan switchlerde hata verilmesi için..
            bool _TODO = false;
            var _Enum = Fonksiyon.GetComboboxEnum<Algoritma>(combobox_algoritma);
            switch (_Enum) { case Algoritma.Seçiniz: MessageBox.Show("Algoritma Seçiniz."); LBLTemizle(); HepsiEnable(); _TODO = false; break; }

            if (Fonksiyon.Kontrol(Kontrol.Bos_Mu,Metin, AramaMetin))
            {
                if (StaticDegisken.Animasyon != null){ StaticDegisken.Animasyon.Metin_AramaMetin_Ekle(Metin, AramaMetin); StaticDegisken.Animasyon.Basla(); }
                GC.Collect();
            }
            else { MessageBox.Show("Boş veri var.."); LBLTemizle(); }
            if (_TODO) { MessageBox.Show($"{_Enum} Algoritması daha sisteme eklenmedi."); LBLTemizle(); _TODO = false; }
            LBLTemizle();
            lbl_Info.Text = "Bitti.";
        }
        #endregion

        /// <summary>
        /// Kontrollerin ve diğer alt fonksiyonun çalışmasını sağlayan fonksiyon.
        /// </summary>
        /// <returns>Bittiği vakit true döndürür.</returns>
        public bool Calistir(HangiButton _HangiButton)
        {
            if (m_Stopwatch == null) { m_Stopwatch = new System.Diagnostics.Stopwatch(); }
            lbl_Info.Text = "Stopwatch Calıştı.";
            m_Stopwatch.Start();
            string txt_Metin = "";

            if (Fonksiyon.Kontrol(Kontrol.Bos_Mu, richText_txtYolu.Text))
            {
                StreamReader streamReader = null;
                try
                {
                    streamReader = new StreamReader(new FileStream(richText_txtYolu.Text, FileMode.Open, FileAccess.Read));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya yolu hatalı.");
                    Console.WriteLine(ex);
                    System.Diagnostics.Debugger.Break();
                }
                if (streamReader != null){ txt_Metin = streamReader.ReadToEnd(); streamReader.Dispose(); }
            }
            else if (Fonksiyon.Kontrol(Kontrol.Bos_Mu, richText_Metin.Text))
            {
                txt_Metin = richText_Metin.Text;
            }
            switch (_HangiButton)
            {
                case HangiButton.Basla:
                    m_Calistir(txt_Metin, richText_AramaMetin.Text, ref m_Stopwatch);
                    break;
                case HangiButton.Animasyon:
                    m_Animasyon(txt_Metin, richText_AramaMetin.Text);
                    break;
                default:
                    break;
            }
            return true;
        }

        /// <summary>
        /// Calistir fonksiyonunun Async olanı (içinde bazı form kontrolleri barındırır.)
        /// </summary>
        /// <returns></returns>
        public async Task CalistirAsync(HangiButton _HangiButton)
        {
            var _bool = Task.Factory.StartNew(() => Calistir(_HangiButton));

            btn_Sec.Enabled = false;
            btn_baslat_txtYolu.Enabled = false;

            btn_Sec.Enabled = await _bool;
            btn_baslat_txtYolu.Enabled = await _bool;
            CheckForIllegalCrossThreadCalls = await _bool;
        }

        private void btn_txtYolu_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LBLTemizle();
            Task.Factory.StartNew(() => CalistirAsync(HangiButton.Basla));
        }

        private void btn_animasyon_Click(object sender, EventArgs e)
        {
            if (Fonksiyon.AnimasyonFormAcikMi())
            { Calistir(HangiButton.Animasyon); }
            else
            {
                MessageBox.Show("Açık Animasyon Ekranı var.");
            }
        }

        private void btn_Sec_Click(object sender, EventArgs e)
        {
            LBLTemizle();
            openFile_txt.Filter = "txt (*.txt)|*.txt|html (*.html)|*.html|Hepsi (*.*)|*.*";
            if (openFile_txt.ShowDialog() == DialogResult.OK)
            {
                richText_txtYolu.Text = openFile_txt.FileName;
            }
        }

        private void richText_Metin_TextChanged(object sender, EventArgs e)
        {
            lbl_metin.Text = $"Metin ({richText_Metin.Text.Length})";
            richText_txtYolu.Text = string.Empty;
        }

        private void richText_AramaMetin_TextChanged(object sender, EventArgs e)
        {
            lbl_arama_metin.Text = $"Aranacak Kelime ({richText_AramaMetin.Text.Length})";
        }

        private void richText_txtYolu_TextChanged(object sender, EventArgs e)
        {
            richText_Metin.Text = string.Empty;
        }

        private void combobox_algoritma_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimasyonVarMı();
        }

        private void lbl_AnimasyonAyar_Click(object sender, EventArgs e)
        {
            try
            {
                new AnimasyonAyar().Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void richText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_baslat_txtYolu.PerformClick();
            }
        }
    }
}
