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
    public partial class ilerleme : Form
    {
        public ilerleme()
        {
            InitializeComponent();
        }
        public DataSet ds;
        public OracleDataReader dr;
        public OracleDataAdapter da;
        public OracleCommand cmd;
        public DataTable dt;
        KullaniciIslemleri kullaniciislemleri = new KullaniciIslemleri();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            string sorgu1 = "SELECT PLAN_ID,PROJE_ADI,BASLANGICTARIHI,BITISTARIHI FROM TB_PROJE_PLANI WHERE PROJE_ADI='" + textBox1.Text + "'";
            OracleCommand command = new OracleCommand(sorgu1, baglan);
            OracleDataReader oku;
            baglan.Open();
            oku = command.ExecuteReader();

            while (oku.Read())
            {
                textBox6.Text = oku["PLAN_ID"].ToString();
                dateTimePicker2.Text = oku["BASLANGICTARIHI"].ToString();
                dateTimePicker3.Text = oku["BITISTARIHI"].ToString();


            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string donustur = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            MessageBox.Show(kullaniciislemleri.PIlerlemeEkle(donustur, textBox4.Text, comboBox1.Text, textBox5.Text, Convert.ToInt32(textBox6.Text)));
            textBox4.Text = "";
            textBox5.Text = "";
            //textBox6.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
        }

        private void ilerleme_Load(object sender, EventArgs e)
        {
            textBox6.Visible = false;
            //textBox2.Enabled = false;
            //textBox3.Enabled = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox6.Visible = false;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime bTarih = Convert.ToDateTime(dateTimePicker2.Text);
            int Btay = bTarih.Month;
            DateTime kTarih = Convert.ToDateTime(dateTimePicker3.Text);
            int Ktay = bTarih.Month;
            TimeSpan Sonuc = kTarih - bTarih;
            textBox2.Text = Sonuc.TotalDays.ToString();
           

            
            DateTime bugunTarih = Convert.ToDateTime(dateTimePicker1.Text);
            int Buguntay = bugunTarih.Month;
            TimeSpan analiz = bugunTarih - bTarih;// bugunun tarıhle baslangıc tarıhımı cıkarttım
            textBox3.Text = analiz.TotalDays.ToString();


           int yuzde = (100 * Convert.ToInt32(textBox3.Text) / Convert.ToInt32(textBox2.Text));
           textBox4.Text = yuzde.ToString();
        }
        malzemeYonetimi malzemeYonetimi = new malzemeYonetimi();

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            malzemeYonetimi.Show();
        }
    }
}
