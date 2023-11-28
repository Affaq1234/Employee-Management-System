namespace ems_app.Forms
{
    partial class HOD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOD));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.updatebtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnadd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.deletebtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.refreshbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelhod = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.90909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09091F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelhod, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 624);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.updatebtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnadd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.deletebtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.refreshbtn, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(770, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 176);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // updatebtn
            // 
            this.updatebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.Location = new System.Drawing.Point(14, 110);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Palette = this.kryptonPalette1;
            this.updatebtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.updatebtn.Size = new System.Drawing.Size(125, 44);
            this.updatebtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.updatebtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.updatebtn.StateCommon.Back.ColorAngle = 45F;
            this.updatebtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.updatebtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.updatebtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updatebtn.StateCommon.Border.Rounding = 20;
            this.updatebtn.StateCommon.Border.Width = 1;
            this.updatebtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.updatebtn.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.updatebtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.TabIndex = 20;
            this.updatebtn.Values.Text = "Update";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Image")));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Location = new System.Drawing.Point(14, 22);
            this.btnadd.Margin = new System.Windows.Forms.Padding(0);
            this.btnadd.Name = "btnadd";
            this.btnadd.Palette = this.kryptonPalette1;
            this.btnadd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnadd.Size = new System.Drawing.Size(125, 44);
            this.btnadd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnadd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnadd.StateCommon.Back.ColorAngle = 45F;
            this.btnadd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnadd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnadd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnadd.StateCommon.Border.Rounding = 20;
            this.btnadd.StateCommon.Border.Width = 1;
            this.btnadd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnadd.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.TabIndex = 19;
            this.btnadd.Values.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Location = new System.Drawing.Point(169, 22);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Palette = this.kryptonPalette1;
            this.deletebtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.deletebtn.Size = new System.Drawing.Size(125, 44);
            this.deletebtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.deletebtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.deletebtn.StateCommon.Back.ColorAngle = 45F;
            this.deletebtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.deletebtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.deletebtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deletebtn.StateCommon.Border.Rounding = 20;
            this.deletebtn.StateCommon.Border.Width = 1;
            this.deletebtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.deletebtn.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.TabIndex = 21;
            this.deletebtn.Values.Text = "Delete";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbtn.Location = new System.Drawing.Point(169, 110);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(125, 44);
            this.refreshbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.refreshbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.refreshbtn.StateCommon.Back.ColorAngle = 45F;
            this.refreshbtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.refreshbtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.refreshbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.refreshbtn.StateCommon.Border.Rounding = 20;
            this.refreshbtn.StateCommon.Border.Width = 1;
            this.refreshbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.refreshbtn.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.TabIndex = 21;
            this.refreshbtn.Values.Text = "Refresh";
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // panelhod
            // 
            this.panelhod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelhod.Location = new System.Drawing.Point(3, 3);
            this.panelhod.Name = "panelhod";
            this.panelhod.Size = new System.Drawing.Size(761, 126);
            this.panelhod.TabIndex = 1;
            // 
            // DGV
            // 
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV, 2);
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 185);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1076, 436);
            this.DGV.TabIndex = 2;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.43478F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.56522F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.emailtxt, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(761, 44);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(629, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 38);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 19F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(152)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(43, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 44);
            this.label4.TabIndex = 22;
            this.label4.Text = "Search";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailtxt
            // 
            this.emailtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailtxt.Location = new System.Drawing.Point(234, 2);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(347, 39);
            this.emailtxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.emailtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.emailtxt.StateCommon.Border.Rounding = 18;
            this.emailtxt.TabIndex = 21;
            this.emailtxt.Text = "Enter Name";
            // 
            // HOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 624);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HOD";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelhod;
        private System.Windows.Forms.DataGridView DGV;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnadd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton updatebtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deletebtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton refreshbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
