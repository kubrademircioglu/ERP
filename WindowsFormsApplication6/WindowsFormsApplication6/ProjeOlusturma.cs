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
    public partial class ProjeOlusturma : Form
    {
        public ProjeOlusturma()
        {
            InitializeComponent();
        }
        public DataSet ds;
        public OracleDataReader dr;
        public OracleDataAdapter da;
        public OracleCommand cmd;
        public DataTable dt;
        KullaniciIslemleri kullaniciislemleri = new KullaniciIslemleri();
        public void dataGridKayitGoster()
        {
            string sorgu = "SELECT * FROM TB_PROJELERIM";
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
           // dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(kullaniciislemleri.PProjeEkle(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(textBox1.Text)));

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            string sorgu1 = "SELECT KISI_ID,AD FROM TB_KISI WHERE AD='" + textBox4.Text + "'";
            OracleCommand command = new OracleCommand(sorgu1, baglan);
            OracleDataReader oku;
            baglan.Open();
            oku = command.ExecuteReader();

            while (oku.Read())
            {
                textBox1.Text = oku["KISI_ID"].ToString();


            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void ProjeOlusturma_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;

        }
        MaliyetMuhasebesi MaliyetMuhasebesi = new MaliyetMuhasebesi();
        
     private void simpleButton4_Click(object sender, EventArgs e)
        {
            MaliyetMuhasebesi.Show();
        }

     private void textBox2_TextChanged(object sender, EventArgs e)
     {

     }

     private void simpleButton5_Click(object sender, EventArgs e)
     {
         OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
         baglan.Open();
         string sorgu = "SELECT * FROM TB_PROJELERIM";
         OracleCommand command = new OracleCommand(sorgu, baglan);
         OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
         DataSet ds = new DataSet();
         oda.Fill(ds);
         dataGridView1.DataSource = ds.Tables[0];

         baglan.Close();
         //textBox11.Text = "";
     }
    }
}
