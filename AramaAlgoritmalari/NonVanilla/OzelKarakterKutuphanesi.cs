using System.Text.RegularExpressions;

namespace AramaAlgoritma
{
    class OzelKarakterKutuphanesi
    {
        private static char[] m_TemizlemeTablosu = new char[] { EnterTusu, EnterTusuOld, TabTusu };

        public const char EnterTusu = '\n';
        public const char EnterTusuOld = '\r';
        public const char TabTusu = '\t';

        public static char[] TemizlemeTablosu { get => m_TemizlemeTablosu; }

        public static string OzelKarakterleriTemizle(string str) {
            for (int i = 0; i < TemizlemeTablosu.Length; i++)
            { str = Regex.Replace(str, TemizlemeTablosu[i].ToString(), string.Empty); }
            return str;
        }
    }
}
