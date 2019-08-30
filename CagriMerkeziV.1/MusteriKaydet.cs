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
    public partial class MusteriKaydet : Form
    {
        SqlConnection cnn = new SqlConnection("Server=.; Database=CagriMerkez; trusted_connection=true");
        public MusteriKaydet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMusKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Musteri(MusteriAdi,MusteriSoyadi,MusteriNumarasi,MusteriProblemi) values(@Madi,@Msoyadi,@Mnumarasi,@Mproblemi)", cnn);
                    cmd.Parameters.AddWithValue("@Madi", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Msoyadi", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mnumarasi", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mproblemi", textBox4.Text.Trim());
              

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

