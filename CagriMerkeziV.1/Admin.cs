using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CagriMerkeziV._1
{
    public partial class Admin : Form
    {
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        public Admin()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hakkımızda!!");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void çALIŞANSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisanSil frmcalisan = new CalisanSil();
            frmcalisan.Show();
        }

        private void yAZDIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazdirSayfasi frmy = new YazdirSayfasi();
            frmy.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            


        }

        private void çALIŞANLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void çALIŞANEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisanEkle clsfrm = new CalisanEkle();
            clsfrm.Show();
        }
    }
}
