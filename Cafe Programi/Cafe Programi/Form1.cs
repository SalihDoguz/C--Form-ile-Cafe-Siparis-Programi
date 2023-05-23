using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace salihDoguz211030043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        string path = Application.StartupPath + @"\admin.xml";

        string path2 = Application.StartupPath + @"\users.xml";

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            var Username = "";
            var Password = "";

            foreach (XmlNode node in xDoc.SelectNodes("admin"))
            {
                Username = node.SelectSingleNode(".//username").InnerText;
                Password = node.SelectSingleNode(".//password").InnerText;

                if (Username.Equals(textBox1.Text) && Password.Equals(textBox2.Text))
                {
                    MessageBox.Show("Admin Giriş Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminPanel a = new adminPanel();
                    a.Show();
                    this.Hide();
                }
                else MessageBox.Show("Kullanıcı adı veya şifre Hatalı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument Document = new XmlDocument();
            Document.Load(path2);
            var Username1 = "";
            var Password1 = "";

            foreach (XmlNode node in Document.SelectNodes("users"))
            {
                Username1 = node.SelectSingleNode(".//kadı").InnerText;
                Password1 = node.SelectSingleNode(".//sifre").InnerText;

                if (Username1.Equals(textBox1.Text) && Password1.Equals(textBox2.Text))
                {
                    MessageBox.Show("Üye Girişi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userPanel a = new userPanel();
                    a.Show();
                    this.Hide();
                }
                else MessageBox.Show("Kullanıcı adı veya şifre Hatalı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
