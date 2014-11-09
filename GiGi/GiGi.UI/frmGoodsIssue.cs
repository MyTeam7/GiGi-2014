using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GiGi.UI.Styles;
using System.Runtime.InteropServices;

namespace GiGi.UI
{
    public partial class frmGoodsIssue : Form
    {
        styles objStyles;

        public frmGoodsIssue()
        {
            InitializeComponent();
            #region styles
            objStyles = new styles();
            this.btnGdsNew.MouseEnter += new EventHandler(objStyles.btnNewHover);
            this.btnGdsNew.MouseLeave += new EventHandler(objStyles.btnNewLeave);
            this.btnGdsSave.MouseEnter += new EventHandler(objStyles.btnSaveHover);
            this.btnGdsSave.MouseLeave += new EventHandler(objStyles.btnSaveLeave);
            this.btnGdsPrint.MouseEnter += new EventHandler(objStyles.btnPrintHover);
            this.btnGdsPrint.MouseLeave += new EventHandler(objStyles.btnPrintLeave);
            this.txtBoxGdsRemark.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.txtBoxGdsRemark.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            this.txtRefNo.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.txtRefNo.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            this.DrpBoxGdsFrom.GotFocus += new EventHandler(objStyles.drpBoxGotFocus);
            this.DrpBoxGdsFrom.LostFocus += new EventHandler(objStyles.drpBoxLostFocus);
            this.DrpBoxGdsTo.GotFocus += new EventHandler(objStyles.drpBoxGotFocus);
            this.DrpBoxGdsTo.LostFocus += new EventHandler(objStyles.drpBoxLostFocus);
            this.WindowState = FormWindowState.Normal;
            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmGoodsIssue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
