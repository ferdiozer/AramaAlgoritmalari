using System;
using System.Windows.Forms;

namespace AramaAlgoritma
{
    public enum Kontrol
    {
        Sayi_Mı,
        Bos_Mu
    }

    class Fonksiyon
    {
        /// <summary>
        /// Sayi mi boşmu kontrollerini sağlamak amacı ile (sayimi kontrolu yapılırken aynı zamanda boşmu da kontrol edilir.)
        /// </summary>
        /// <param name="kontrol"></param>
        /// <param name="_Str"></param>
        /// <returns></returns>
        public static bool Kontrol(Kontrol kontrol , params string[] _Str )
        {
            bool _return = true;
            foreach (var s in _Str)
            {
                if (s == "" || s == null) { _return = _return & false; }
                else { _return = _return & true; }
            }
            if (_return && kontrol == AramaAlgoritma.Kontrol.Sayi_Mı)
            {
                try
                {
                    foreach (var s in _Str)
                    {
                        int test = Convert.ToInt32(s);
                        _return = _return & true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    _return = _return & false;
                }
            }
            return _return;
        }

        public static T GetComboboxEnum<T>(ComboBox comboBox) where T : struct, IConvertible
        {
            T _return = default(T);
            Enum.TryParse<T>(comboBox.SelectedValue.ToString(), out _return);
            return _return;
        }

        public static void ZamaniLabelYaz(ref Label label, ref System.Diagnostics.Stopwatch stopwatch) {
            string m_Zaman = "";
            if (stopwatch != null)
            {
                m_Zaman = $"{stopwatch.Elapsed.Hours} Saat {stopwatch.Elapsed.Minutes} Dakika {stopwatch.Elapsed.Seconds} Saniye {stopwatch.Elapsed.Milliseconds} ms {stopwatch.Elapsed.Ticks} Tick ";
            }
            label.Text = m_Zaman;
        }

        /// <summary>
        /// False döner ise açık demektir.
        /// </summary>
        /// <returns>False döner ise açık demektir.</returns>
        public static bool AnimasyonFormAcikMi() {
            bool _return = true;
            var OpenForms = Application.OpenForms;
            for (int i = 0; i < OpenForms.Count; i++)
            { if (OpenForms[i].AccessibilityObject.Name == "Animasyon"){ _return = false; } }
            return _return;
        }
    }
}
