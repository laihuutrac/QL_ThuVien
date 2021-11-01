using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_QLTV
{
    public partial class Form_chinh : Form
    {
        public Form_chinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form_LapThe();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form_MuonTraSach();
            frm.ShowDialog();
        }

        private void nhậnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form_NhanSach();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
