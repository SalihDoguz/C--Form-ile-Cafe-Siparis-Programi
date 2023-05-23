using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salihDoguz211030043
{
    public partial class userPanel : Form
    {
        public userPanel()
        {
            InitializeComponent();
        }
        int toplam = 0;
        int filtrekahve = 0;
        int latte = 0;
        int americano = 0;
        int espresso = 0;

        //int latteToplam = 0;
        //int filtreToplam = 0;
        //int espressoToplam = 0;
        //int americanoToplam = 0; // NOT :buraya daha sonra bakacam fiyatlandırmalar hatalıydı

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (latte > 0)
        //    {
        //        latte--;
        //        textBox4.Text = latte.ToString();
        //        toplam -= 8;
        //        textBox5.Text = toplam.ToString();
        //    }
        //    else MessageBox.Show(".");

        //}

        private void button11_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font baslıkfont = new Font("Arials", 20, FontStyle.Bold);
            Brush brush = Brushes.Red;
            Point point = new Point(100, 100);
            e.Graphics.DrawString("***************** FATURA BİLGİSİ ****************", baslıkfont, brush, point);

            Font baslıkfont2 = new Font("Times New Roman", 15, FontStyle.Bold);
            Brush brush2 = Brushes.Black;
            Point point2 = new Point(100, 300);
            e.Graphics.DrawString(richTextBox1.Text, baslıkfont2, brush2, point2);
        }

        

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ürün adı        Adet          Fiyatı(TL) \n";
            checkBox1.Checked = false;           
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            latte = 0;
            filtrekahve = 0;
            espresso = 0;
            americano = 0;
            toplam = 0;
            
            textBox1.Text = filtrekahve.ToString();
            textBox2.Text = americano.ToString();
            textBox3.Text = espresso.ToString();
            textBox4.Text = latte.ToString();
            textBox5.Text = toplam.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            espresso++;
            textBox3.Text = espresso.ToString();
            toplam += 6;
          //  espressoToplam = espressoToplam + 6; // NOT :buraya kafa yorucam unutma
            
            textBox5.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            latte++;
            textBox4.Text = latte.ToString();
            toplam += 8;
          // latteToplam = latteToplam + 8;
            textBox5.Text = toplam.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e) // FİLTRE KAHVE AZALTMA
        {
            if (filtrekahve > 0)
            {
                filtrekahve--;
                textBox1.Text = filtrekahve.ToString();
                 toplam -= 2;
                //filtreToplam = toplam - filtrekahve;
                textBox5.Text = toplam.ToString();
            }
            else MessageBox.Show("Filtre Kahve miktarı 0'dan küçük olamaz.");
        }

        private void button8_Click(object sender, EventArgs e) // FİLTRE KAHVE ARTTIRMA
        {
            filtrekahve++;
            textBox1.Text = filtrekahve.ToString();
            toplam += 2;                                          
            textBox5.Text = toplam.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            americano++;
            textBox2.Text = americano.ToString();
            toplam += 4;
           // americanoToplam = americanoToplam + 4;
            textBox5.Text = toplam.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (americano > 0)
            {
                americano--;
                textBox2.Text = americano.ToString();
                toplam -= 4;
               // americanoToplam = (americanoToplam - 4);
                textBox5.Text = toplam.ToString();
            }
            else MessageBox.Show("Americano miktarı 0'dan küçük olamaz.");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (espresso > 0)
            {
                espresso--;
                textBox3.Text = espresso.ToString();
                toplam -= 6;
               // espressoToplam = (espressoToplam - 6);
                textBox5.Text = toplam.ToString();
            }
            else MessageBox.Show("Espresso miktarı 0'dan küçük olamaz.");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (latte > 0)
            {
                latte--;
                textBox4.Text = latte.ToString();
                toplam -= 8;
               // latteToplam = (latteToplam - 8);
                textBox5.Text = toplam.ToString();
            }
            else MessageBox.Show("Latte miktarı 0'dan küçük olamaz.");
        }

        private void userPanel_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ürün adı       Adet          Fiyatı(TL) \n";
        }  //NOT: yazı kaymaları için boşluk miktarları = 4 boşluk + 2 boşluk + eksi 3 boşluk + 1 boşluk 

        private void button9_Click(object sender, EventArgs e)
        {
            int filtreKF = 2;
            int americanoF = 4;
            int espressoF = 6;
            int latteF = 8;


            if (checkBox1.Checked && textBox1.Text != "0")
            {
                richTextBox1.Text +=

                    label3.Text + "       " + filtrekahve.ToString() + "          " + (filtrekahve * filtreKF).ToString() + "\n";
            }
            if (checkBox2.Checked && textBox2.Text != "0") // label4
            {
                richTextBox1.Text +=

                    label4.Text + "       " + americano.ToString() + "          " + (americano * americanoF).ToString() + "\n";
            }
            if (checkBox3.Checked && textBox3.Text != "0")
            {
                richTextBox1.Text +=

                    label5.Text + "       " + espresso.ToString() + "          " + (espresso * espressoF).ToString() + "\n";
            }
            if (checkBox4.Checked && textBox4.Text != "0")
            {
                richTextBox1.Text +=

                    label6.Text + "       " + latte.ToString() + "          " + (latte * latteF).ToString() + "\n";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
