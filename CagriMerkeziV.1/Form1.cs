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
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection("Server=.; Database=CagriMerkez; trusted_connection=true");
        Admin frm1 = new Admin();
        Personel frm2 = new Personel();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select Yetki from Giris where KullaniciAdi='" + txtKulAdi.Text.Trim() + "'AND Sifre='" + txtSifre.Text.Trim() + "'", cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (dr["Yetki"].ToString()=="Yönetici")
                {
                    frm1.Show();
                    this.Hide();
                }
                else
                {
                    frm2.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                cnn.Close();
            }
        }
    }
}
