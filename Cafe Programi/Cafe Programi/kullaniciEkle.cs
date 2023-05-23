using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace salihDoguz211030043
{
    public partial class kullaniciEkle : Form
    {
        public kullaniciEkle()
        {
            InitializeComponent();
        }
        void Goster()
        {
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"users.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"users.xml");
            x.Element("users").Add(
                new XElement("kullanıcılar",
                new XElement("ıd", textBox1.Text),
                new XElement("kadı", textBox2.Text),
                new XElement("sifre", textBox3.Text)
                ));
            x.Save(@"users.xml");
            Goster();
        }

        private void kullaniciEkle_Load(object sender, EventArgs e)
        {
            Goster();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanel fr = new adminPanel();
            fr.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
