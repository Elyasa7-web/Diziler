using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Foreach : Form
    {
        public Foreach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////string[] kisiler = { "Ali", "Ayşe", "Nur", "Elyasa", "Ahmet", "Emine" };
            ////foreach(string k in kisiler)
            ////{
            ////    listBox1.Items.Add(k);
            ////}
            //(ÖRNEK)

            ////int toplam = 0;
            ////int[] sinavlar = { 65, 87, 90, 100, 85 };
            ////foreach(int x in sinavlar)
            ////{
            ////    listBox1.Items.Add(x);
            ////    toplam = toplam + x;
            ////}
            ////label1.Text = toplam.ToString();

            ////int ortalama = toplam / sinavlar.Length;
            ////label2.Text = ortalama.ToString();
            ////(ÖRNEK)
            ///

            int sayac = 0;
            int toplam = 0;
            int[] sayilar = { 10, 40, 80, 50, 30, 35, 25, 20, 60, 90 };
            foreach(int s in sayilar)
            {
                if (s % 4 == 0)
                {
                    sayac++;
                    toplam = toplam + s;
                    listBox1.Items.Add(s);
                }
            }
            label1.Text = toplam.ToString();
            label2.Text = sayac.ToString();
            //(ÖDEV)
        }
    }
}
