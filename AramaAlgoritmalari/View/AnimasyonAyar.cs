using System;
using System.Windows.Forms;

namespace AramaAlgoritma
{
    public partial class AnimasyonAyar : Form
    {
        public AnimasyonAyar()
        {
            InitializeComponent();
            TextBoxDoldur();
        }

        private void TextBoxDoldur() {
            if (StaticDegisken.Animasyon != null)
            {
                txtRich_AramaMetinLimit.Text = StaticDegisken.Animasyon.AnimasyonAramaMetinLimit.ToString();
                txtRich_MetinLimit.Text = StaticDegisken.Animasyon.AnimasyonMetinLimit.ToString();
                txtRich_sure.Text = StaticDegisken.Animasyon.ThreadSure.ToString();
            }
            else
            {
                MessageBox.Show("Animasyon yapılacak algoritma hatalı... ( Mesaj aklıma gelmedi null geldi işte .. :D)");
                this.Dispose();
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Fonksiyon.Kontrol(Kontrol.Sayi_Mı, txtRich_AramaMetinLimit.Text , txtRich_MetinLimit.Text, txtRich_sure.Text))
            {
                StaticDegisken.Animasyon.AnimasyonAramaMetinLimit = Convert.ToInt32(txtRich_AramaMetinLimit.Text);
                StaticDegisken.Animasyon.AnimasyonMetinLimit = Convert.ToInt32(txtRich_MetinLimit.Text);
                StaticDegisken.Animasyon.ThreadSure = Convert.ToInt32(txtRich_sure.Text);
                MessageBox.Show("Kayıt edildi.");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Boş yada sayi girmediniz.");
            }
        }

        private void txtRich_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Kaydet.PerformClick();
            }
        }

        private void txtRich_Enter_SelectAll(object sender, EventArgs e)
        {
            var txtbox = (RichTextBox)sender;
            txtbox.SelectAll();
        }
    }
}
