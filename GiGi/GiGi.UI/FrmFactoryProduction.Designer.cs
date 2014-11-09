namespace GiGi.UI
{
    partial class FrmFactoryProduction
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFProductSave = new System.Windows.Forms.Button();
            this.btnFProductDelete = new System.Windows.Forms.Button();
            this.btnFProductUpdate = new System.Windows.Forms.Button();
            this.btnFProductDone = new System.Windows.Forms.Button();
            this.btnFProductNew = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.TxtBoxFGNnoFP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxRefNoFP = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGFPItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPS4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPS5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPS6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPS7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPS8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPS9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPS10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPS11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPS12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFPQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2 = new System.Windows.Forms.DataGridView();
            this.DG2FPItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPS4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPS5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPS6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPS7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPS8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPS9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPS10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPS11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPS12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG2FPQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(274, 9);
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
            this.btnClose.Location = new System.Drawing.Point(718, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 23);
            this.btnClose.TabIndex = 8;
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
            this.btnMaximize.Location = new System.Drawing.Point(680, 2);
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
            this.btnMinimize.Location = new System.Drawing.Point(642, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 23);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DG2);
            this.panel1.Controls.Add(this.dataGridView1);
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
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(469, 73);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(240, 21);
            this.dtp1.TabIndex = 16;
            // 
            // TxtBoxFGNnoFP
            // 
            this.TxtBoxFGNnoFP.Location = new System.Drawing.Point(115, 121);
            this.TxtBoxFGNnoFP.Name = "TxtBoxFGNnoFP";
            this.TxtBoxFGNnoFP.Size = new System.Drawing.Size(238, 20);
            this.TxtBoxFGNnoFP.TabIndex = 18;
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
            // TxtBoxRefNoFP
            // 
            this.TxtBoxRefNoFP.Location = new System.Drawing.Point(469, 121);
            this.TxtBoxRefNoFP.Name = "TxtBoxRefNoFP";
            this.TxtBoxRefNoFP.Size = new System.Drawing.Size(240, 20);
            this.TxtBoxRefNoFP.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGFPItemCode,
            this.DGFPS4,
            this.DGFPS5,
            this.DGFPS6,
            this.DGFPS7,
            this.DGFPS8,
            this.DGFPS9,
            this.DGFPS10,
            this.DGFPS11,
            this.DGFPS12,
            this.DGFPQty});
            this.dataGridView1.Location = new System.Drawing.Point(25, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 47);
            this.dataGridView1.TabIndex = 19;
            // 
            // DGFPItemCode
            // 
            this.DGFPItemCode.HeaderText = "Item Code";
            this.DGFPItemCode.Name = "DGFPItemCode";
            // 
            // DGFPS4
            // 
            this.DGFPS4.HeaderText = "Size 4";
            this.DGFPS4.Name = "DGFPS4";
            this.DGFPS4.Width = 50;
            // 
            // DGFPS5
            // 
            this.DGFPS5.HeaderText = "Size 5";
            this.DGFPS5.Name = "DGFPS5";
            this.DGFPS5.Width = 50;
            // 
            // DGFPS6
            // 
            this.DGFPS6.HeaderText = "Size 6";
            this.DGFPS6.Name = "DGFPS6";
            this.DGFPS6.Width = 50;
            // 
            // DGFPS7
            // 
            this.DGFPS7.HeaderText = "Size 7";
            this.DGFPS7.Name = "DGFPS7";
            this.DGFPS7.Width = 50;
            // 
            // DGFPS8
            // 
            this.DGFPS8.HeaderText = "Size 8";
            this.DGFPS8.Name = "DGFPS8";
            this.DGFPS8.Width = 50;
            // 
            // DGFPS9
            // 
            this.DGFPS9.HeaderText = "Size 9";
            this.DGFPS9.Name = "DGFPS9";
            this.DGFPS9.Width = 50;
            // 
            // DGFPS10
            // 
            this.DGFPS10.HeaderText = "Size 10";
            this.DGFPS10.Name = "DGFPS10";
            this.DGFPS10.Width = 50;
            // 
            // DGFPS11
            // 
            this.DGFPS11.HeaderText = "Size 11";
            this.DGFPS11.Name = "DGFPS11";
            this.DGFPS11.Width = 50;
            // 
            // DGFPS12
            // 
            this.DGFPS12.HeaderText = "Size 12";
            this.DGFPS12.Name = "DGFPS12";
            this.DGFPS12.Width = 50;
            // 
            // DGFPQty
            // 
            this.DGFPQty.HeaderText = "Qty";
            this.DGFPQty.Name = "DGFPQty";
            this.DGFPQty.Width = 90;
            // 
            // DG2
            // 
            this.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG2FPItemCode,
            this.DG2FPS4,
            this.DG2FPS5,
            this.DG2FPS6,
            this.DG2FPS7,
            this.DG2FPS8,
            this.DG2FPS9,
            this.DG2FPS10,
            this.DG2FPS11,
            this.DG2FPS12,
            this.DG2FPQty});
            this.DG2.Location = new System.Drawing.Point(25, 226);
            this.DG2.Name = "DG2";
            this.DG2.Size = new System.Drawing.Size(684, 157);
            this.DG2.TabIndex = 20;
            // 
            // DG2FPItemCode
            // 
            this.DG2FPItemCode.HeaderText = "Item Code";
            this.DG2FPItemCode.Name = "DG2FPItemCode";
            // 
            // DG2FPS4
            // 
            this.DG2FPS4.HeaderText = "Size 4";
            this.DG2FPS4.Name = "DG2FPS4";
            this.DG2FPS4.Width = 50;
            // 
            // DG2FPS5
            // 
            this.DG2FPS5.HeaderText = "Size 5";
            this.DG2FPS5.Name = "DG2FPS5";
            this.DG2FPS5.Width = 50;
            // 
            // DG2FPS6
            // 
            this.DG2FPS6.HeaderText = "Size 6";
            this.DG2FPS6.Name = "DG2FPS6";
            this.DG2FPS6.Width = 50;
            // 
            // DG2FPS7
            // 
            this.DG2FPS7.HeaderText = "Size 7";
            this.DG2FPS7.Name = "DG2FPS7";
            this.DG2FPS7.Width = 50;
            // 
            // DG2FPS8
            // 
            this.DG2FPS8.HeaderText = "Size 8";
            this.DG2FPS8.Name = "DG2FPS8";
            this.DG2FPS8.Width = 50;
            // 
            // DG2FPS9
            // 
            this.DG2FPS9.HeaderText = "Size 9";
            this.DG2FPS9.Name = "DG2FPS9";
            this.DG2FPS9.Width = 50;
            // 
            // DG2FPS10
            // 
            this.DG2FPS10.HeaderText = "Size 10";
            this.DG2FPS10.Name = "DG2FPS10";
            this.DG2FPS10.Width = 50;
            // 
            // DG2FPS11
            // 
            this.DG2FPS11.HeaderText = "Size 11";
            this.DG2FPS11.Name = "DG2FPS11";
            this.DG2FPS11.Width = 50;
            // 
            // DG2FPS12
            // 
            this.DG2FPS12.HeaderText = "Size 12";
            this.DG2FPS12.Name = "DG2FPS12";
            this.DG2FPS12.Width = 50;
            // 
            // DG2FPQty
            // 
            this.DG2FPQty.HeaderText = "Qty";
            this.DG2FPQty.Name = "DG2FPQty";
            this.DG2FPQty.Width = 90;
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
            // FrmFactoryProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(771, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFactoryProduction";
            this.Text = "FrmFactoryProduction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridView DG2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPS6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPS7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPS8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPS9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPS10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPS11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPS12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG2FPQty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPS6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPS7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPS8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPS9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPS10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPS11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPS12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFPQty;
        private System.Windows.Forms.TextBox TxtBoxRefNoFP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxFGNnoFP;
        private System.Windows.Forms.Label label3;
    }
}