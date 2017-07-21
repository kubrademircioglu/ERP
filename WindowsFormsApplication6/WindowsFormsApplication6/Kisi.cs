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
    public partial class Kisi : Form
    {
        public Kisi()
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
            string sorgu = "SELECT * FROM TB_KISI";
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_KISI ";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }
        
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(kullaniciislemleri.PKisiEkle(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,  textBox6.Text, textBox7.Text,textBox8.Text,textBox9.Text,textBox10.Text,Convert.ToInt32(textBox11.Text),textBox12.Text));

            dataGridKayitGoster();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Kisi_Load(object sender, EventArgs e)
        {
            textBox11.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
           
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            string sorgu1 = "SELECT FIRMAID,FIRMA_ADI FROM TB_FIRMALAR WHERE FIRMA_ADI='" + textBox12.Text + "'"; 
            OracleCommand command = new OracleCommand(sorgu1, baglan);
            OracleDataReader oku;
            baglan.Open();
            oku = command.ExecuteReader();

            while (oku.Read())
            {
                textBox11.Text = oku["FIRMAID"].ToString();


            }
        }
        public int userid;
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            MessageBox.Show(kullaniciislemleri.PKisiSil(userid));
            dataGridKayitGoster();
        }
        ProjeOlusturma ProjeOlusturma = new ProjeOlusturma();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ProjeOlusturma.Show();
        }

       
    }
}
