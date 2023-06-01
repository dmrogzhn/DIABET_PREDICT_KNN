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

namespace KNN_Diabet_Tahmin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connenction = new SqlConnection("Data Source=DESKTOP-S3S5IBG\\SQLEXPRESS;Initial Catalog=diabet_predict_KNN;User ID=sa;Password=s");
        
        public void kayitGetir()
        {
            
            SqlDataAdapter dtp = new SqlDataAdapter("select Ad,Soyad,Description from hasta_sonuc", connenction);
            DataSet ds = new DataSet();
            dtp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];            
            
        }

        public void veriGetir()
        {
            SqlDataAdapter dtp = new SqlDataAdapter("select * from kisiVeriler", connenction);
            DataSet ds = new DataSet();
            dtp.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connenction.Open();
            kayitGetir();
            veriGetir();                   

            connenction.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
