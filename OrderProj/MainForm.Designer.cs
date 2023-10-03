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
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pdFromDate = new System.Windows.Forms.PersianDatePicker();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdToDate = new System.Windows.Forms.PersianDatePicker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ایجادToolStripMenuItem,
            this.btnEdit,
            this.btnDelete,
            this.btnSearch,
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
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 20);
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 20);
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 20);
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.groupBox1.Controls.Add(this.pdToDate);
            this.groupBox1.Controls.Add(this.pdFromDate);
            this.groupBox1.Controls.Add(this.cbCustomer);
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
            // pdFromDate
            // 
            this.pdFromDate.AutoSize = true;
            this.pdFromDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pdFromDate.BackColor = System.Drawing.Color.White;
            this.pdFromDate.GeorgianDate = null;
            this.pdFromDate.Location = new System.Drawing.Point(13, 27);
            this.pdFromDate.Margin = new System.Windows.Forms.Padding(0);
            this.pdFromDate.Name = "pdFromDate";
            this.pdFromDate.PersianDate.Day = 0;
            this.pdFromDate.PersianDate.Month = 0;
            this.pdFromDate.PersianDate.Year = 0;
            this.pdFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pdFromDate.Size = new System.Drawing.Size(288, 24);
            this.pdFromDate.TabIndex = 6;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(433, 33);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(194, 23);
            this.cbCustomer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "تا تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "از تاریخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "مشتری:";
            // 
            // dgOrder
            // 
            this.dgOrder.AllowUserToAddRows = false;
            this.dgOrder.AllowUserToDeleteRows = false;
            this.dgOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNumber,
            this.PersonalName,
            this.Date,
            this.SumPrice});
            this.dgOrder.Location = new System.Drawing.Point(7, 143);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.ReadOnly = true;
            this.dgOrder.RowTemplate.Height = 25;
            this.dgOrder.Size = new System.Drawing.Size(689, 304);
            this.dgOrder.TabIndex = 2;
            this.dgOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrder_CellClick);
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.HeaderText = "شماره فاکتور";
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            // 
            // PersonalName
            // 
            this.PersonalName.HeaderText = "نام مشتری";
            this.PersonalName.Name = "PersonalName";
            this.PersonalName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "تاریخ ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // SumPrice
            // 
            this.SumPrice.HeaderText = "جمع کل";
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.ReadOnly = true;
            // 
            // pdToDate
            // 
            this.pdToDate.AutoSize = true;
            this.pdToDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pdToDate.BackColor = System.Drawing.Color.White;
            this.pdToDate.GeorgianDate = null;
            this.pdToDate.Location = new System.Drawing.Point(13, 67);
            this.pdToDate.Margin = new System.Windows.Forms.Padding(0);
            this.pdToDate.Name = "pdToDate";
            this.pdToDate.PersianDate.Day = 0;
            this.pdToDate.PersianDate.Month = 0;
            this.pdToDate.PersianDate.Year = 0;
            this.pdToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pdToDate.Size = new System.Drawing.Size(288, 24);
            this.pdToDate.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.dgOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صفحه اصلی";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ایجادToolStripMenuItem;
        private ToolStripMenuItem btnEdit;
        private ToolStripMenuItem btnDelete;
        private ToolStripMenuItem btnSearch;
        private ToolStripMenuItem خروجToolStripMenuItem;
        private GroupBox groupBox1;
        private ComboBox cbCustomer;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgOrder;
        private DataGridViewTextBoxColumn InvoiceNumber;
        private DataGridViewTextBoxColumn PersonalName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn SumPrice;
        private PersianDatePicker pdFromDate;
        private PersianDatePicker pdToDate;
    }
}