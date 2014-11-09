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
    public partial class frmItemMaster : Form
    {
        styles objStyles;

        public frmItemMaster()
        {
            InitializeComponent();

            #region styles
            objStyles = new styles();
            this.btnItemNew.MouseEnter += new EventHandler(objStyles.btnNewHover);
            this.btnItemNew.MouseLeave += new EventHandler(objStyles.btnNewLeave);
            this.btnItemDone.MouseEnter += new EventHandler(objStyles.btnDoneHover);
            this.btnItemDone.MouseLeave += new EventHandler(objStyles.btnDoneLeave);
            this.btnItemCheck.MouseEnter += new EventHandler(objStyles.btnCheckHover);
            this.btnItemCheck.MouseLeave += new EventHandler(objStyles.btnCheckLeave);
            this.btnItemUpdate.MouseEnter += new EventHandler(objStyles.btnUpdateHover);
            this.btnItemUpdate.MouseLeave += new EventHandler(objStyles.btnUpdateLeave);
            this.btnItemDelete.MouseEnter += new EventHandler(objStyles.btnDeleteHover);
            this.btnItemDelete.MouseLeave += new EventHandler(objStyles.btnDeleteLeave);
            this.btnItemSave.MouseEnter += new EventHandler(objStyles.btnSaveHover);
            this.btnItemSave.MouseLeave += new EventHandler(objStyles.btnSaveLeave);
            this.txtItemCat.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.txtItemCat.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            this.txtItemDes.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.txtItemDes.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            this.txtItemNote.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.txtItemNote.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            this.txtItemVen.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.txtItemVen.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            this.txtUnit.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.txtUnit.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            this.cmbboxItemCode.GotFocus += new EventHandler(objStyles.cmbBoxGotFocus);
            this.cmbboxItemCode.LostFocus += new EventHandler(objStyles.cmbBoxLostFocus);
            this.cmbboxItemCodeS.GotFocus += new EventHandler(objStyles.cmbBoxGotFocus);
            this.cmbboxItemCodeS.LostFocus += new EventHandler(objStyles.cmbBoxLostFocus);
            this.WindowState = FormWindowState.Normal;

            //grid style
            styles.gridStyle(dgv1);
            styles.gridStyle(dgv2);

            this.btnStep1.MouseEnter += new EventHandler(objStyles.btnMouseEnter);
            this.btnStep2.MouseEnter += new EventHandler(objStyles.btnMouseEnter);
            this.btnStep3.MouseEnter += new EventHandler(objStyles.btnMouseEnter);

            this.lblStep1.MouseEnter += new EventHandler(objStyles.lblMouseEnter);
            this.lblStep2.MouseEnter += new EventHandler(objStyles.lblMouseEnter);
            this.lblStep3.MouseEnter += new EventHandler(objStyles.lblMouseEnter);

            #endregion

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmItemMaster_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        #region Item Master Progress

        private void btnStep1_Click(object sender, EventArgs e)
        {
            try 
            {
                ItemMasrerClass itemMaster = new ItemMasrerClass();
                itemMaster.showTab(0, this);
                itemMaster.boldCurrentStep(0, this);
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lblStep1_Click(object sender, EventArgs e)
        {
            try
            {
                ItemMasrerClass itemMaster = new ItemMasrerClass();
                itemMaster.showTab(0, this);
                itemMaster.boldCurrentStep(0, this);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void lblStep2_Click(object sender, EventArgs e)
        {
            try
            {
                ItemMasrerClass itemMaster = new ItemMasrerClass();
                itemMaster.showTab(1, this);
                itemMaster.boldCurrentStep(1, this);

            }
            catch (Exception ex) {  MessageBox.Show(ex.Message);}
        }
        private void btnStep2_Click(object sender, EventArgs e)
        {
            try
            {
                ItemMasrerClass itemMaster = new ItemMasrerClass();
                itemMaster.showTab(1, this);
                itemMaster.boldCurrentStep(1, this);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void lblStep3_Click(object sender, EventArgs e)
        {
            try
            {
                ItemMasrerClass itemMaster = new ItemMasrerClass();
                itemMaster.showTab(2, this);
                itemMaster.boldCurrentStep(2, this);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnStep3_Click(object sender, EventArgs e)
        {
            try
            {
                ItemMasrerClass itemMaster = new ItemMasrerClass();
                itemMaster.showTab(2, this);
                itemMaster.boldCurrentStep(2, this);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion Item Master Progress
    }


    public class ItemMasrerClass
    {
        public void showTab(int index,object obj)
        {
            frmItemMaster frmMaster = (frmItemMaster)obj;
            frmMaster.tabControl1.SelectTab(index);
        }

        public void boldCurrentStep(int ind, object obj)
        {
            frmItemMaster frmMaster = (frmItemMaster)obj;
            switch (ind)
            { 
                case 0 :
                    frmMaster.lblStep1.Font = new Font(frmMaster.lblStep1.Font, FontStyle.Bold);
                    frmMaster.lblStep2.Font = new Font(frmMaster.lblStep2.Font, FontStyle.Regular);
                    frmMaster.lblStep3.Font = new Font(frmMaster.lblStep3.Font, FontStyle.Regular);
                    break;
                case 1:
                    frmMaster.lblStep1.Font = new Font(frmMaster.lblStep1.Font, FontStyle.Regular);
                    frmMaster.lblStep2.Font = new Font(frmMaster.lblStep2.Font, FontStyle.Bold);
                    frmMaster.lblStep3.Font = new Font(frmMaster.lblStep3.Font, FontStyle.Regular);
                    break;
                case 2:
                    frmMaster.lblStep1.Font = new Font(frmMaster.lblStep1.Font, FontStyle.Regular);
                    frmMaster.lblStep2.Font = new Font(frmMaster.lblStep2.Font, FontStyle.Regular);
                    frmMaster.lblStep3.Font = new Font(frmMaster.lblStep3.Font, FontStyle.Bold);
                    break;
            }
        }

    }
}
