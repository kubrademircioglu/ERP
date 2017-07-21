using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApplication6
{
    public partial class ProjePlanı : Form
    {
        public ProjePlanı()
        {
            InitializeComponent();
        }
        public DataSet ds;
        public OracleDataReader dr;
        public OracleDataAdapter da;
        public OracleCommand cmd;
        public DataTable dt;
        KullaniciIslemleri kullaniciislemleri = new KullaniciIslemleri();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string donustur1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string donustur2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            MessageBox.Show(kullaniciislemleri.PPlanEkle(textBox1.Text, donustur1, donustur2, richTextBox1.Text, richTextBox2.Text));

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }
        ilerleme ilerleme = new ilerleme();
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ilerleme.Show();
        }
    }
}
