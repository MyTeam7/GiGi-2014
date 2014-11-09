using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GiGi.UI.Styles
{
    public class styles
    {
        #region Form Style
        public void textBoxGotFocus(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        }
        public void textBoxLostFocus(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }
        public void cmbBoxGotFocus(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        }
        public void cmbBoxLostFocus(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }
        public void drpBoxGotFocus(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            listbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        }
        public void drpBoxLostFocus(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            listbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }
        public void btnNewHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.new_gray);
        }
        public void btnNewLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.new_black);
        }
        public void btnDoneHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.done_gray);
        }
        public void btnDoneLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.done_black);
        }
        public void btnCheckHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.check_gray);
        }
        public void btnCheckLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.check_black);
        }
        public void btnUpdateHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.update_gray);
        }
        public void btnUpdateLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.update_black);
        }
        public void btnDeleteHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.delete_gray);
        }
        public void btnDeleteLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.delete_black);
        }
        public void btnSaveHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.save_gray);
        }
        public void btnSaveLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.save_black);
        }
        public void btnPrintHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.print_gray);
        }
        public void btnPrintLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = new Bitmap(GiGi.UI.Properties.Resources.print_black);
        }

        public void btnMouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Cursor = Cursors.Hand;
        }

        public void lblMouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Cursor = Cursors.Hand;
        }

        #endregion

        #region gridStyle
        public static void gridStyle(DataGridView grid)
        {
            grid.RowTemplate.Height = 23;  // set row height
            grid.RowsDefaultCellStyle.BackColor = Color.White; //backcolor of the rows
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige; // sel alternative rows color
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; //set to show only verticle lines
            grid.DefaultCellStyle.SelectionBackColor = Color.Lavender; //ackcolor when selected
            grid.DefaultCellStyle.SelectionForeColor = Color.DarkBlue; // font color when selected
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //when select one cell, also select full row
            grid.AllowUserToResizeColumns = false; // does not allow to change the size of the row and columns

            //********************** Header Style ************************* 
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        #endregion


    }
}
