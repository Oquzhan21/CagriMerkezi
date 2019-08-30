using Microsoft.Office.Interop.Excel;
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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace CagriMerkeziV._1
{
    public partial class Personel : Form
    {
        SqlConnection cnn = new SqlConnection("Server=.; Database=CagriMerkez; trusted_connection=true");
        public Personel()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eXCELLEAKTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int baslamakolonu = 1;
            int baslamasatiri = 1;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range myRange = (Range)sheet1.Cells[baslamasatiri, baslamakolonu + i];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            baslamasatiri++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[baslamasatiri + i, baslamasatiri + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                }
            }
        }

        private void mÜŞTERİLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Musteri", cnn);
            DataSet dt = new DataSet();
            da.Fill(dt, "Musteri");
            dataGridView1.DataSource = dt.Tables["Musteri"];
            da.Dispose();
            cnn.Close();
        }

        private void lİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from GorusmeKaydi", cnn);
            DataSet dt = new DataSet();
            da.Fill(dt, "GorusmeKaydi");
            dataGridView1.DataSource = dt.Tables["GorusmeKaydi"];
            da.Dispose();
            cnn.Close();
        }

        private void yAPILANLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Gorev where YapilmaDurumu='YAPILDI'", cnn);
            DataSet dt = new DataSet();
            da.Fill(dt, "Gorev");
            dataGridView1.DataSource = dt.Tables["Gorev"];
            da.Dispose();
            cnn.Close();
        }

        private void yAPILMAYANLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Gorev where YapilmaDurumu='YAPILMADI'", cnn);
            DataSet dt = new DataSet();
            da.Fill(dt, "Gorev");
            dataGridView1.DataSource = dt.Tables["Gorev"];
            da.Dispose();
            cnn.Close();
        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorusmeKaydet frmK = new GorusmeKaydet();
            frmK.Show();
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorusmeSil sil = new GorusmeSil();
            sil.Show();
        }

        private void gÖRÜŞMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
