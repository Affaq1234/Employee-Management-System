namespace ems_app.Forms
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbdepartment = new Krypton.Toolkit.KryptonComboBox();
            this.cbGender = new Krypton.Toolkit.KryptonComboBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.agetxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passwordtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nametxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSignIn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbdepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(360, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbdepartment);
            this.panel2.Controls.Add(this.cbGender);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.agetxt);
            this.panel2.Controls.Add(this.passwordtxt);
            this.panel2.Controls.Add(this.nametxt);
            this.panel2.Controls.Add(this.emailtxt);
            this.panel2.Controls.Add(this.btnSignIn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(380, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 587);
            this.panel2.TabIndex = 2;
            // 
            // cbdepartment
            // 
            this.cbdepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbdepartment.CornerRoundingRadius = 18F;
            this.cbdepartment.DropDownWidth = 238;
            this.cbdepartment.IntegralHeight = false;
            this.cbdepartment.Items.AddRange(new object[] {
            "Sales",
            "Marketing",
            "Development",
            "Human Resource",
            "Financial",
            "Administration"});
            this.cbdepartment.Location = new System.Drawing.Point(485, 447);
            this.cbdepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbdepartment.Name = "cbdepartment";
            this.cbdepartment.Size = new System.Drawing.Size(347, 37);
            this.cbdepartment.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbdepartment.StateCommon.ComboBox.Border.Rounding = 18F;
            this.cbdepartment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbdepartment.TabIndex = 28;
            this.cbdepartment.Text = "Departments";
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
            this.cbGender.Location = new System.Drawing.Point(485, 345);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(347, 37);
            this.cbGender.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbGender.StateCommon.ComboBox.Border.Rounding = 18F;
            this.cbGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbGender.TabIndex = 28;
            this.cbGender.Text = "Gender";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel14.Location = new System.Drawing.Point(652, 320);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(12, 6);
            this.panel14.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Location = new System.Drawing.Point(225, 320);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(12, 6);
            this.panel8.TabIndex = 21;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel13.Location = new System.Drawing.Point(652, 415);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(12, 6);
            this.panel13.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Location = new System.Drawing.Point(225, 415);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 6);
            this.panel5.TabIndex = 21;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel12.Location = new System.Drawing.Point(687, 320);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(133, 6);
            this.panel12.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Location = new System.Drawing.Point(260, 320);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(133, 6);
            this.panel7.TabIndex = 21;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel11.Location = new System.Drawing.Point(687, 415);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(133, 6);
            this.panel11.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(260, 415);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 6);
            this.panel4.TabIndex = 21;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Location = new System.Drawing.Point(497, 320);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(133, 6);
            this.panel10.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Location = new System.Drawing.Point(71, 320);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(133, 6);
            this.panel6.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel9.Location = new System.Drawing.Point(497, 415);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(133, 6);
            this.panel9.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(71, 415);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 6);
            this.panel3.TabIndex = 21;
            // 
            // agetxt
            // 
            this.agetxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.agetxt.Location = new System.Drawing.Point(485, 247);
            this.agetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(347, 39);
            this.agetxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.agetxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.agetxt.StateCommon.Border.Rounding = 18;
            this.agetxt.TabIndex = 19;
            this.agetxt.Text = "Age";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordtxt.Location = new System.Drawing.Point(59, 447);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(347, 39);
            this.passwordtxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passwordtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordtxt.StateCommon.Border.Rounding = 18;
            this.passwordtxt.TabIndex = 19;
            this.passwordtxt.Text = "Enter Password";
            // 
            // nametxt
            // 
            this.nametxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nametxt.Location = new System.Drawing.Point(59, 247);
            this.nametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(347, 39);
            this.nametxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.nametxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nametxt.StateCommon.Border.Rounding = 18;
            this.nametxt.TabIndex = 19;
            this.nametxt.Text = "Full Name";
            // 
            // emailtxt
            // 
            this.emailtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailtxt.Location = new System.Drawing.Point(59, 342);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(347, 39);
            this.emailtxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.emailtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.emailtxt.StateCommon.Border.Rounding = 18;
            this.emailtxt.TabIndex = 19;
            this.emailtxt.Text = "Enter Email";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Location = new System.Drawing.Point(383, 518);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Palette = this.kryptonPalette1;
            this.btnSignIn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSignIn.Size = new System.Drawing.Size(125, 44);
            this.btnSignIn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSignIn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSignIn.StateCommon.Back.ColorAngle = 45F;
            this.btnSignIn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSignIn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSignIn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignIn.StateCommon.Border.Rounding = 20;
            this.btnSignIn.StateCommon.Border.Width = 1;
            this.btnSignIn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSignIn.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignIn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.TabIndex = 18;
            this.btnSignIn.Values.Text = "Sign Up";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 19F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(152)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(383, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sign Up";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.82456F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.17544F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1265, 591);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(152)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 587);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Cn", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(239, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Abdullah Javed";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 10F);
            this.label6.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Location = new System.Drawing.Point(274, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Develop by";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 19F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(230, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 19F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 19F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(116, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 150);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbdepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSignIn;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonComboBox cbGender;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox agetxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nametxt;
        private Krypton.Toolkit.KryptonComboBox cbdepartment;
    }
}