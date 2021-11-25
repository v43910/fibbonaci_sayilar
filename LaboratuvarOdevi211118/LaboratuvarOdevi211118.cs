using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratuvarOdevi211118
{
    public partial class LaboratuvarOdevi211118 : Form
    {
        public LaboratuvarOdevi211118()
        {
            InitializeComponent();
        }
        string[] listelenenSayilar = new string[0];

        private void btnFibNormSirala_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] fibbSayilar = new string[Convert.ToInt32(txtFibNormSirala.Text)];

            fibbSayilar = _fibSayiOlusturucu(fibbSayilar.Length);

           
            for (int i = 0; i <= fibbSayilar.Length; i++)
            {
                string[] copyaDizi = new string[i];
                Array.Copy(fibbSayilar, copyaDizi, i);
                string aktarilacakSatir = "";
                foreach (string x in copyaDizi)
                {
                    aktarilacakSatir += "(" + x + ") ";
                }
                listBox1.Items.Add(aktarilacakSatir);
            }

            //btnFibIndisBul için gereken hazırlıklar.
            btnFibIndisBul.Enabled = true;
            Array.Resize(ref listelenenSayilar, fibbSayilar.Length);
            Array.Copy(fibbSayilar, listelenenSayilar, fibbSayilar.Length);
        }

        private void btnFibTersSirala_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] fibbSayilar = new string[Convert.ToInt32(txtFibTersSirala.Text)];

            fibbSayilar = _fibSayiOlusturucu(fibbSayilar.Length);
            Array.Reverse(fibbSayilar);

            for (int i = 0; i <= fibbSayilar.Length; i++)
            {
                string[] copyaDizi = new string[i];
                Array.Copy(fibbSayilar, copyaDizi, i);
                string aktarilacakSatir = "";
                foreach (string x in copyaDizi)
                {
                    aktarilacakSatir += "(" + x + ") ";
                }
                listBox1.Items.Add(aktarilacakSatir);
            }

            //btnFibIndisBul için gereken hazırlıklar.
            btnFibIndisBul.Enabled = true;
            Array.Resize(ref listelenenSayilar, fibbSayilar.Length);
            Array.Copy(fibbSayilar, listelenenSayilar, fibbSayilar.Length);
        }

        private void btnFibIndisBul_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtFibIndisBul.Text);
            if (listelenenSayilar.Length>=index+1)
            {
                MessageBox.Show("İndex No Değeri : "+listelenenSayilar[index]);
            }
            else
            {
                MessageBox.Show("Belirtilen Sayı, Gerçerli aralıkta değil.\n Gireceğiniz Sayı " + (listelenenSayilar.Length - 1) + "'den büyük olamaz.");
            }
        }


        private string[] _fibSayiOlusturucu(int tekrarSayisi) {
            string[] value = new string[tekrarSayisi];
            int sayi1 = 1;
            int sayi2 = 1;
            int gecerliSayi = 1;
            value[0] = "1";
            value[1] = "1";
            for (int i = 2; i < tekrarSayisi; i++)
            {
                gecerliSayi = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = gecerliSayi;
                value[i] = Convert.ToString(gecerliSayi);
            }
            return value;
        }


        public void _sadeceRakam(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            //BOŞLUK ENGELLEYİCİ
            if ((int)e.KeyChar == 32)
                      e.Handled = true;
            
        }


    }
}
