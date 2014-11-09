using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GiGi.BL;
using GiGi.COMMON;

namespace GiGi.UI
{
    public partial class frmTest : Form
    {

        private EmployeeBL oEmployeeBl = new EmployeeBL();
 
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            grideSource();
        }

        #region Events

        private void grideSource() 
        {
            dataGridView1.DataSource = oEmployeeBl.Select();
            dataGridView1.BindingContext = this.BindingContext;
        }

        #endregion Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isAlreadyOpen = false;
            foreach (Form myForm in Application.OpenForms)
            {
                if (myForm.Text == "frmItemMaster")
                {
                    isAlreadyOpen = true;
                    myForm.WindowState = FormWindowState.Maximized;
                    myForm.Focus();
                    break;
                }
            }
            if (isAlreadyOpen == false)
            {
                GiGi.UI.frmItemMaster frmItem = new GiGi.UI.frmItemMaster();
                frmItem.MdiParent = this;
                frmItem.WindowState = FormWindowState.Maximized;
                frmItem.Show();
            }
        }
    }
}
