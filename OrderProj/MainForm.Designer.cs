namespace OrderProj
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ایجادToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جستوجوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.persianDatePicker2 = new System.Windows.Forms.PersianDatePicker();
            this.persianDatePicker1 = new System.Windows.Forms.PersianDatePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ایجادToolStripMenuItem,
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.جستوجوToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ایجادToolStripMenuItem
            // 
            this.ایجادToolStripMenuItem.Name = "ایجادToolStripMenuItem";
            this.ایجادToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ایجادToolStripMenuItem.Text = "ایجاد";
            this.ایجادToolStripMenuItem.Click += new System.EventHandler(this.Create_Click);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.حذفToolStripMenuItem.Text = "حذف";
            // 
            // جستوجوToolStripMenuItem
            // 
            this.جستوجوToolStripMenuItem.Name = "جستوجوToolStripMenuItem";
            this.جستوجوToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.جستوجوToolStripMenuItem.Text = "جست و جو";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.persianDatePicker2);
            this.groupBox1.Controls.Add(this.persianDatePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو";
            // 
            // persianDatePicker2
            // 
            this.persianDatePicker2.AutoSize = true;
            this.persianDatePicker2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.persianDatePicker2.BackColor = System.Drawing.Color.White;
            this.persianDatePicker2.GeorgianDate = null;
            this.persianDatePicker2.Location = new System.Drawing.Point(15, 60);
            this.persianDatePicker2.Margin = new System.Windows.Forms.Padding(0);
            this.persianDatePicker2.Name = "persianDatePicker2";
            this.persianDatePicker2.PersianDate.Day = 0;
            this.persianDatePicker2.PersianDate.Month = 0;
            this.persianDatePicker2.PersianDate.Year = 0;
            this.persianDatePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persianDatePicker2.Size = new System.Drawing.Size(288, 24);
            this.persianDatePicker2.TabIndex = 3;
            // 
            // persianDatePicker1
            // 
            this.persianDatePicker1.AutoSize = true;
            this.persianDatePicker1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.persianDatePicker1.BackColor = System.Drawing.Color.White;
            this.persianDatePicker1.GeorgianDate = null;
            this.persianDatePicker1.Location = new System.Drawing.Point(15, 27);
            this.persianDatePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.persianDatePicker1.Name = "persianDatePicker1";
            this.persianDatePicker1.PersianDate.Day = 0;
            this.persianDatePicker1.PersianDate.Month = 0;
            this.persianDatePicker1.PersianDate.Year = 0;
            this.persianDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persianDatePicker1.Size = new System.Drawing.Size(288, 24);
            this.persianDatePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(433, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "تا تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "از تاریخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "مشتری:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(689, 304);
            this.dataGridView1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صفحه اصلی";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ایجادToolStripMenuItem;
        private ToolStripMenuItem ویرایشToolStripMenuItem;
        private ToolStripMenuItem حذفToolStripMenuItem;
        private ToolStripMenuItem جستوجوToolStripMenuItem;
        private ToolStripMenuItem خروجToolStripMenuItem;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private PersianDatePicker persianDatePicker1;
        private PersianDatePicker persianDatePicker2;
    }
}