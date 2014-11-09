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
    public partial class frmFactoryProduction : Form
    {
        styles objStyles;

        public frmFactoryProduction()
        {
            InitializeComponent();
            #region styles
            objStyles = new styles();
            this.btnFProductNew.MouseEnter += new EventHandler(objStyles.btnNewHover);
            this.btnFProductNew.MouseLeave += new EventHandler(objStyles.btnNewLeave);
            this.btnFProductDone.MouseEnter += new EventHandler(objStyles.btnDoneHover);
            this.btnFProductDone.MouseLeave += new EventHandler(objStyles.btnDoneLeave);
            this.btnFProductUpdate.MouseEnter += new EventHandler(objStyles.btnUpdateHover);
            this.btnFProductUpdate.MouseLeave += new EventHandler(objStyles.btnUpdateLeave);
            this.btnFProductDelete.MouseEnter += new EventHandler(objStyles.btnDeleteHover);
            this.btnFProductDelete.MouseLeave += new EventHandler(objStyles.btnDeleteLeave);
            this.btnFProductSave.MouseEnter += new EventHandler(objStyles.btnSaveHover);
            this.btnFProductSave.MouseLeave += new EventHandler(objStyles.btnSaveLeave);
            this.TxtBoxFGNnoFP.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.TxtBoxFGNnoFP.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            this.TxtBoxRefNoFP.GotFocus += new EventHandler(objStyles.textBoxGotFocus);
            this.TxtBoxRefNoFP.LostFocus += new EventHandler(objStyles.textBoxLostFocus);
            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
