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
using System.Xml.Linq;

namespace salihDoguz211030043
{
    public partial class urunGuncelle : Form
    {
        public urunGuncelle()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath + @"\urunler.xml";
        private void urunGuncelle_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNodeList kayitlar = root.SelectNodes("/urunler/urun");

            foreach (XmlNode secilen in kayitlar)
            {
                comboBox1.Items.Add(secilen["urunadı"].InnerText + " ID = "+secilen["ıd"].InnerText);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument docx = XDocument.Load(@"urunler.xml");
            XElement node = docx.Element("urunler").Elements("urun").FirstOrDefault(a => a.Element("ıd").Value.Trim() == textBox1.Text);
            if (node != null)
            {
                node.SetElementValue("fiyat", textBox2.Text);
                docx.Save(@"urunler.xml");
                MessageBox.Show("Başarıyla Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("yok");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
