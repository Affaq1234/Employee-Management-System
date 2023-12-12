namespace ems_app.UC
{
    partial class Emp_panel1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customPanel3 = new ems_app.Custom_Components.CustomPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.deptlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customPanel2 = new ems_app.Custom_Components.CustomPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.genderlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel1 = new ems_app.Custom_Components.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 171);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.customPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(497, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 165);
            this.panel3.TabIndex = 2;
            // 
            // customPanel3
            // 
            this.customPanel3.Controls.Add(this.label6);
            this.customPanel3.Controls.Add(this.deptlbl);
            this.customPanel3.CornerRadius = 30;
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(243, 165);
            this.customPanel3.StartColor = System.Drawing.Color.White;
            this.customPanel3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department";
            // 
            // deptlbl
            // 
            this.deptlbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.deptlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deptlbl.Font = new System.Drawing.Font("Calibri", 18.2F, System.Drawing.FontStyle.Bold);
            this.deptlbl.ForeColor = System.Drawing.Color.White;
            this.deptlbl.Location = new System.Drawing.Point(78, 0);
            this.deptlbl.MaximumSize = new System.Drawing.Size(220, 0);
            this.deptlbl.Name = "deptlbl";
            this.deptlbl.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.deptlbl.Size = new System.Drawing.Size(165, 165);
            this.deptlbl.TabIndex = 1;
            this.deptlbl.Text = "Computer Science";
            this.deptlbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.customPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 165);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // customPanel2
            // 
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.Controls.Add(this.genderlbl);
            this.customPanel2.CornerRadius = 30;
            this.customPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel2.EndColor = System.Drawing.Color.Aqua;
            this.customPanel2.Location = new System.Drawing.Point(0, 0);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(241, 165);
            this.customPanel2.StartColor = System.Drawing.Color.White;
            this.customPanel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Salary";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // genderlbl
            // 
            this.genderlbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.genderlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderlbl.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlbl.ForeColor = System.Drawing.Color.White;
            this.genderlbl.Location = new System.Drawing.Point(44, 0);
            this.genderlbl.MaximumSize = new System.Drawing.Size(220, 0);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.genderlbl.Size = new System.Drawing.Size(197, 165);
            this.genderlbl.TabIndex = 1;
            this.genderlbl.Text = "Rather Not Say";
            this.genderlbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.genderlbl.Click += new System.EventHandler(this.genderlbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 165);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customPanel1
            // 
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.namelbl);
            this.customPanel1.CornerRadius = 30;
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(241, 165);
            this.customPanel1.StartColor = System.Drawing.Color.White;
            this.customPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // namelbl
            // 
            this.namelbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.namelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namelbl.Font = new System.Drawing.Font("Calibri", 18.2F, System.Drawing.FontStyle.Bold);
            this.namelbl.ForeColor = System.Drawing.Color.White;
            this.namelbl.Location = new System.Drawing.Point(21, 0);
            this.namelbl.MaximumSize = new System.Drawing.Size(220, 0);
            this.namelbl.Name = "namelbl";
            this.namelbl.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.namelbl.Size = new System.Drawing.Size(220, 165);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Abdullah Javed";
            this.namelbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.namelbl.Click += new System.EventHandler(this.namelbl_Click);
            // 
            // Emp_panel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 171);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emp_panel1";
            this.Load += new System.EventHandler(this.HOD_panel1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label deptlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.Label label4;
        private Custom_Components.CustomPanel customPanel3;
        private Custom_Components.CustomPanel customPanel2;
        private Custom_Components.CustomPanel customPanel1;
    }
}
