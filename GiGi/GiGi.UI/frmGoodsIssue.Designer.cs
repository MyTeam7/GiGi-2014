namespace GiGi.UI
{
    partial class frmGoodsIssue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsIssue));
            this.label7 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGdsNew = new System.Windows.Forms.Button();
            this.btnGdsPrint = new System.Windows.Forms.Button();
            this.btnGdsSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DrpBoxGdsFrom = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DrpBoxGdsTo = new System.Windows.Forms.ListBox();
            this.Remark = new System.Windows.Forms.Label();
            this.txtBoxGdsRemark = new System.Windows.Forms.TextBox();
            this.dgvGI1 = new System.Windows.Forms.DataGridView();
            this.DataGridGdsItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridGdsS_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGI2 = new System.Windows.Forms.DataGridView();
            this.DataGrid2GdsItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsS4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsS5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsS6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsS7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsS8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsS9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsS10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsS11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsS12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid2GdsSellP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGI2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Good Issue";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::GiGi.UI.Properties.Resources.minimize_window;
            this.btnMinimize.Location = new System.Drawing.Point(845, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 23);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximize.Enabled = false;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::GiGi.UI.Properties.Resources.maximize_window;
            this.btnMaximize.Location = new System.Drawing.Point(890, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 23);
            this.btnMaximize.TabIndex = 12;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GiGi.UI.Properties.Resources.img_close;
            this.btnClose.Location = new System.Drawing.Point(932, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGdsNew
            // 
            this.btnGdsNew.BackColor = System.Drawing.Color.Transparent;
            this.btnGdsNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGdsNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGdsNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGdsNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGdsNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGdsNew.Image = global::GiGi.UI.Properties.Resources.new_black;
            this.btnGdsNew.Location = new System.Drawing.Point(62, 29);
            this.btnGdsNew.Name = "btnGdsNew";
            this.btnGdsNew.Size = new System.Drawing.Size(60, 65);
            this.btnGdsNew.TabIndex = 1;
            this.btnGdsNew.UseVisualStyleBackColor = false;
            // 
            // btnGdsPrint
            // 
            this.btnGdsPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnGdsPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGdsPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGdsPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGdsPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGdsPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGdsPrint.Image = global::GiGi.UI.Properties.Resources.print_black;
            this.btnGdsPrint.Location = new System.Drawing.Point(246, 28);
            this.btnGdsPrint.Name = "btnGdsPrint";
            this.btnGdsPrint.Size = new System.Drawing.Size(60, 65);
            this.btnGdsPrint.TabIndex = 2;
            this.btnGdsPrint.Text = " ";
            this.btnGdsPrint.UseVisualStyleBackColor = false;
            // 
            // btnGdsSave
            // 
            this.btnGdsSave.BackColor = System.Drawing.Color.Transparent;
            this.btnGdsSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGdsSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGdsSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGdsSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGdsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGdsSave.Image = global::GiGi.UI.Properties.Resources.save_black;
            this.btnGdsSave.Location = new System.Drawing.Point(154, 29);
            this.btnGdsSave.Name = "btnGdsSave";
            this.btnGdsSave.Size = new System.Drawing.Size(60, 65);
            this.btnGdsSave.TabIndex = 3;
            this.btnGdsSave.Text = " ";
            this.btnGdsSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(649, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ref. No";
            // 
            // txtRefNo
            // 
            this.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.Location = new System.Drawing.Point(649, 108);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(237, 21);
            this.txtRefNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "From";
            // 
            // DrpBoxGdsFrom
            // 
            this.DrpBoxGdsFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrpBoxGdsFrom.FormattingEnabled = true;
            this.DrpBoxGdsFrom.ItemHeight = 15;
            this.DrpBoxGdsFrom.Location = new System.Drawing.Point(123, 151);
            this.DrpBoxGdsFrom.Name = "DrpBoxGdsFrom";
            this.DrpBoxGdsFrom.Size = new System.Drawing.Size(210, 19);
            this.DrpBoxGdsFrom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            // 
            // DrpBoxGdsTo
            // 
            this.DrpBoxGdsTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrpBoxGdsTo.FormattingEnabled = true;
            this.DrpBoxGdsTo.ItemHeight = 15;
            this.DrpBoxGdsTo.Location = new System.Drawing.Point(649, 151);
            this.DrpBoxGdsTo.Name = "DrpBoxGdsTo";
            this.DrpBoxGdsTo.Size = new System.Drawing.Size(237, 19);
            this.DrpBoxGdsTo.TabIndex = 8;
            // 
            // Remark
            // 
            this.Remark.AutoSize = true;
            this.Remark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remark.Location = new System.Drawing.Point(60, 184);
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(57, 15);
            this.Remark.TabIndex = 9;
            this.Remark.Text = "Remark";
            // 
            // txtBoxGdsRemark
            // 
            this.txtBoxGdsRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGdsRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGdsRemark.Location = new System.Drawing.Point(123, 182);
            this.txtBoxGdsRemark.Name = "txtBoxGdsRemark";
            this.txtBoxGdsRemark.Size = new System.Drawing.Size(763, 21);
            this.txtBoxGdsRemark.TabIndex = 10;
            // 
            // dgvGI1
            // 
            this.dgvGI1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGI1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGI1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGI1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGI1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGI1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridGdsItemCode,
            this.DataGridGdsS4,
            this.DataGridGdsS5,
            this.DataGridGdsS6,
            this.DataGridGdsS7,
            this.DataGridGdsS8,
            this.DataGridGdsS9,
            this.DataGridGdsS10,
            this.DataGridGdsS11,
            this.DataGridGdsS12,
            this.DataGridGdsQty,
            this.DataGridGdsS_Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGI1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGI1.EnableHeadersVisualStyles = false;
            this.dgvGI1.Location = new System.Drawing.Point(62, 235);
            this.dgvGI1.Name = "dgvGI1";
            this.dgvGI1.RowHeadersVisible = false;
            this.dgvGI1.Size = new System.Drawing.Size(824, 58);
            this.dgvGI1.TabIndex = 11;
            // 
            // DataGridGdsItemCode
            // 
            this.DataGridGdsItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridGdsItemCode.HeaderText = "Item Code";
            this.DataGridGdsItemCode.Name = "DataGridGdsItemCode";
            this.DataGridGdsItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DataGridGdsS4
            // 
            this.DataGridGdsS4.HeaderText = "Size 4";
            this.DataGridGdsS4.Name = "DataGridGdsS4";
            this.DataGridGdsS4.Width = 50;
            // 
            // DataGridGdsS5
            // 
            this.DataGridGdsS5.HeaderText = "Size 5";
            this.DataGridGdsS5.Name = "DataGridGdsS5";
            this.DataGridGdsS5.Width = 50;
            // 
            // DataGridGdsS6
            // 
            this.DataGridGdsS6.HeaderText = "Size 6";
            this.DataGridGdsS6.Name = "DataGridGdsS6";
            this.DataGridGdsS6.Width = 50;
            // 
            // DataGridGdsS7
            // 
            this.DataGridGdsS7.HeaderText = "Size 7";
            this.DataGridGdsS7.Name = "DataGridGdsS7";
            this.DataGridGdsS7.Width = 50;
            // 
            // DataGridGdsS8
            // 
            this.DataGridGdsS8.HeaderText = "Size 8";
            this.DataGridGdsS8.Name = "DataGridGdsS8";
            this.DataGridGdsS8.Width = 50;
            // 
            // DataGridGdsS9
            // 
            this.DataGridGdsS9.HeaderText = "Size 9";
            this.DataGridGdsS9.Name = "DataGridGdsS9";
            this.DataGridGdsS9.Width = 50;
            // 
            // DataGridGdsS10
            // 
            this.DataGridGdsS10.HeaderText = "Size 10";
            this.DataGridGdsS10.Name = "DataGridGdsS10";
            this.DataGridGdsS10.Width = 50;
            // 
            // DataGridGdsS11
            // 
            this.DataGridGdsS11.HeaderText = "Size 11";
            this.DataGridGdsS11.Name = "DataGridGdsS11";
            this.DataGridGdsS11.Width = 50;
            // 
            // DataGridGdsS12
            // 
            this.DataGridGdsS12.HeaderText = "Size 12";
            this.DataGridGdsS12.Name = "DataGridGdsS12";
            this.DataGridGdsS12.Width = 50;
            // 
            // DataGridGdsQty
            // 
            this.DataGridGdsQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridGdsQty.HeaderText = "Qty";
            this.DataGridGdsQty.Name = "DataGridGdsQty";
            this.DataGridGdsQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DataGridGdsS_Price
            // 
            this.DataGridGdsS_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridGdsS_Price.HeaderText = "Selling Price";
            this.DataGridGdsS_Price.Name = "DataGridGdsS_Price";
            this.DataGridGdsS_Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvGI2
            // 
            this.dgvGI2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGI2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGI2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGI2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGI2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGI2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGrid2GdsItemCode,
            this.DataGrid2GdsS4,
            this.DataGrid2GdsS5,
            this.DataGrid2GdsS6,
            this.DataGrid2GdsS7,
            this.DataGrid2GdsS8,
            this.DataGrid2GdsS9,
            this.DataGrid2GdsS10,
            this.DataGrid2GdsS11,
            this.DataGrid2GdsS12,
            this.DataGrid2GdsQty,
            this.DataGrid2GdsSellP});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGI2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGI2.EnableHeadersVisualStyles = false;
            this.dgvGI2.Location = new System.Drawing.Point(62, 314);
            this.dgvGI2.Name = "dgvGI2";
            this.dgvGI2.RowHeadersVisible = false;
            this.dgvGI2.Size = new System.Drawing.Size(824, 325);
            this.dgvGI2.TabIndex = 11;
            // 
            // DataGrid2GdsItemCode
            // 
            this.DataGrid2GdsItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGrid2GdsItemCode.HeaderText = "Item Code";
            this.DataGrid2GdsItemCode.Name = "DataGrid2GdsItemCode";
            this.DataGrid2GdsItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DataGrid2GdsS4
            // 
            this.DataGrid2GdsS4.HeaderText = "Size 4";
            this.DataGrid2GdsS4.Name = "DataGrid2GdsS4";
            this.DataGrid2GdsS4.Width = 50;
            // 
            // DataGrid2GdsS5
            // 
            this.DataGrid2GdsS5.HeaderText = "Size 5";
            this.DataGrid2GdsS5.Name = "DataGrid2GdsS5";
            this.DataGrid2GdsS5.Width = 50;
            // 
            // DataGrid2GdsS6
            // 
            this.DataGrid2GdsS6.HeaderText = "Size 6";
            this.DataGrid2GdsS6.Name = "DataGrid2GdsS6";
            this.DataGrid2GdsS6.Width = 50;
            // 
            // DataGrid2GdsS7
            // 
            this.DataGrid2GdsS7.HeaderText = "Size 7";
            this.DataGrid2GdsS7.Name = "DataGrid2GdsS7";
            this.DataGrid2GdsS7.Width = 50;
            // 
            // DataGrid2GdsS8
            // 
            this.DataGrid2GdsS8.HeaderText = "Size 8";
            this.DataGrid2GdsS8.Name = "DataGrid2GdsS8";
            this.DataGrid2GdsS8.Width = 50;
            // 
            // DataGrid2GdsS9
            // 
            this.DataGrid2GdsS9.HeaderText = "Size 9";
            this.DataGrid2GdsS9.Name = "DataGrid2GdsS9";
            this.DataGrid2GdsS9.Width = 50;
            // 
            // DataGrid2GdsS10
            // 
            this.DataGrid2GdsS10.HeaderText = "Size 10";
            this.DataGrid2GdsS10.Name = "DataGrid2GdsS10";
            this.DataGrid2GdsS10.Width = 50;
            // 
            // DataGrid2GdsS11
            // 
            this.DataGrid2GdsS11.HeaderText = "Size 11";
            this.DataGrid2GdsS11.Name = "DataGrid2GdsS11";
            this.DataGrid2GdsS11.Width = 50;
            // 
            // DataGrid2GdsS12
            // 
            this.DataGrid2GdsS12.HeaderText = "Size 12";
            this.DataGrid2GdsS12.Name = "DataGrid2GdsS12";
            this.DataGrid2GdsS12.Width = 50;
            // 
            // DataGrid2GdsQty
            // 
            this.DataGrid2GdsQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGrid2GdsQty.HeaderText = "Qty";
            this.DataGrid2GdsQty.Name = "DataGrid2GdsQty";
            this.DataGrid2GdsQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DataGrid2GdsSellP
            // 
            this.DataGrid2GdsSellP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGrid2GdsSellP.HeaderText = "Selling price";
            this.DataGrid2GdsSellP.Name = "DataGrid2GdsSellP";
            this.DataGrid2GdsSellP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dgvGI2);
            this.panel1.Controls.Add(this.dgvGI1);
            this.panel1.Controls.Add(this.txtBoxGdsRemark);
            this.panel1.Controls.Add(this.Remark);
            this.panel1.Controls.Add(this.DrpBoxGdsTo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DrpBoxGdsFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRefNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGdsSave);
            this.panel1.Controls.Add(this.btnGdsPrint);
            this.panel1.Controls.Add(this.btnGdsNew);
            this.panel1.Location = new System.Drawing.Point(13, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 655);
            this.panel1.TabIndex = 0;
            // 
            // frmGoodsIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(985, 702);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGoodsIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods_Issue";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGoodsIssue_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGI2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGdsNew;
        private System.Windows.Forms.Button btnGdsPrint;
        private System.Windows.Forms.Button btnGdsSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox DrpBoxGdsFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox DrpBoxGdsTo;
        private System.Windows.Forms.Label Remark;
        private System.Windows.Forms.TextBox txtBoxGdsRemark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridGdsS_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsS6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsS7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsS8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsS9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsS10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsS11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsS12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid2GdsSellP;
        public System.Windows.Forms.DataGridView dgvGI2;
        public System.Windows.Forms.DataGridView dgvGI1;
    }
}