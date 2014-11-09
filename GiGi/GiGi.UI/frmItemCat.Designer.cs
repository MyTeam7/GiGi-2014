namespace GiGi.UI
{
    partial class frmItemCat
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnItemCatSave = new System.Windows.Forms.Button();
            this.btnItemCatNew = new System.Windows.Forms.Button();
            this.btnItemCatDelete = new System.Windows.Forms.Button();
            this.btnItemCatDone = new System.Windows.Forms.Button();
            this.btnItemCatUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxItemCatId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxItemCatDes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxItemCatNote = new System.Windows.Forms.TextBox();
            this.DGIC = new System.Windows.Forms.DataGridView();
            this.DGICId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGICDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGICNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGIC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.DGIC);
            this.panel1.Controls.Add(this.txtBoxItemCatNote);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBoxItemCatDes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBoxItemCatId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.btnItemCatSave);
            this.panel1.Controls.Add(this.btnItemCatNew);
            this.panel1.Controls.Add(this.btnItemCatDelete);
            this.panel1.Controls.Add(this.btnItemCatDone);
            this.panel1.Controls.Add(this.btnItemCatUpdate);
            this.panel1.Location = new System.Drawing.Point(9, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 396);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item Category";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GiGi.UI.Properties.Resources.img_close;
            this.btnClose.Location = new System.Drawing.Point(718, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 23);
            this.btnClose.TabIndex = 11;
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
            this.btnMaximize.Location = new System.Drawing.Point(680, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 23);
            this.btnMaximize.TabIndex = 10;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::GiGi.UI.Properties.Resources.minimize_window;
            this.btnMinimize.Location = new System.Drawing.Point(642, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 23);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnItemCatSave
            // 
            this.btnItemCatSave.BackColor = System.Drawing.Color.Transparent;
            this.btnItemCatSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemCatSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCatSave.Image = global::GiGi.UI.Properties.Resources.save_black;
            this.btnItemCatSave.Location = new System.Drawing.Point(280, 26);
            this.btnItemCatSave.Name = "btnItemCatSave";
            this.btnItemCatSave.Size = new System.Drawing.Size(60, 65);
            this.btnItemCatSave.TabIndex = 20;
            this.btnItemCatSave.UseVisualStyleBackColor = false;
            // 
            // btnItemCatNew
            // 
            this.btnItemCatNew.BackColor = System.Drawing.Color.Transparent;
            this.btnItemCatNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemCatNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemCatNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCatNew.Image = global::GiGi.UI.Properties.Resources.new_black;
            this.btnItemCatNew.Location = new System.Drawing.Point(16, 26);
            this.btnItemCatNew.Name = "btnItemCatNew";
            this.btnItemCatNew.Size = new System.Drawing.Size(60, 65);
            this.btnItemCatNew.TabIndex = 16;
            this.btnItemCatNew.UseVisualStyleBackColor = false;
            // 
            // btnItemCatDelete
            // 
            this.btnItemCatDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnItemCatDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemCatDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCatDelete.Image = global::GiGi.UI.Properties.Resources.delete_black;
            this.btnItemCatDelete.Location = new System.Drawing.Point(148, 26);
            this.btnItemCatDelete.Name = "btnItemCatDelete";
            this.btnItemCatDelete.Size = new System.Drawing.Size(60, 65);
            this.btnItemCatDelete.TabIndex = 19;
            this.btnItemCatDelete.UseVisualStyleBackColor = false;
            // 
            // btnItemCatDone
            // 
            this.btnItemCatDone.BackColor = System.Drawing.Color.Transparent;
            this.btnItemCatDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemCatDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemCatDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCatDone.Image = global::GiGi.UI.Properties.Resources.done_black;
            this.btnItemCatDone.Location = new System.Drawing.Point(214, 26);
            this.btnItemCatDone.Name = "btnItemCatDone";
            this.btnItemCatDone.Size = new System.Drawing.Size(60, 65);
            this.btnItemCatDone.TabIndex = 17;
            this.btnItemCatDone.Text = " ";
            this.btnItemCatDone.UseVisualStyleBackColor = false;
            // 
            // btnItemCatUpdate
            // 
            this.btnItemCatUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnItemCatUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemCatUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemCatUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCatUpdate.Image = global::GiGi.UI.Properties.Resources.update_black;
            this.btnItemCatUpdate.Location = new System.Drawing.Point(82, 26);
            this.btnItemCatUpdate.Name = "btnItemCatUpdate";
            this.btnItemCatUpdate.Size = new System.Drawing.Size(60, 65);
            this.btnItemCatUpdate.TabIndex = 18;
            this.btnItemCatUpdate.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date";
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(472, 70);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(240, 21);
            this.dtp1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cat. ID";
            // 
            // txtBoxItemCatId
            // 
            this.txtBoxItemCatId.Location = new System.Drawing.Point(73, 137);
            this.txtBoxItemCatId.Name = "txtBoxItemCatId";
            this.txtBoxItemCatId.Size = new System.Drawing.Size(200, 20);
            this.txtBoxItemCatId.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descrption";
            // 
            // txtBoxItemCatDes
            // 
            this.txtBoxItemCatDes.Location = new System.Drawing.Point(390, 136);
            this.txtBoxItemCatDes.Name = "txtBoxItemCatDes";
            this.txtBoxItemCatDes.Size = new System.Drawing.Size(322, 20);
            this.txtBoxItemCatDes.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Note";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBoxItemCatNote
            // 
            this.txtBoxItemCatNote.Location = new System.Drawing.Point(73, 179);
            this.txtBoxItemCatNote.Name = "txtBoxItemCatNote";
            this.txtBoxItemCatNote.Size = new System.Drawing.Size(639, 20);
            this.txtBoxItemCatNote.TabIndex = 25;
            // 
            // DGIC
            // 
            this.DGIC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGIC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGICId,
            this.DGICDes,
            this.DGICNote});
            this.DGIC.Location = new System.Drawing.Point(21, 218);
            this.DGIC.Name = "DGIC";
            this.DGIC.Size = new System.Drawing.Size(691, 165);
            this.DGIC.TabIndex = 26;
            // 
            // DGICId
            // 
            this.DGICId.HeaderText = "Cat. ID";
            this.DGICId.Name = "DGICId";
            // 
            // DGICDes
            // 
            this.DGICDes.HeaderText = "Description";
            this.DGICDes.Name = "DGICDes";
            this.DGICDes.Width = 200;
            // 
            // DGICNote
            // 
            this.DGICNote.HeaderText = "Note";
            this.DGICNote.Name = "DGICNote";
            this.DGICNote.Width = 340;
            // 
            // frmItemCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(771, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemCat";
            this.Text = "frmItemCat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnItemCatSave;
        private System.Windows.Forms.Button btnItemCatNew;
        private System.Windows.Forms.Button btnItemCatDelete;
        private System.Windows.Forms.Button btnItemCatDone;
        private System.Windows.Forms.Button btnItemCatUpdate;
        private System.Windows.Forms.TextBox txtBoxItemCatNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxItemCatDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxItemCatId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridView DGIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGICId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGICDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGICNote;
    }
}