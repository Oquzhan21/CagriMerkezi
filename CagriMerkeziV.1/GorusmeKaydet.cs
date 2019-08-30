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
    public partial class GorusmeKaydet : Form
    {
        SqlConnection cnn = new SqlConnection("Server=.; Database=CagriMerkez; trusted_connection=true");
        public GorusmeKaydet()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("insert into GorusmeKaydi(ArananKisi,ArananNo,GorusmeNotu,GorusmeTar,ErtelemeTar,GorusmeDurumu) values(@aranankisi,@arananno,@gorusmenotu,@gorusmetar,@ertelemetar,@gorusmedurumu)", cnn);
                    cmd.Parameters.AddWithValue("@aranankisi", txtAranan.Text.Trim());
                    cmd.Parameters.AddWithValue("@gorusmenotu", txtGorusmeNotu.Text.Trim());
                    cmd.Parameters.AddWithValue("@gorusmetar", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@ertelemetar", dateTimePicker2.Value);
                    string gorusmedurum = "";
                    if (radioButton1.Checked)
                    {
                        gorusmedurum = radioButton1.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        gorusmedurum = radioButton2.Text;
                    }
                    cmd.Parameters.AddWithValue("@gorusmedurumu", gorusmedurum);

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
