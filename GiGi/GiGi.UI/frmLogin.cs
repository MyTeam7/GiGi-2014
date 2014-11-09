using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GiGi.UI.Styles;

namespace GiGi.UI
{
    public partial class frmLogin : Form
    {
        styles objStyles;

        public frmLogin()
        {
            InitializeComponent();
            #region styles
            objStyles = new styles();
            this.txtUsername.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.txtPassword.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.txtUsername.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            this.txtPassword.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            #endregion
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //frmHome homeform = new frmHome();
            //homeform.Show();

            frmMainPage mainpage = new frmMainPage();
            mainpage.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
