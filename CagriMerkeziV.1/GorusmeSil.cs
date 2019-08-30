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
    public partial class GorusmeSil : Form
    {
        SqlConnection cnn = new SqlConnection("Server=.; Database=CagriMerkez; trusted_connection=true");
        public GorusmeSil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("delete from GorusmeKaydi where ArananNo='" + cmbMusteri.Text+ "'", cnn);

            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void GorusmeSil_Load(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT ArananKisi FROM GorusmeKaydi";
            komut.Connection = cnn;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbMusteri.Items.Add(dr["ArananKisi"]);
            }
            cnn.Close();

        }
    }
}
