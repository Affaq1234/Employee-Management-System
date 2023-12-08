namespace ems_app.UC
{
    partial class HOD_panel2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOD_panel2));
            this.cbdepartment = new Krypton.Toolkit.KryptonComboBox();
            this.agetxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nametxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.cbGender = new Krypton.Toolkit.KryptonComboBox();
            this.passwordtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbdepartment)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender)).BeginInit();
            this.SuspendLayout();
            // 
            // cbdepartment
            // 
            this.cbdepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbdepartment.CornerRoundingRadius = 18F;
            this.cbdepartment.DropDownWidth = 238;
            this.cbdepartment.IntegralHeight = false;
            this.cbdepartment.Location = new System.Drawing.Point(439, 92);
            this.cbdepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbdepartment.Name = "cbdepartment";
            this.cbdepartment.Size = new System.Drawing.Size(213, 37);
            this.cbdepartment.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbdepartment.StateCommon.ComboBox.Border.Rounding = 18F;
            this.cbdepartment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbdepartment.TabIndex = 32;
            this.cbdepartment.Text = "Departments";
            // 
            // agetxt
            // 
            this.agetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agetxt.Location = new System.Drawing.Point(3, 91);
            this.agetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(212, 39);
            this.agetxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.agetxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.agetxt.StateCommon.Border.Rounding = 18;
            this.agetxt.TabIndex = 29;
            this.agetxt.Text = "Age";
            // 
            // nametxt
            // 
            this.nametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nametxt.Location = new System.Drawing.Point(3, 17);
            this.nametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(212, 39);
            this.nametxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.nametxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nametxt.StateCommon.Border.Rounding = 18;
            this.nametxt.TabIndex = 30;
            this.nametxt.Text = "Full Name";
            // 
            // emailtxt
            // 
            this.emailtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailtxt.Location = new System.Drawing.Point(221, 17);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(212, 39);
            this.emailtxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.emailtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.emailtxt.StateCommon.Border.Rounding = 18;
            this.emailtxt.TabIndex = 31;
            this.emailtxt.Text = "Enter Email";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbGender, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordtxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailtxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.agetxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbdepartment, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nametxt, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 198);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(264, 151);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Palette = this.kryptonPalette1;
            this.btnSubmit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSubmit.Size = new System.Drawing.Size(125, 44);
            this.btnSubmit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSubmit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSubmit.StateCommon.Back.ColorAngle = 45F;
            this.btnSubmit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSubmit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSubmit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.StateCommon.Border.Rounding = 20;
            this.btnSubmit.StateCommon.Border.Width = 1;
            this.btnSubmit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSubmit.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            // cbGender
            // 
            this.cbGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbGender.CornerRoundingRadius = 18F;
            this.cbGender.DropDownWidth = 238;
            this.cbGender.IntegralHeight = false;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Rather not say"});
            this.cbGender.Location = new System.Drawing.Point(439, 18);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(213, 37);
            this.cbGender.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbGender.StateCommon.ComboBox.Border.Rounding = 18F;
            this.cbGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbGender.TabIndex = 35;
            this.cbGender.Text = "Gender";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordtxt.Location = new System.Drawing.Point(221, 91);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(212, 39);
            this.passwordtxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passwordtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordtxt.StateCommon.Border.Rounding = 18;
            this.passwordtxt.TabIndex = 34;
            this.passwordtxt.Text = "Enter Password";
            // 
            // HOD_panel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 198);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HOD_panel2";
            this.Text = "HOD_panel2";
            ((System.ComponentModel.ISupportInitialize)(this.cbdepartment)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cbdepartment;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox agetxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nametxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailtxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonComboBox cbGender;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}