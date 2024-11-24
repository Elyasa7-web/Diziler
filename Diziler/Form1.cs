using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////string[] kisiler = { "Ali", "Veli", "Elyasa", "Mert", "Hüseyin", "Kubilay", "Metehan" };
            ////label1.Text = kisiler[3];
            //(ÖRNEK)
            ////int[] sayilar = { 3, 1, 8, 2, 4, 6, 5, 7 };
            ////label1.Text = sayilar[5].ToString();
            //(ÖRNEK)
            ////double[] ondalik = { 63.333, 50.999, 755.322, 24.333, 45.666, 90.888 };
            ////label1.Text = ondalik[4].ToString();
            //(ÖDEV)
            char[] harf = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            label1.Text = harf[3].ToString();
            //(ÖDEV2)
        }
    }
}
