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
    public partial class KullaniciSil : Form
    {
        public KullaniciSil()
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
            if (MessageBox.Show("SEÇİLİ KULLANICIYI SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                XDocument x = XDocument.Load(@"users.xml");
                x.Root.Elements().Where(a => a.Element("ıd").Value == textBox1.Text).Remove();
                x.Save(@"users.xml");
                Goster();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void KullaniciSil_Load(object sender, EventArgs e)
        {
            Goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanel fr2 = new adminPanel();
            fr2.Show();        
            this.Hide();
        }
    }
}
