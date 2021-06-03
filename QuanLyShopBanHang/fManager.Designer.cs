namespace QuanLyShopBanHang
{
    partial class fManager
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
            this.flpProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbSwitchSize = new System.Windows.Forms.ComboBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.nudDisCount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ltvBill = new System.Windows.Forms.ListView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisCount)).BeginInit();
            this.panel5.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProduct
            // 
            this.flpProduct.Location = new System.Drawing.Point(8, 36);
            this.flpProduct.Name = "flpProduct";
            this.flpProduct.Size = new System.Drawing.Size(499, 391);
            this.flpProduct.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.nmFoodCount);
            this.panel7.Controls.Add(this.btnAddFood);
            this.panel7.Controls.Add(this.cbProduct);
            this.panel7.Controls.Add(this.cbCategory);
            this.panel7.Location = new System.Drawing.Point(513, 36);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(339, 64);
            this.panel7.TabIndex = 9;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(282, 20);
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(53, 20);
            this.nmFoodCount.TabIndex = 2;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(201, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 48);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm sản phẩm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(4, 31);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(191, 21);
            this.cbProduct.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(191, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbSwitchSize);
            this.panel6.Controls.Add(this.btnSwitchTable);
            this.panel6.Controls.Add(this.nudDisCount);
            this.panel6.Controls.Add(this.btnDiscount);
            this.panel6.Controls.Add(this.btnCheckOut);
            this.panel6.Location = new System.Drawing.Point(513, 373);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 54);
            this.panel6.TabIndex = 8;
            // 
            // cbSwitchSize
            // 
            this.cbSwitchSize.FormattingEnabled = true;
            this.cbSwitchSize.Location = new System.Drawing.Point(4, 30);
            this.cbSwitchSize.Name = "cbSwitchSize";
            this.cbSwitchSize.Size = new System.Drawing.Size(75, 21);
            this.cbSwitchSize.TabIndex = 3;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(4, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(75, 25);
            this.btnSwitchTable.TabIndex = 5;
            this.btnSwitchTable.Text = "Kính cở";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nudDisCount
            // 
            this.nudDisCount.Location = new System.Drawing.Point(129, 31);
            this.nudDisCount.Name = "nudDisCount";
            this.nudDisCount.Size = new System.Drawing.Size(75, 20);
            this.nudDisCount.TabIndex = 3;
            this.nudDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(129, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 25);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(260, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 48);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ltvBill);
            this.panel5.Location = new System.Drawing.Point(513, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 261);
            this.panel5.TabIndex = 7;
            // 
            // ltvBill
            // 
            this.ltvBill.Location = new System.Drawing.Point(4, 4);
            this.ltvBill.Name = "ltvBill";
            this.ltvBill.Size = new System.Drawing.Size(332, 254);
            this.ltvBill.TabIndex = 0;
            this.ltvBill.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(877, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Admin";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.AdmintoolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(123, 20);
            this.toolStripMenuItem2.Text = "Thông tin tài khoản";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ThôngTinTaiKhoantoolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem4.Text = "Thông tin cá nhân";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem5.Text = "Đăng xuất";
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 477);
            this.Controls.Add(this.flpProduct);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.menuStrip2);
            this.Name = "fManager";
            this.Text = "fManager";
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDisCount)).EndInit();
            this.panel5.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProduct;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbSwitchSize;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.NumericUpDown nudDisCount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView ltvBill;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}