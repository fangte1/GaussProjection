using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussProjection
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        double a, e2, e12, l, X, m0, m2, m4, m6, m8, a0, a2, a4, a6, a8;
        double d2r = 180 * 3600 / Math.PI;
        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, B, L, l, L0, Bf1, tf, nf2, Wf, Nf, Mf, d1, f1, m1;
            if (radioButton1.Checked)
            {
                a = 6378245.0;
                e2 = 0.006693421622966;
                e12 = 0.006738525414683;
                m0 = a * (1 - e2);
                m2 = (3 * e2 * m0) / 2;
                m4 = (5 * e2 * m2) / 4;
                m6 = (7 * e2 * m4) / 6;
                m8 = (9 * e2 * m6) / 8;
                a0 = (m0 + (m2 / 2) + ((3 * m4) / 8) + ((5 * m6) / 16) + ((35 * m8) / 128));
                a2 = m2 / 2 + m4 / 2 + 15 * m6 / 32 + 7 * m8 / 16;
                a4 = m4 / 8 + 3 * m6 / 16 + 7 * m8 / 32;
                a6 = m6 / 32 + m8 / 16;
                a8 = m8 / 128;
            }
            else if (radioButton2.Checked)
            {
                a = 6378140.0;
                e2 = 0.006694384999588;
                e12 = 0.006739501819473;
                m0 = a * (1 - e2);
                m2 = (3 * e2 * m0) / 2;
                m4 = (5 * e2 * m2) / 4;
                m6 = (7 * e2 * m4) / 6;
                m8 = (9 * e2 * m6) / 8;
                a0 = (m0 + (m2 / 2) + ((3 * m4) / 8) + ((5 * m6) / 16) + ((35 * m8) / 128));
                a2 = m2 / 2 + m4 / 2 + 15 * m6 / 32 + 7 * m8 / 16;
                a4 = m4 / 8 + 3 * m6 / 16 + 7 * m8 / 32;
                a6 = m6 / 32 + m8 / 16;
                a8 = m8 / 128;
            }
            else if (radioButton3.Checked)
            {
                a = 6378137.0;
                e2 = 0.0066943799013;
                e12 = 0.00673949674227;
                m0 = a * (1 - e2);
                m2 = (3 * e2 * m0) / 2;
                m4 = (5 * e2 * m2) / 4;
                m6 = (7 * e2 * m4) / 6;
                m8 = (9 * e2 * m6) / 8;
                a0 = (m0 + (m2 / 2) + ((3 * m4) / 8) + ((5 * m6) / 16) + ((35 * m8) / 128));
                a2 = m2 / 2 + m4 / 2 + 15 * m6 / 32 + 7 * m8 / 16;
                a4 = m4 / 8 + 3 * m6 / 16 + 7 * m8 / 32;
                a6 = m6 / 32 + m8 / 16;
                a8 = m8 / 128;
            }
            x = double.Parse(textBox3.Text);
            y = double.Parse(textBox4.Text);
            double a1 = 3600 * a0 / d2r;
            double Bf = x / a1;
            do
            {
                Bf1 = Bf;
                Bf = (x - (-a2 * Math.Sin(2 * Bf1) / 2 + a4 * Math.Sin(4 * Bf1) / 4 - a6 * Math.Sin(6 * Bf1) / 6 + a8 * Math.Sin(8 * Bf1) / 8)) / a0;
            } while (Math.Abs(Bf - Bf1) > 1e-15);
            tf = Math.Tan(Bf);
            nf2 = e12 * Math.Cos(Bf) * Math.Cos(Bf); ;
            Wf = Math.Sqrt(1 - e2 * Math.Sin(Bf) * Math.Sin(Bf));
            Nf = a / Wf;
            Mf = a * (1 - e2) / Math.Pow(Wf, 3);
            B = Bf - (tf * y * y) / (2 * Mf * Nf) + (tf * (5 + 3 * tf * tf + nf2 - 9 * nf2 * tf * tf) * Math.Pow(y, 4)) / (24 * Mf * Math.Pow(Nf, 3)) - (tf * Math.Pow(y, 6) * (61 + 90 * tf * tf + 45 * Math.Pow(tf, 4))) / (720 * Mf * Math.Pow(Nf, 5));
            B = B * d2r;
            l = y / (Nf * Math.Cos(Bf)) - Math.Pow(y, 3) * (1 + 2 * tf * tf + nf2) / (6 * Math.Pow(Nf, 3) * Math.Cos(Bf)) + Math.Pow(y, 5) * (5 + 28 * tf * tf + 24 * Math.Pow(tf, 4) + 6 * nf2 + 8 * nf2 * tf * tf) / (120 * Math.Pow(Nf, 5) * Math.Cos(Bf));
            l = l * d2r;
            L0 = double.Parse(textBox9.Text) * 3600;
            L = L0 + l;
            d1 = (int)(B / 3600);
            f1 = (int)((B - d1 * 3600) / 60);
            m1 = Math.Round((B - d1 * 3600 - f1 * 60), 5);
            textBox1.Text = d1.ToString();
            textBox5.Text = f1.ToString();
            textBox6.Text = m1.ToString();
            d1 = (int)(L / 3600);
            f1 = (int)((L - d1 * 3600) / 60);
            m1 = Math.Round((L - d1 * 3600 - f1 * 60), 5);
            textBox8.Text = d1.ToString();
            textBox7.Text = f1.ToString();
            textBox2.Text = m1.ToString();

        }
    }
}
