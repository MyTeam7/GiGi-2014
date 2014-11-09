namespace GiGi.UI
{
    partial class frmFactoryProduction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxRefNoFP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxFGNnoFP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFProductSave = new System.Windows.Forms.Button();
            this.btnFProductNew = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btnFProductDelete = new System.Windows.Forms.Button();
            this.btnFProductDone = new System.Windows.Forms.Button();
            this.btnFProductUpdate = new System.Windows.Forms.Button();
            this.dgvFP1 = new System.Windows.Forms.DataGridView();
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
            this.dgvFP2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Factory Production";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GiGi.UI.Properties.Resources.img_close;
            this.btnClose.Location = new System.Drawing.Point(718, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximize.Enabled = false;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::GiGi.UI.Properties.Resources.maximize_window;
            this.btnMaximize.Location = new System.Drawing.Point(680, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 23);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::GiGi.UI.Properties.Resources.minimize_window;
            this.btnMinimize.Location = new System.Drawing.Point(642, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 23);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dgvFP2);
            this.panel1.Controls.Add(this.dgvFP1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtBoxRefNoFP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtBoxFGNnoFP);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnFProductSave);
            this.panel1.Controls.Add(this.btnFProductNew);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.btnFProductDelete);
            this.panel1.Controls.Add(this.btnFProductDone);
            this.panel1.Controls.Add(this.btnFProductUpdate);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 400);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date";
            // 
            // TxtBoxRefNoFP
            // 
            this.TxtBoxRefNoFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxRefNoFP.Location = new System.Drawing.Point(469, 121);
            this.TxtBoxRefNoFP.Name = "TxtBoxRefNoFP";
            this.TxtBoxRefNoFP.Size = new System.Drawing.Size(240, 20);
            this.TxtBoxRefNoFP.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ref. No";
            // 
            // TxtBoxFGNnoFP
            // 
            this.TxtBoxFGNnoFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxFGNnoFP.Location = new System.Drawing.Point(115, 121);
            this.TxtBoxFGNnoFP.Name = "TxtBoxFGNnoFP";
            this.TxtBoxFGNnoFP.Size = new System.Drawing.Size(238, 20);
            this.TxtBoxFGNnoFP.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "FGN. No";
            // 
            // btnFProductSave
            // 
            this.btnFProductSave.BackColor = System.Drawing.Color.Transparent;
            this.btnFProductSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFProductSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFProductSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFProductSave.Image = global::GiGi.UI.Properties.Resources.save_black;
            this.btnFProductSave.Location = new System.Drawing.Point(277, 29);
            this.btnFProductSave.Name = "btnFProductSave";
            this.btnFProductSave.Size = new System.Drawing.Size(60, 65);
            this.btnFProductSave.TabIndex = 15;
            this.btnFProductSave.UseVisualStyleBackColor = false;
            // 
            // btnFProductNew
            // 
            this.btnFProductNew.BackColor = System.Drawing.Color.Transparent;
            this.btnFProductNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFProductNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFProductNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFProductNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFProductNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFProductNew.Image = global::GiGi.UI.Properties.Resources.new_black;
            this.btnFProductNew.Location = new System.Drawing.Point(13, 29);
            this.btnFProductNew.Name = "btnFProductNew";
            this.btnFProductNew.Size = new System.Drawing.Size(60, 65);
            this.btnFProductNew.TabIndex = 11;
            this.btnFProductNew.UseVisualStyleBackColor = false;
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(469, 73);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(240, 21);
            this.dtp1.TabIndex = 16;
            // 
            // btnFProductDelete
            // 
            this.btnFProductDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnFProductDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFProductDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFProductDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFProductDelete.Image = global::GiGi.UI.Properties.Resources.delete_black;
            this.btnFProductDelete.Location = new System.Drawing.Point(145, 29);
            this.btnFProductDelete.Name = "btnFProductDelete";
            this.btnFProductDelete.Size = new System.Drawing.Size(60, 65);
            this.btnFProductDelete.TabIndex = 14;
            this.btnFProductDelete.UseVisualStyleBackColor = false;
            // 
            // btnFProductDone
            // 
            this.btnFProductDone.BackColor = System.Drawing.Color.Transparent;
            this.btnFProductDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFProductDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFProductDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFProductDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFProductDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFProductDone.Image = global::GiGi.UI.Properties.Resources.done_black;
            this.btnFProductDone.Location = new System.Drawing.Point(211, 29);
            this.btnFProductDone.Name = "btnFProductDone";
            this.btnFProductDone.Size = new System.Drawing.Size(60, 65);
            this.btnFProductDone.TabIndex = 12;
            this.btnFProductDone.Text = " ";
            this.btnFProductDone.UseVisualStyleBackColor = false;
            // 
            // btnFProductUpdate
            // 
            this.btnFProductUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnFProductUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFProductUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFProductUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFProductUpdate.Image = global::GiGi.UI.Properties.Resources.update_black;
            this.btnFProductUpdate.Location = new System.Drawing.Point(79, 29);
            this.btnFProductUpdate.Name = "btnFProductUpdate";
            this.btnFProductUpdate.Size = new System.Drawing.Size(60, 65);
            this.btnFProductUpdate.TabIndex = 13;
            this.btnFProductUpdate.UseVisualStyleBackColor = false;
            // 
            // dgvFP1
            // 
            this.dgvFP1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFP1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFP1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFP1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DataGridGdsQty});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFP1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFP1.EnableHeadersVisualStyles = false;
            this.dgvFP1.Location = new System.Drawing.Point(25, 162);
            this.dgvFP1.Name = "dgvFP1";
            this.dgvFP1.RowHeadersVisible = false;
            this.dgvFP1.Size = new System.Drawing.Size(684, 58);
            this.dgvFP1.TabIndex = 22;
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
            // dgvFP2
            // 
            this.dgvFP2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFP2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFP2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFP2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFP2.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvFP2.EnableHeadersVisualStyles = false;
            this.dgvFP2.Location = new System.Drawing.Point(25, 226);
            this.dgvFP2.Name = "dgvFP2";
            this.dgvFP2.RowHeadersVisible = false;
            this.dgvFP2.Size = new System.Drawing.Size(684, 158);
            this.dgvFP2.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Size 4";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Size 5";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Size 6";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Size 7";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Size 8";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Size 9";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Size 10";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Size 11";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Size 12";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmFactoryProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(771, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactoryProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFactoryProduction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFProductSave;
        private System.Windows.Forms.Button btnFProductNew;
        private System.Windows.Forms.Button btnFProductDelete;
        private System.Windows.Forms.Button btnFProductDone;
        private System.Windows.Forms.Button btnFProductUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBoxRefNoFP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxFGNnoFP;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtp1;
        public System.Windows.Forms.DataGridView dgvFP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        public System.Windows.Forms.DataGridView dgvFP1;
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
    }
}