﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Diziler_butun_elemanlari_yazdirma : Form
    {
        public Diziler_butun_elemanlari_yazdirma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////string[] sehirler = { "Ankara", "Eskişehir", "Antalya", "Adana", "Bursa", "Balıkesir" };
            ////for (int i = 0; i < sehirler.Length; i++)
            ////{
            ////    listBox1.Items.Add(sehirler[i]);
            ////}
            ////(ÖRNEK)

            ////int[] sayilar = { 4, 2, 6, 3, 1, 5, 7, 9, };
            ////for (int i=0; i<sayilar.Length; i++)
            ////{
            ////    if (sayilar[i] % 2 == 0)
            ////    {
            ////        listBox1.Items.Add(sayilar[i]);
            ////    }
            ////}
            ////(ÖRNEK)

            int[] sayilar = { 12, 23, 44, 3, 2, 5, 8, 22, 56, 10 };
            for (int i = 0; i < sayilar.Length; i++) 
            {
                if (sayilar[i] % 2 == 0 && i <= 10)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
            //(ÖDEV)
        }
    }
}
