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
    public partial class CalisanEkle : Form
    {
        SqlConnection cnn = new SqlConnection("Server=.; Database=CagriMerkez; trusted_connection=true");
        public CalisanEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Calisan(Ad,Soyad,mail,DogumTar,Numara,Tc) values(@ad,@soyad,@mail,@Dogumtar,@numara,@tc)", cnn);
                    cmd.Parameters.AddWithValue("@ad", txtCalisanAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@soyad", txtCalisanSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@mail", txtCalisanMail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Dogumtar", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@numara", txtCalisanNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@tc", txtCalisanTc.Text.Trim());
                    cmd.ExecuteNonQuery();
                    cnn.Close();


                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu" + hata.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KulAdıEkle klefrm = new KulAdıEkle();
            klefrm.Show();
            this.Hide();
        }
    }
    }

