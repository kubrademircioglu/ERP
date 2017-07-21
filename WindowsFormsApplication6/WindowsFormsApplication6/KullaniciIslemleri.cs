using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace WindowsFormsApplication6
{
    class KullaniciIslemleri
    {
        public string PFirmaEkle(string firma_adi, string telefon, string fax, string eposta, string adres, string firma_tipi, string il, string departman)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_FIRMA_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_FIRMA_ADI", OracleDbType.Varchar2, 20).Value = firma_adi;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_FAX", OracleDbType.Varchar2, 20).Value = fax;
               
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;
                command.Parameters.Add("@P_FIRMA_TIPI", OracleDbType.Varchar2, 20).Value = firma_tipi;

                command.Parameters.Add("@P_IL", OracleDbType.Varchar2, 20).Value = il;
                command.Parameters.Add("@P_DEPARTMAN", OracleDbType.Varchar2, 20).Value = departman;
               











                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
        public string PFirmaSil(int userid)
        {
            string sonuc;

            OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

            OracleCommand command = new OracleCommand("PROC_FIRMA_SIL", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            sonuc = "Silme İşlemi Başarılı";



            return sonuc;
        }
        public string PKisiSil(int userid)
        {
            string sonuc;

            OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

            OracleCommand command = new OracleCommand("PROC_KISI_SIL", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            sonuc = "Silme İşlemi Başarılı";



            return sonuc;
        }
        public string PKisiEkle(string ad, string soyad, string sehir, string gorev, string telefon,string eposta, string adres, string gorus_bilgi, string gorus_kisi, string islem, int firma_id,string firma_adı)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_KISI_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_SEHIR", OracleDbType.Varchar2, 20).Value = sehir;
                command.Parameters.Add("@P_GOREV", OracleDbType.Varchar2, 20).Value = gorev;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
               
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;
                command.Parameters.Add("@P_GORUS_BILGI", OracleDbType.Varchar2, 20).Value = gorus_bilgi;
                command.Parameters.Add("@P_GORUS_KISI", OracleDbType.Varchar2, 20).Value = gorus_kisi;
                command.Parameters.Add("@P_ISLEM", OracleDbType.Varchar2, 20).Value = islem;

                command.Parameters.Add("@P_FIRMAID", OracleDbType.Int32).Value = firma_id;
                command.Parameters.Add("@P_FIRMA_ADI", OracleDbType.Varchar2, 20).Value = islem;
                









                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
        public string PProjeEkle(string ad, string bilgi, string katilimci, string maaliyet,  int kisi_id)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_PROJE_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_BILGI", OracleDbType.Varchar2, 20).Value = bilgi;
                command.Parameters.Add("@P_KATILIMCI", OracleDbType.Varchar2, 20).Value = katilimci;
                command.Parameters.Add("@P_MAALIYET", OracleDbType.Varchar2, 20).Value = maaliyet;
                

                command.Parameters.Add("@P_KISI_ID", OracleDbType.Int32).Value = kisi_id;
                








                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
        public string PMaaliyetEkle(string butce, string kayitlar, string bilgi, string rezervasyon, string planlama, string aysonu, string yilsonu, int proje_id,string proje_ad)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_MAALIYET_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_BUTCE", OracleDbType.Varchar2, 20).Value = butce;
                command.Parameters.Add("@P_KAYITLAR", OracleDbType.Varchar2, 20).Value = kayitlar;
                command.Parameters.Add("@P_BILGI", OracleDbType.Varchar2, 20).Value = bilgi;
                command.Parameters.Add("@P_REZERVASYON", OracleDbType.Varchar2, 20).Value = rezervasyon;
                 command.Parameters.Add("@P_PLANLAMA", OracleDbType.Varchar2, 20).Value = planlama;
                 command.Parameters.Add("@P_AYSONU", OracleDbType.Varchar2, 20).Value = aysonu;
                 command.Parameters.Add("@P_YILSONU", OracleDbType.Varchar2, 20).Value = yilsonu;


                command.Parameters.Add("@P_PROJE_ID", OracleDbType.Int32).Value = proje_id;
                 command.Parameters.Add("@P_PROJE_ADI", OracleDbType.Varchar2, 20).Value = proje_ad;










                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
        public string PPlanEkle(string proje_adi, string baslangic, string bitis, string risk, string onlem)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_PLAN_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_PROJE_ADI", OracleDbType.Varchar2, 20).Value = proje_adi;
                command.Parameters.Add("@P_BASLANGICTARIHI", OracleDbType.Varchar2, 20).Value = baslangic;
                command.Parameters.Add("@P_BITISTARIHI", OracleDbType.Varchar2, 20).Value = bitis;
                command.Parameters.Add("@P_RISK", OracleDbType.Varchar2, 20).Value = risk;
                command.Parameters.Add("@P_ONLEM", OracleDbType.Varchar2, 20).Value = onlem;
                









                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
        public string PIlerlemeEkle(string buguntarih, string analiz, string teyit, string bilgi, int plan_id)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_PLAN_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_BUGUNTARIH", OracleDbType.Varchar2, 20).Value = buguntarih;
                command.Parameters.Add("@P_ANALIZ", OracleDbType.Varchar2, 20).Value = analiz;
                command.Parameters.Add("@P_TEYIT", OracleDbType.Varchar2, 20).Value = teyit;
                command.Parameters.Add("@P_BILGI", OracleDbType.Varchar2, 20).Value = bilgi;
                command.Parameters.Add("@P_PLAN_ID", OracleDbType.Int32).Value = plan_id;








                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
        public string MalzmeyonetimEkle(string proje_ad, string rezervasyon, string planlama)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_MYONETIM_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_PROJE_ADI", OracleDbType.Varchar2, 20).Value = proje_ad;
                command.Parameters.Add("@P_REZERVASYON", OracleDbType.Varchar2, 20).Value = rezervasyon;
                command.Parameters.Add("@P_PLANLAMA", OracleDbType.Varchar2, 20).Value = planlama;
               






                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
        public string Dokumanekle(string proje_metinleri, string urun_agaclari, string sikayetler, string genel_bildirimler, int malzeme_id,string kayitlar)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_DOKUMAN_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_PROJE_METINLERI", OracleDbType.Varchar2, 20).Value = proje_metinleri;
                command.Parameters.Add("@P_URUN_AGACLARI", OracleDbType.Varchar2, 20).Value = urun_agaclari;
                command.Parameters.Add("@P_SIKAYETLER", OracleDbType.Varchar2, 20).Value = sikayetler;
                command.Parameters.Add("@P_GENEL_BILDIRIMLER", OracleDbType.Varchar2, 20).Value = genel_bildirimler;


                command.Parameters.Add("@P_MALZEME_ID", OracleDbType.Int32).Value = malzeme_id;

                command.Parameters.Add("@P_KAYITLAR", OracleDbType.Varchar2, 20).Value = kayitlar;








                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
    }
}
