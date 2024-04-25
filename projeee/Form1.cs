using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeee
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

       private void button1_Click(object sender, EventArgs e)
        {
            string[] sayılar = textBox1.Text.Split(',');
            double max = Convert.ToDouble(sayılar[0]);
            bool geçerliSayıGirildi = false;

            foreach (string sayı in sayılar)
            {
                if (double.TryParse(sayı, out double intSayı))
                {
                    max = Math.Max(max, intSayı);
                    geçerliSayıGirildi = true;
                }
            }

            if (geçerliSayıGirildi)
            {
                label1.Text = "En büyük sayı: " + max;
            }
            else
            {
                MessageBox.Show("Geçerli sayılar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
      
        private void button2_Click(object sender, EventArgs e)
        {

             if (double.TryParse(textBox1.Text, out double sayı))
            {
                double mutlak = Math.Abs(sayı);
                label1.Text = "|" + sayı + "|" + "= " + mutlak;

            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
           
            /*
            double sayıı = Convert.ToDouble(textBox1.Text);
            double mutlak = Math.Abs(sayıı);
            label1.Text = "|" + sayıı + "|" + "= " + mutlak;
            //diğer bir yol bu başta bunu kullandım fakat texte karekter girdiğimde kodda hata olunca geliştirdim
            */
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayı) && sayı >= 0)
            {
                double karekök = Math.Sqrt(sayı);
                label1.Text= $"√{sayı} = {karekök}";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir pozitif sayı girin.");
            }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
             if (double.TryParse(textBox1.Text, out double açı))
            {
                double sin = Math.Sin(açı * Math.PI / 180);
                label1.Text = $"sin({açı}) = {sin}";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir açı girin.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double açı))
            {
                double cos = Math.Cos(açı * Math.PI / 180);
                label1.Text = $"cos({açı}) = {cos}";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir açı girin.");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {  
                textBox1.Undo();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //sinüs başlangıç ve bitiş değerine göre çizdimre???
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                //cosinüs başlangıç ve bitiş değerlerine göre çizdirme???
            }
        }
    }
}
