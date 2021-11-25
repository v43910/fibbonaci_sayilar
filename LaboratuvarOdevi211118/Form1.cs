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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[,] dizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    listBox1.Items.Add(dizi[i, j]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] dizi2 = new int[10];
            int[] dizi3 = new int[10];

            dizi1.CopyTo(dizi2, 2);
            foreach (int item in dizi2)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Items.Add("____değişen");

            Array.Copy(dizi1, 2, dizi3, 5, 3);
            foreach (int item in dizi3)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] dizi = { "Zeynep", "Fatma", "Ali", "Yılmaz", "Gökhan", "Osman", "Feride" };
            foreach (string s in dizi)
            {
                listBox1.Items.Add(s);
            }
            listBox1.Items.Add("____Sıralama");
            Array.Sort(dizi);//dizi sıralama.
            foreach (string s in dizi)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] dizi = { "Zeynep", "Fatma", "Ali", "Yılmaz", "Gökhan", "Osman", "Feride" };
            foreach (string s in dizi)
            {
                listBox1.Items.Add(s);
            }
            listBox1.Items.Add("____Sıralama");
            //Array.Sort(dizi);//dizi sıralama.

            int indis = Array.BinarySearch(dizi, "Zeynep");
            if (indis<0)
            {
                listBox1.Items.Add("bulunamadı");
            }
            else
            {
                listBox1.Items.Add("indis no :" + indis);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LaboratuvarOdevi211118 lab = new LaboratuvarOdevi211118();
            lab.Show();
        }
    }
}
