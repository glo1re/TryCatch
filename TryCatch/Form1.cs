using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;

            try
            {
                int sayi=Int32.Parse(textBox1.Text);
                textBox1.Text = (sayi+5).ToString() ;
            }
            catch (FormatException ex) 
            {
                MessageBox.Show ("Belirtilen Tipte Bir Değer Girmediniz!\n" + ex.Message,"Hata!");
                    
            }
            catch (OverflowException ex){
                MessageBox.Show("Üst Sınırı Aşan Bir Değer Girdiniz!\n" + ex.Message,"Hata!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Messi > Ronaldo");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
