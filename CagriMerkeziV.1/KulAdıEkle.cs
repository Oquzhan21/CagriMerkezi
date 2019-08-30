using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CagriMerkeziV._1
{
    public partial class KulAdıEkle : Form
    {
        SqlConnection cnn = new SqlConnection("Server=.; Database=CagriMerkez; trusted_connection=true");
        public KulAdıEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Giris(Kullaniciadi,Sifre,KullaniciId,Yetki) values(@kad,@sifre,@Kid,@yetki)", cnn);
                    cmd.Parameters.AddWithValue("@kad", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@sifre", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Kid", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@yetki","Çalışan");
                    cmd.ExecuteNonQuery();
                    cnn.Close();


                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu" + hata.Message);
            }
        }

        private void KulAdıEkle_Load(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT ID FROM Calisan";
            komut.Connection = cnn;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ID"]);
            }
            cnn.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
