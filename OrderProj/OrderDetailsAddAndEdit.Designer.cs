namespace OrderProj
{
    partial class OrderDetailsAddAndEdit
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
            this.btnSubmitOrderDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefuse = new System.Windows.Forms.ToolStripMenuItem();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.txtPriceSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSubmitOrderDetail,
            this.btnRefuse});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSubmitOrderDetail
            // 
            this.btnSubmitOrderDetail.Name = "btnSubmitOrderDetail";
            this.btnSubmitOrderDetail.Size = new System.Drawing.Size(46, 20);
            this.btnSubmitOrderDetail.Text = "ذخیره";
            this.btnSubmitOrderDetail.Click += new System.EventHandler(this.btnSubmitOrderDetail_Click);
            // 
            // btnRefuse
            // 
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(56, 20);
            this.btnRefuse.Text = "انصراف";
            this.btnRefuse.Click += new System.EventHandler(this.btnRefuse_Click);
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(41, 67);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(160, 23);
            this.cbProduct.TabIndex = 1;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Enabled = false;
            this.txt_UnitPrice.Location = new System.Drawing.Point(41, 110);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(160, 23);
            this.txt_UnitPrice.TabIndex = 2;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(41, 154);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(160, 23);
            this.txt_Count.TabIndex = 3;
            this.txt_Count.Text = "1";
            this.txt_Count.TextChanged += new System.EventHandler(this.txt_Count_TextChanged);
            // 
            // txtPriceSum
            // 
            this.txtPriceSum.Location = new System.Drawing.Point(41, 202);
            this.txtPriceSum.Name = "txtPriceSum";
            this.txtPriceSum.Size = new System.Drawing.Size(160, 23);
            this.txtPriceSum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "کالا:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "قیمت واحد:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "تعداد:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "جمع کل";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "ریال";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderDetailsAddAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 309);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriceSum);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderDetailsAddAndEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "OrderDetailsAddAndEdit";
            this.Load += new System.EventHandler(this.OrderDetailsAddAndEdit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnSubmitOrderDetail;
        private ToolStripMenuItem btnRefuse;
        private ComboBox cbProduct;
        private TextBox txt_UnitPrice;
        private TextBox txt_Count;
        private TextBox txtPriceSum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}