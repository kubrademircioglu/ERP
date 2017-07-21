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
    public partial class malzemeYonetimi : Form
    {
        public malzemeYonetimi()
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
            MessageBox.Show(kullaniciislemleri.MalzmeyonetimEkle(textBox9.Text, textBox4.Text, textBox5.Text));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            string sorgu1 = "SELECT PROJE_ID,AD FROM TB_PROJELERIM WHERE AD='" + textBox9.Text + "'";
            OracleCommand command = new OracleCommand(sorgu1, baglan);
            OracleDataReader oku;
            baglan.Open();
            oku = command.ExecuteReader();

            while (oku.Read())
            {
                textBox8.Text = oku["PROJE_ID"].ToString();


            }
        }

        private void malzemeYonetimi_Load(object sender, EventArgs e)
        {
            textBox8.Visible=false;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
        dokuman DOKUMAN = new dokuman();

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DOKUMAN.Show();
        }
    }
}
