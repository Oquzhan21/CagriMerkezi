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
    public partial class CalisanSil : Form
    {
        SqlConnection cnn = new SqlConnection("Server=.; Database=CagriMerkez; trusted_connection=true");
        public CalisanSil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("delete from Calisan where Tc='" + textBox1.Text.Trim() + "'", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
