namespace OrderProj
{
    partial class OrderAddAndEdit
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_submit = new System.Windows.Forms.ToolStripMenuItem();
            this.انصرافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.dgOrderItem = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DPDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_submit,
            this.انصرافToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_submit
            // 
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(68, 20);
            this.btn_submit.Text = "ثبت نهایی";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // انصرافToolStripMenuItem
            // 
            this.انصرافToolStripMenuItem.Name = "انصرافToolStripMenuItem";
            this.انصرافToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.انصرافToolStripMenuItem.Text = "انصراف";
            this.انصرافToolStripMenuItem.Click += new System.EventHandler(this.Refuse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاریخ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "مشتری:";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(415, 34);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(158, 23);
            this.cbCustomer.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(373, 103);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(156, 33);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "ایجاد";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackColor = System.Drawing.Color.Orange;
            this.btnEditItem.Location = new System.Drawing.Point(250, 103);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(116, 33);
            this.btnEditItem.TabIndex = 3;
            this.btnEditItem.Text = "ویرایش";
            this.btnEditItem.UseVisualStyleBackColor = false;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.Location = new System.Drawing.Point(165, 103);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(79, 33);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "حذف";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // dgOrderItem
            // 
            this.dgOrderItem.AllowUserToAddRows = false;
            this.dgOrderItem.AllowUserToDeleteRows = false;
            this.dgOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductCode,
            this.UnitPrice,
            this.Count,
            this.SumPrice});
            this.dgOrderItem.Location = new System.Drawing.Point(6, 147);
            this.dgOrderItem.Name = "dgOrderItem";
            this.dgOrderItem.ReadOnly = true;
            this.dgOrderItem.RowTemplate.Height = 25;
            this.dgOrderItem.Size = new System.Drawing.Size(671, 256);
            this.dgOrderItem.TabIndex = 5;
            this.dgOrderItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderItem_CellClick);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "نام محصول";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "کد محصول";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "مبلغ واحد";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "تعداد";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // SumPrice
            // 
            this.SumPrice.HeaderText = "جمع کل";
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DPDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgOrderItem);
            this.groupBox2.Controls.Add(this.btnDeleteItem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnEditItem);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.cbCustomer);
            this.groupBox2.Location = new System.Drawing.Point(25, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 411);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات سفارش";
            // 
            // DPDate
            // 
            this.DPDate.Location = new System.Drawing.Point(66, 33);
            this.DPDate.Name = "DPDate";
            this.DPDate.Size = new System.Drawing.Size(200, 23);
            this.DPDate.TabIndex = 6;
            // 
            // OrderAddAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderAddAndEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ایجاد سفارش جدید";
            this.Load += new System.EventHandler(this.OrderAddAndEdit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btn_submit;
        private ToolStripMenuItem انصرافToolStripMenuItem;
        private Label label2;
        private Label label1;
        private ComboBox cbCustomer;
        private Button btnCreate;
        private Button btnEditItem;
        private Button btnDeleteItem;
        private DataGridView dgOrderItem;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn SumPrice;
        private DateTimePicker DPDate;
    }
}