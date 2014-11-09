namespace GiGi.UI
{
    partial class FrmSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rchBoxNoteS = new System.Windows.Forms.RichTextBox();
            this.TxtBoxTotalS = new System.Windows.Forms.TextBox();
            this.txtBoxTotDisS = new System.Windows.Forms.TextBox();
            this.txtBoxNetValS = new System.Windows.Forms.TextBox();
            this.txtBoxTotQtyS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DG2 = new System.Windows.Forms.DataGridView();
            this.DG2ItemCodeS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2SizeS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2PriceS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2QtyS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2DisPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2DisAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2InvPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2TotS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGS = new System.Windows.Forms.DataGridView();
            this.DGItenCodeS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSizeS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGPriceS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGQtyS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGDicpPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGDisAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGInvPriceS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGTotS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBoxVouNoS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GrpBoxCreditS = new System.Windows.Forms.GroupBox();
            this.TxtBoxCardNoS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrpBoxCashS = new System.Windows.Forms.GroupBox();
            this.TxtBoxInvoiceNoS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxMethosS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btnSalesSave = new System.Windows.Forms.Button();
            this.btnSalesDelete = new System.Windows.Forms.Button();
            this.btnSalesUpdate = new System.Windows.Forms.Button();
            this.btnSalesDone = new System.Windows.Forms.Button();
            this.btnSalesNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GrpBoxCreditS.SuspendLayout();
            this.GrpBoxCashS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(382, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sales Invoice";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.rchBoxNoteS);
            this.panel1.Controls.Add(this.TxtBoxTotalS);
            this.panel1.Controls.Add(this.txtBoxTotDisS);
            this.panel1.Controls.Add(this.txtBoxNetValS);
            this.panel1.Controls.Add(this.txtBoxTotQtyS);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DG2);
            this.panel1.Controls.Add(this.DGS);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.GrpBoxCreditS);
            this.panel1.Controls.Add(this.GrpBoxCashS);
            this.panel1.Controls.Add(this.cmbBoxMethosS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.btnSalesSave);
            this.panel1.Controls.Add(this.btnSalesDelete);
            this.panel1.Controls.Add(this.btnSalesUpdate);
            this.panel1.Controls.Add(this.btnSalesDone);
            this.panel1.Controls.Add(this.btnSalesNew);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 683);
            this.panel1.TabIndex = 6;
            // 
            // rchBoxNoteS
            // 
            this.rchBoxNoteS.Location = new System.Drawing.Point(82, 563);
            this.rchBoxNoteS.Name = "rchBoxNoteS";
            this.rchBoxNoteS.Size = new System.Drawing.Size(464, 50);
            this.rchBoxNoteS.TabIndex = 15;
            this.rchBoxNoteS.Text = "";
            // 
            // TxtBoxTotalS
            // 
            this.TxtBoxTotalS.BackColor = System.Drawing.Color.Silver;
            this.TxtBoxTotalS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxTotalS.Location = new System.Drawing.Point(674, 634);
            this.TxtBoxTotalS.Name = "TxtBoxTotalS";
            this.TxtBoxTotalS.Size = new System.Drawing.Size(192, 31);
            this.TxtBoxTotalS.TabIndex = 14;
            // 
            // txtBoxTotDisS
            // 
            this.txtBoxTotDisS.BackColor = System.Drawing.Color.White;
            this.txtBoxTotDisS.Location = new System.Drawing.Point(674, 608);
            this.txtBoxTotDisS.Name = "txtBoxTotDisS";
            this.txtBoxTotDisS.Size = new System.Drawing.Size(192, 20);
            this.txtBoxTotDisS.TabIndex = 14;
            // 
            // txtBoxNetValS
            // 
            this.txtBoxNetValS.BackColor = System.Drawing.Color.White;
            this.txtBoxNetValS.Location = new System.Drawing.Point(674, 584);
            this.txtBoxNetValS.Name = "txtBoxNetValS";
            this.txtBoxNetValS.Size = new System.Drawing.Size(192, 20);
            this.txtBoxNetValS.TabIndex = 14;
            // 
            // txtBoxTotQtyS
            // 
            this.txtBoxTotQtyS.BackColor = System.Drawing.Color.White;
            this.txtBoxTotQtyS.Location = new System.Drawing.Point(674, 553);
            this.txtBoxTotQtyS.Name = "txtBoxTotQtyS";
            this.txtBoxTotQtyS.Size = new System.Drawing.Size(192, 20);
            this.txtBoxTotQtyS.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(599, 642);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(599, 613);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(599, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Net Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 558);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Note:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(599, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Qty";
            // 
            // DG2
            // 
            this.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG2ItemCodeS,
            this.DG2SizeS,
            this.DG2PriceS,
            this.DG2QtyS,
            this.DG2DisPS,
            this.DG2DisAS,
            this.DG2InvPS,
            this.DG2TotS});
            this.DG2.Location = new System.Drawing.Point(24, 259);
            this.DG2.Name = "DG2";
            this.DG2.Size = new System.Drawing.Size(843, 275);
            this.DG2.TabIndex = 12;
            // 
            // DG2ItemCodeS
            // 
            this.DG2ItemCodeS.HeaderText = "Item Code";
            this.DG2ItemCodeS.Name = "DG2ItemCodeS";
            // 
            // DG2SizeS
            // 
            this.DG2SizeS.HeaderText = "Size";
            this.DG2SizeS.Name = "DG2SizeS";
            // 
            // DG2PriceS
            // 
            this.DG2PriceS.HeaderText = "Price";
            this.DG2PriceS.Name = "DG2PriceS";
            // 
            // DG2QtyS
            // 
            this.DG2QtyS.HeaderText = "Qty";
            this.DG2QtyS.Name = "DG2QtyS";
            // 
            // DG2DisPS
            // 
            this.DG2DisPS.HeaderText = "Dis. (%)";
            this.DG2DisPS.Name = "DG2DisPS";
            // 
            // DG2DisAS
            // 
            this.DG2DisAS.HeaderText = "Dis. (Amo)";
            this.DG2DisAS.Name = "DG2DisAS";
            // 
            // DG2InvPS
            // 
            this.DG2InvPS.HeaderText = "Inv. Price";
            this.DG2InvPS.Name = "DG2InvPS";
            // 
            // DG2TotS
            // 
            this.DG2TotS.HeaderText = "Total";
            this.DG2TotS.Name = "DG2TotS";
            // 
            // DGS
            // 
            this.DGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGItenCodeS,
            this.DGSizeS,
            this.DGPriceS,
            this.DGQtyS,
            this.DGDicpPS,
            this.DGDisAS,
            this.DGInvPriceS,
            this.DGTotS});
            this.DGS.Location = new System.Drawing.Point(25, 191);
            this.DGS.Name = "DGS";
            this.DGS.Size = new System.Drawing.Size(843, 46);
            this.DGS.TabIndex = 12;
            // 
            // DGItenCodeS
            // 
            this.DGItenCodeS.HeaderText = "Item Code";
            this.DGItenCodeS.Name = "DGItenCodeS";
            // 
            // DGSizeS
            // 
            this.DGSizeS.HeaderText = "Size";
            this.DGSizeS.Name = "DGSizeS";
            // 
            // DGPriceS
            // 
            this.DGPriceS.HeaderText = "Price";
            this.DGPriceS.Name = "DGPriceS";
            // 
            // DGQtyS
            // 
            this.DGQtyS.HeaderText = "Qty";
            this.DGQtyS.Name = "DGQtyS";
            // 
            // DGDicpPS
            // 
            this.DGDicpPS.HeaderText = "Dis. (%)";
            this.DGDicpPS.Name = "DGDicpPS";
            // 
            // DGDisAS
            // 
            this.DGDisAS.HeaderText = "Dis. (Amo)";
            this.DGDisAS.Name = "DGDisAS";
            // 
            // DGInvPriceS
            // 
            this.DGInvPriceS.HeaderText = "Inv. Price";
            this.DGInvPriceS.Name = "DGInvPriceS";
            // 
            // DGTotS
            // 
            this.DGTotS.HeaderText = "Total";
            this.DGTotS.Name = "DGTotS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtBoxVouNoS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(668, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 51);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voucher";
            // 
            // TxtBoxVouNoS
            // 
            this.TxtBoxVouNoS.Location = new System.Drawing.Point(89, 16);
            this.TxtBoxVouNoS.Name = "TxtBoxVouNoS";
            this.TxtBoxVouNoS.Size = new System.Drawing.Size(185, 20);
            this.TxtBoxVouNoS.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Invoice No:";
            // 
            // GrpBoxCreditS
            // 
            this.GrpBoxCreditS.Controls.Add(this.TxtBoxCardNoS);
            this.GrpBoxCreditS.Controls.Add(this.label4);
            this.GrpBoxCreditS.Location = new System.Drawing.Point(347, 122);
            this.GrpBoxCreditS.Name = "GrpBoxCreditS";
            this.GrpBoxCreditS.Size = new System.Drawing.Size(286, 51);
            this.GrpBoxCreditS.TabIndex = 11;
            this.GrpBoxCreditS.TabStop = false;
            this.GrpBoxCreditS.Text = "Credit";
            // 
            // TxtBoxCardNoS
            // 
            this.TxtBoxCardNoS.Location = new System.Drawing.Point(75, 16);
            this.TxtBoxCardNoS.Name = "TxtBoxCardNoS";
            this.TxtBoxCardNoS.Size = new System.Drawing.Size(199, 20);
            this.TxtBoxCardNoS.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Card No:";
            // 
            // GrpBoxCashS
            // 
            this.GrpBoxCashS.Controls.Add(this.TxtBoxInvoiceNoS);
            this.GrpBoxCashS.Controls.Add(this.label3);
            this.GrpBoxCashS.Location = new System.Drawing.Point(24, 122);
            this.GrpBoxCashS.Name = "GrpBoxCashS";
            this.GrpBoxCashS.Size = new System.Drawing.Size(286, 51);
            this.GrpBoxCashS.TabIndex = 11;
            this.GrpBoxCashS.TabStop = false;
            this.GrpBoxCashS.Text = "Cash";
            // 
            // TxtBoxInvoiceNoS
            // 
            this.TxtBoxInvoiceNoS.Location = new System.Drawing.Point(89, 16);
            this.TxtBoxInvoiceNoS.Name = "TxtBoxInvoiceNoS";
            this.TxtBoxInvoiceNoS.Size = new System.Drawing.Size(185, 20);
            this.TxtBoxInvoiceNoS.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Invoice No:";
            // 
            // cmbBoxMethosS
            // 
            this.cmbBoxMethosS.FormattingEnabled = true;
            this.cmbBoxMethosS.Location = new System.Drawing.Point(622, 81);
            this.cmbBoxMethosS.Name = "cmbBoxMethosS";
            this.cmbBoxMethosS.Size = new System.Drawing.Size(332, 21);
            this.cmbBoxMethosS.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Method";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(538, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date";
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(623, 32);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(331, 21);
            this.dtp1.TabIndex = 8;
            // 
            // btnSalesSave
            // 
            this.btnSalesSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalesSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalesSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesSave.Image = global::GiGi.UI.Properties.Resources.save_black;
            this.btnSalesSave.Location = new System.Drawing.Point(391, 32);
            this.btnSalesSave.Name = "btnSalesSave";
            this.btnSalesSave.Size = new System.Drawing.Size(60, 65);
            this.btnSalesSave.TabIndex = 6;
            this.btnSalesSave.UseVisualStyleBackColor = false;
            // 
            // btnSalesDelete
            // 
            this.btnSalesDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalesDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalesDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesDelete.Image = global::GiGi.UI.Properties.Resources.delete_black;
            this.btnSalesDelete.Location = new System.Drawing.Point(208, 32);
            this.btnSalesDelete.Name = "btnSalesDelete";
            this.btnSalesDelete.Size = new System.Drawing.Size(60, 65);
            this.btnSalesDelete.TabIndex = 5;
            this.btnSalesDelete.UseVisualStyleBackColor = false;
            // 
            // btnSalesUpdate
            // 
            this.btnSalesUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalesUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalesUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalesUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesUpdate.Image = global::GiGi.UI.Properties.Resources.update_black;
            this.btnSalesUpdate.Location = new System.Drawing.Point(142, 32);
            this.btnSalesUpdate.Name = "btnSalesUpdate";
            this.btnSalesUpdate.Size = new System.Drawing.Size(60, 65);
            this.btnSalesUpdate.TabIndex = 4;
            this.btnSalesUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSalesDone
            // 
            this.btnSalesDone.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalesDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalesDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalesDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesDone.Image = global::GiGi.UI.Properties.Resources.done_black;
            this.btnSalesDone.Location = new System.Drawing.Point(274, 32);
            this.btnSalesDone.Name = "btnSalesDone";
            this.btnSalesDone.Size = new System.Drawing.Size(60, 65);
            this.btnSalesDone.TabIndex = 2;
            this.btnSalesDone.Text = " ";
            this.btnSalesDone.UseVisualStyleBackColor = false;
            // 
            // btnSalesNew
            // 
            this.btnSalesNew.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalesNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalesNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalesNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesNew.Image = global::GiGi.UI.Properties.Resources.new_black;
            this.btnSalesNew.Location = new System.Drawing.Point(24, 32);
            this.btnSalesNew.Name = "btnSalesNew";
            this.btnSalesNew.Size = new System.Drawing.Size(60, 65);
            this.btnSalesNew.TabIndex = 1;
            this.btnSalesNew.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GiGi.UI.Properties.Resources.img_close;
            this.btnClose.Location = new System.Drawing.Point(947, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximize.Enabled = false;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::GiGi.UI.Properties.Resources.maximize_window;
            this.btnMaximize.Location = new System.Drawing.Point(909, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 23);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::GiGi.UI.Properties.Resources.minimize_window;
            this.btnMinimize.Location = new System.Drawing.Point(871, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 23);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1000, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GrpBoxCreditS.ResumeLayout(false);
            this.GrpBoxCreditS.PerformLayout();
            this.GrpBoxCashS.ResumeLayout(false);
            this.GrpBoxCashS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalesNew;
        private System.Windows.Forms.Button btnSalesDone;
        private System.Windows.Forms.Button btnSalesUpdate;
        private System.Windows.Forms.Button btnSalesDelete;
        private System.Windows.Forms.Button btnSalesSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtBoxVouNoS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GrpBoxCreditS;
        private System.Windows.Forms.TextBox TxtBoxCardNoS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrpBoxCashS;
        private System.Windows.Forms.TextBox TxtBoxInvoiceNoS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxMethosS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxTotalS;
        private System.Windows.Forms.TextBox txtBoxTotDisS;
        private System.Windows.Forms.TextBox txtBoxNetValS;
        private System.Windows.Forms.TextBox txtBoxTotQtyS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DG2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2ItemCodeS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2SizeS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2PriceS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2QtyS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2DisPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2DisAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2InvPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2TotS;
        private System.Windows.Forms.DataGridView DGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGItenCodeS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSizeS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGPriceS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGQtyS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGDicpPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGDisAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGInvPriceS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGTotS;
        private System.Windows.Forms.RichTextBox rchBoxNoteS;
        private System.Windows.Forms.Label label11;
    }
}