namespace GiGi.UI
{
    partial class FrmSalesReturn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG2 = new System.Windows.Forms.DataGridView();
            this.DGSRN2ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRN2Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRN2Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRN2Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRN2DisP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRN2DisA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRN2InvP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRN2Tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGSRNItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRNSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRNPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRNQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRNDicpP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRNDisA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRNInvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRNTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSRNext = new System.Windows.Forms.Button();
            this.grpBoxSRInvoiceNo = new System.Windows.Forms.GroupBox();
            this.DGS = new System.Windows.Forms.DataGridView();
            this.DGSRItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRDicpP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRDisA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRInvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSRTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxSRInvoiceNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSRReturnNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btnSRSave = new System.Windows.Forms.Button();
            this.btnSRDone = new System.Windows.Forms.Button();
            this.btnSRNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnItemCatDelete = new System.Windows.Forms.Button();
            this.btnItemCatUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBoxSRInvoiceNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnItemCatDelete);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnSRNext);
            this.panel1.Controls.Add(this.btnItemCatUpdate);
            this.panel1.Controls.Add(this.grpBoxSRInvoiceNo);
            this.panel1.Controls.Add(this.txtBoxSRReturnNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.btnSRSave);
            this.panel1.Controls.Add(this.btnSRDone);
            this.panel1.Controls.Add(this.btnSRNew);
            this.panel1.Location = new System.Drawing.Point(11, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 643);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(20, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 311);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Sale";
            // 
            // DG2
            // 
            this.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGSRN2ItemCode,
            this.DGSRN2Size,
            this.DGSRN2Price,
            this.DGSRN2Qty,
            this.DGSRN2DisP,
            this.DGSRN2DisA,
            this.DGSRN2InvP,
            this.DGSRN2Tot});
            this.DG2.Location = new System.Drawing.Point(15, 80);
            this.DG2.Name = "DG2";
            this.DG2.Size = new System.Drawing.Size(843, 225);
            this.DG2.TabIndex = 20;
            // 
            // DGSRN2ItemCode
            // 
            this.DGSRN2ItemCode.HeaderText = "Item Code";
            this.DGSRN2ItemCode.Name = "DGSRN2ItemCode";
            // 
            // DGSRN2Size
            // 
            this.DGSRN2Size.HeaderText = "Size";
            this.DGSRN2Size.Name = "DGSRN2Size";
            // 
            // DGSRN2Price
            // 
            this.DGSRN2Price.HeaderText = "Price";
            this.DGSRN2Price.Name = "DGSRN2Price";
            // 
            // DGSRN2Qty
            // 
            this.DGSRN2Qty.HeaderText = "Qty";
            this.DGSRN2Qty.Name = "DGSRN2Qty";
            // 
            // DGSRN2DisP
            // 
            this.DGSRN2DisP.HeaderText = "Dis. (%)";
            this.DGSRN2DisP.Name = "DGSRN2DisP";
            // 
            // DGSRN2DisA
            // 
            this.DGSRN2DisA.HeaderText = "Dis. (Amo)";
            this.DGSRN2DisA.Name = "DGSRN2DisA";
            // 
            // DGSRN2InvP
            // 
            this.DGSRN2InvP.HeaderText = "Inv. Price";
            this.DGSRN2InvP.Name = "DGSRN2InvP";
            // 
            // DGSRN2Tot
            // 
            this.DGSRN2Tot.HeaderText = "Total";
            this.DGSRN2Tot.Name = "DGSRN2Tot";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGSRNItemCode,
            this.DGSRNSize,
            this.DGSRNPrice,
            this.DGSRNQty,
            this.DGSRNDicpP,
            this.DGSRNDisA,
            this.DGSRNInvPrice,
            this.DGSRNTot});
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 46);
            this.dataGridView1.TabIndex = 19;
            // 
            // DGSRNItemCode
            // 
            this.DGSRNItemCode.HeaderText = "Item Code";
            this.DGSRNItemCode.Name = "DGSRNItemCode";
            // 
            // DGSRNSize
            // 
            this.DGSRNSize.HeaderText = "Size";
            this.DGSRNSize.Name = "DGSRNSize";
            // 
            // DGSRNPrice
            // 
            this.DGSRNPrice.HeaderText = "Price";
            this.DGSRNPrice.Name = "DGSRNPrice";
            // 
            // DGSRNQty
            // 
            this.DGSRNQty.HeaderText = "Qty";
            this.DGSRNQty.Name = "DGSRNQty";
            // 
            // DGSRNDicpP
            // 
            this.DGSRNDicpP.HeaderText = "Dis. (%)";
            this.DGSRNDicpP.Name = "DGSRNDicpP";
            // 
            // DGSRNDisA
            // 
            this.DGSRNDisA.HeaderText = "Dis. (Amo)";
            this.DGSRNDisA.Name = "DGSRNDisA";
            // 
            // DGSRNInvPrice
            // 
            this.DGSRNInvPrice.HeaderText = "Inv. Price";
            this.DGSRNInvPrice.Name = "DGSRNInvPrice";
            // 
            // DGSRNTot
            // 
            this.DGSRNTot.HeaderText = "Total";
            this.DGSRNTot.Name = "DGSRNTot";
            // 
            // BtnSRNext
            // 
            this.BtnSRNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnSRNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSRNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSRNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSRNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSRNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSRNext.Image = global::GiGi.UI.Properties.Resources.btn;
            this.BtnSRNext.Location = new System.Drawing.Point(114, 25);
            this.BtnSRNext.Name = "BtnSRNext";
            this.BtnSRNext.Size = new System.Drawing.Size(60, 65);
            this.BtnSRNext.TabIndex = 19;
            this.BtnSRNext.UseVisualStyleBackColor = false;
            // 
            // grpBoxSRInvoiceNo
            // 
            this.grpBoxSRInvoiceNo.Controls.Add(this.DGS);
            this.grpBoxSRInvoiceNo.Controls.Add(this.txtBoxSRInvoiceNo);
            this.grpBoxSRInvoiceNo.Controls.Add(this.label3);
            this.grpBoxSRInvoiceNo.Location = new System.Drawing.Point(18, 115);
            this.grpBoxSRInvoiceNo.Name = "grpBoxSRInvoiceNo";
            this.grpBoxSRInvoiceNo.Size = new System.Drawing.Size(905, 179);
            this.grpBoxSRInvoiceNo.TabIndex = 16;
            this.grpBoxSRInvoiceNo.TabStop = false;
            this.grpBoxSRInvoiceNo.Text = "Invoice No";
            // 
            // DGS
            // 
            this.DGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGSRItemCode,
            this.DGSRSize,
            this.DGSRPrice,
            this.DGSRQty,
            this.DGSRDicpP,
            this.DGSRDisA,
            this.DGSRInvPrice,
            this.DGSRTot});
            this.DGS.Location = new System.Drawing.Point(14, 57);
            this.DGS.Name = "DGS";
            this.DGS.Size = new System.Drawing.Size(843, 104);
            this.DGS.TabIndex = 15;
            // 
            // DGSRItemCode
            // 
            this.DGSRItemCode.HeaderText = "Item Code";
            this.DGSRItemCode.Name = "DGSRItemCode";
            // 
            // DGSRSize
            // 
            this.DGSRSize.HeaderText = "Size";
            this.DGSRSize.Name = "DGSRSize";
            // 
            // DGSRPrice
            // 
            this.DGSRPrice.HeaderText = "Price";
            this.DGSRPrice.Name = "DGSRPrice";
            // 
            // DGSRQty
            // 
            this.DGSRQty.HeaderText = "Qty";
            this.DGSRQty.Name = "DGSRQty";
            // 
            // DGSRDicpP
            // 
            this.DGSRDicpP.HeaderText = "Dis. (%)";
            this.DGSRDicpP.Name = "DGSRDicpP";
            // 
            // DGSRDisA
            // 
            this.DGSRDisA.HeaderText = "Dis. (Amo)";
            this.DGSRDisA.Name = "DGSRDisA";
            // 
            // DGSRInvPrice
            // 
            this.DGSRInvPrice.HeaderText = "Inv. Price";
            this.DGSRInvPrice.Name = "DGSRInvPrice";
            // 
            // DGSRTot
            // 
            this.DGSRTot.HeaderText = "Total";
            this.DGSRTot.Name = "DGSRTot";
            // 
            // txtBoxSRInvoiceNo
            // 
            this.txtBoxSRInvoiceNo.Location = new System.Drawing.Point(96, 19);
            this.txtBoxSRInvoiceNo.Name = "txtBoxSRInvoiceNo";
            this.txtBoxSRInvoiceNo.Size = new System.Drawing.Size(233, 20);
            this.txtBoxSRInvoiceNo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Invoice No";
            // 
            // txtBoxSRReturnNo
            // 
            this.txtBoxSRReturnNo.Location = new System.Drawing.Point(690, 69);
            this.txtBoxSRReturnNo.Name = "txtBoxSRReturnNo";
            this.txtBoxSRReturnNo.Size = new System.Drawing.Size(233, 20);
            this.txtBoxSRReturnNo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Return No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(605, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Date";
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(690, 20);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(233, 21);
            this.dtp1.TabIndex = 11;
            // 
            // btnSRSave
            // 
            this.btnSRSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSRSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSRSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSRSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSRSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSRSave.Image = global::GiGi.UI.Properties.Resources.save_black;
            this.btnSRSave.Location = new System.Drawing.Point(454, 24);
            this.btnSRSave.Name = "btnSRSave";
            this.btnSRSave.Size = new System.Drawing.Size(60, 65);
            this.btnSRSave.TabIndex = 9;
            this.btnSRSave.UseVisualStyleBackColor = false;
            // 
            // btnSRDone
            // 
            this.btnSRDone.BackColor = System.Drawing.Color.Transparent;
            this.btnSRDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSRDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSRDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSRDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSRDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSRDone.Image = global::GiGi.UI.Properties.Resources.done_black;
            this.btnSRDone.Location = new System.Drawing.Point(347, 25);
            this.btnSRDone.Name = "btnSRDone";
            this.btnSRDone.Size = new System.Drawing.Size(60, 65);
            this.btnSRDone.TabIndex = 8;
            this.btnSRDone.Text = " ";
            this.btnSRDone.UseVisualStyleBackColor = false;
            // 
            // btnSRNew
            // 
            this.btnSRNew.BackColor = System.Drawing.Color.Transparent;
            this.btnSRNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSRNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSRNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSRNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSRNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSRNew.Image = global::GiGi.UI.Properties.Resources.new_black;
            this.btnSRNew.Location = new System.Drawing.Point(35, 25);
            this.btnSRNew.Name = "btnSRNew";
            this.btnSRNew.Size = new System.Drawing.Size(60, 65);
            this.btnSRNew.TabIndex = 7;
            this.btnSRNew.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(386, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sales Return Invoice";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GiGi.UI.Properties.Resources.img_close;
            this.btnClose.Location = new System.Drawing.Point(931, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 23);
            this.btnClose.TabIndex = 7;
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
            this.btnMaximize.Location = new System.Drawing.Point(893, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 23);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::GiGi.UI.Properties.Resources.minimize_window;
            this.btnMinimize.Location = new System.Drawing.Point(855, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 23);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnItemCatDelete
            // 
            this.btnItemCatDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnItemCatDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemCatDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCatDelete.Image = global::GiGi.UI.Properties.Resources.delete_black;
            this.btnItemCatDelete.Location = new System.Drawing.Point(215, 25);
            this.btnItemCatDelete.Name = "btnItemCatDelete";
            this.btnItemCatDelete.Size = new System.Drawing.Size(60, 65);
            this.btnItemCatDelete.TabIndex = 22;
            this.btnItemCatDelete.UseVisualStyleBackColor = false;
            // 
            // btnItemCatUpdate
            // 
            this.btnItemCatUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnItemCatUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemCatUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCatUpdate.Image = global::GiGi.UI.Properties.Resources.update_black;
            this.btnItemCatUpdate.Location = new System.Drawing.Point(281, 25);
            this.btnItemCatUpdate.Name = "btnItemCatUpdate";
            this.btnItemCatUpdate.Size = new System.Drawing.Size(60, 65);
            this.btnItemCatUpdate.TabIndex = 21;
            this.btnItemCatUpdate.UseVisualStyleBackColor = false;
            // 
            // FrmSalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(984, 689);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSalesReturn";
            this.Text = "FrmSalesReturn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBoxSRInvoiceNo.ResumeLayout(false);
            this.grpBoxSRInvoiceNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnSRSave;
        private System.Windows.Forms.Button btnSRDone;
        private System.Windows.Forms.Button btnSRNew;
        private System.Windows.Forms.TextBox txtBoxSRReturnNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox txtBoxSRInvoiceNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBoxSRInvoiceNo;
        private System.Windows.Forms.DataGridView DGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRDicpP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRDisA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRInvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRTot;
        private System.Windows.Forms.Button BtnSRNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DG2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRN2ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRN2Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRN2Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRN2Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRN2DisP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRN2DisA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRN2InvP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRN2Tot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRNItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRNSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRNPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRNQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRNDicpP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRNDisA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRNInvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSRNTot;
        private System.Windows.Forms.Button btnItemCatDelete;
        private System.Windows.Forms.Button btnItemCatUpdate;
    }
}