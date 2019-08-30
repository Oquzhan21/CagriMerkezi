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
    public partial class GorevEkle : Form
    {
        SqlConnection cnn = new SqlConnection("Server=.; Database=CagriMerkez; trusted_connection=true");
        public GorevEkle()
        {
            InitializeComponent();
        }

        private void GorevEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Gorev(GorevAdi,GorevDetay,GorevSahibiID,YapilacakSTarih,YapilmaDurumu) values(@adi,@detayi,@id,@starih,@durumu)", cnn);
                    cmd.Parameters.AddWithValue("@adi", txtGrvAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@detayi", txtGrvDetay.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());
                    cmd.Parameters.AddWithValue("@starih", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@durumu", textBox1.Text.Trim());
                    cmd.ExecuteNonQuery();
                    cnn.Close();


                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu" + hata.Message);
            }
        }
    }
    }

