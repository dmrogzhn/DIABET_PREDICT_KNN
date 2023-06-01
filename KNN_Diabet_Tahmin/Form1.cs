using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;// buraya python exe dosyasının exe yolunu ekledi
using System.Globalization;

namespace KNN_Diabet_Tahmin 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection connenction = new SqlConnection("Data Source=DESKTOP-S3S5IBG\\SQLEXPRESS;Initial Catalog=diabet_predict_KNN;User ID=sa;Password=s");

        public void pyCalistir()
        {

            //var process = new Process();
            //process.StartInfo.FileName = "D:\\PAÜ DERS\\3. Sınıf\\3.Sınıf 2. Dönem\\Yazılım Mühendisliği\\KNN diabet hastalık tahmini\\dist\\diabet_learned_model.exe";
            //process.StartInfo.Arguments = "D:\\PAÜ DERS\\3. Sınıf\\3.Sınıf 2. Dönem\\Yazılım Mühendisliği\\KNN diabet hastalık tahmini\\diabet_learned_model.py";
            //process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.UseShellExecute = false;
            //process.Start();
            //string output = process.StandardOutput.ReadToEnd();// aslında bundan sornasına gerek kalmayabilir ama biz garanti olsun diye tutalım burada. bundan sonraki kodalar pythondaki çıktıyı almak için var ama bizim projemizde bir çıktı yok. sadece sql e ekliyor ve alıyor
            //process.WaitForExit();
            //Console.WriteLine(output);

            //MessageBox.Show("Bağlantı gerçekleşti python çalıştırıldı");


            var path = @"D:\diabet_learned_model.py";
            var info = new ProcessStartInfo("python")
            {
                Arguments = path,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };
            var process = new Process();
            process.StartInfo = info;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            //Console.WriteLine(output);
            //MessageBox.Show(output);
            string err = process.StandardError.ReadToEnd();
            //Console.WriteLine(err);
            //MessageBox.Show(err);
            process.WaitForExit();

        }
        
        public void kisiEkle()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            //MessageBox.Show(ad);

            SqlCommand sqlCommand = new SqlCommand($"exec kisiEkle "+ad+","+soyad,connenction);
            sqlCommand.ExecuteNonQuery();

        }

        // BURADA KİŞİ TABLOSUNDAN SON KİŞİNİN ID SİNİ ALIP BURAYA EKLEMEMİZ GEREKİYOR ONA DİKKAT ET
        public void veriEkle()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT personID FROM person WHERE personID = (SELECT MAX(personID) FROM person)",connenction);// bu kod person tablosundaki en büyük ıd yi alıyor ve sadece bana ıd yi getiriyor o da doğal olarak son kişinin id si olmuş oluyor
            /*
             SqlCommand sqlCommand = new SqlCommand("SELECT personID FROM person ORDER BY personID DESC",connenction); 
             tabloyu tersten alıp sadece ıd leri getiriyor
             bu kod normalde bütün id leri getiriyor ama sen liste olarak değil de sadece int deyip değeri almaya çalışırsan da sana ilk satırı getirdiği için gene istediğin tek değeri almış oluyorsun
            */        
                       
            int kisiID = (int)sqlCommand.ExecuteScalar();
            int pregnancies = Convert.ToInt32(txtPregnancies.Text);
            int glucose = Convert.ToInt32(txtGlucose.Text);
            int bloodP = Convert.ToInt32(txtBloodP.Text);
            int skinT = Convert.ToInt32(txtSkinT.Text);
            int insulin = Convert.ToInt32(txtInsulin.Text);
            int bmi = Convert.ToInt32(txtBMI.Text);
            int diabetPF = Convert.ToInt32(txtDiabetPF.Text);
            int age = Convert.ToInt32(txtAge.Text);


            SqlCommand sqlCommand2 = new SqlCommand($"exec veriEkle {kisiID},{pregnancies},{glucose},{bloodP},{skinT},{insulin},{bmi},{diabetPF},{age}", connenction);
            sqlCommand2.ExecuteNonQuery();
            sqlCommand.ExecuteNonQuery();
        }

       

        public string sonucGetir()
        {

            SqlCommand sqlCommand = new SqlCommand("SELECT Description FROM hasta_sonuc order by personID desc", connenction);
            string sonuc = (string)sqlCommand.ExecuteScalar();
            MessageBox.Show("Verilenize göre sonucunuz: "+sonuc);
            MessageBox.Show("Sonuçlarımız sadece tahmin amaçlı olup, erken tedaviyi amaçlamaktadır. Kesinlik içermez!!");
            return sonuc;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            connenction.Open();
            
            /* SIRALAMA BU ŞEKİLDE OLACAK
             kisiEkle();
             veriEkle();
             pyCalistir();
             sonucGetir();
             */

            kisiEkle();
            veriEkle();
            pyCalistir();
            sonucGetir();
           
            connenction.Close();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
