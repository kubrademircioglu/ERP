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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataSet ds;
        public OracleDataReader dr;
        public OracleDataAdapter da;
        public OracleCommand cmd;
        public DataTable dt;
        //KullaniciIslemleri kullaniciislemleri = new KullaniciIslemleri();
     
        public void dataGridKayitGoster()
        {
            string sorgu = "SELECT * FROM TB_PERSONEL";
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }
       
        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        KullaniciGirisics kullanici = new KullaniciGirisics();
        Anasayfa anasayfa = new Anasayfa();
        private void button1_Click(object sender, EventArgs e)
        {
            string sonuc = kullanici.girisYap(textBox1.Text, textBox2.Text);
            anasayfa.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
