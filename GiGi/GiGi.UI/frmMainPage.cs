using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiGi.UI
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
            tmr1.Start();
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.btnClose.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 48, 1);
            this.monthCalendar1.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 235, 95);
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabelClock.Alignment = ToolStripItemAlignment.Right;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width /2, 4);
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemMasterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmItemMaster frmItemMaster = new frmItemMaster();
            frmItemMaster.MdiParent = this;
            frmItemMaster.Show();
        }

        private void goodsIssueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGoodsIssue frmGoodsIssue = new frmGoodsIssue();
            frmGoodsIssue.MdiParent = this;
            frmGoodsIssue.Show();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.toolStripStatusLabelClock.Text = time.ToString("h:mm:ss tt");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmItemMaster frmItemMaster = new frmItemMaster();
            frmItemMaster.MdiParent = this;
            frmItemMaster.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmGoodsIssue frmGoodsIssue = new frmGoodsIssue();
            frmGoodsIssue.MdiParent = this;
            frmGoodsIssue.Show();

        }



    }
}
