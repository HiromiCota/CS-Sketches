namespace Shopping_Cart
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AudioBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShoppingCart = new System.Windows.Forms.MenuStrip();
            this.grpProducts.SuspendLayout();
            this.mnuShoppingCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.MistyRose;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(297, 154);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 31);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(330, 116);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(88, 22);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtShipping
            // 
            this.txtShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipping.Location = new System.Drawing.Point(330, 86);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.ReadOnly = true;
            this.txtShipping.Size = new System.Drawing.Size(88, 22);
            this.txtShipping.TabIndex = 7;
            this.txtShipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(330, 55);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(88, 22);
            this.txtTax.TabIndex = 6;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(330, 25);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(88, 22);
            this.txtSubtotal.TabIndex = 5;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(286, 119);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 16);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.Location = new System.Drawing.Point(264, 89);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(61, 16);
            this.lblShipping.TabIndex = 3;
            this.lblShipping.Text = "Shipping";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(294, 58);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 16);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax";
            // 
            // lstProducts
            // 
            this.lstProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 16;
            this.lstProducts.Location = new System.Drawing.Point(16, 19);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(235, 164);
            this.lstProducts.TabIndex = 0;
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.btnRemove);
            this.grpProducts.Controls.Add(this.txtTotal);
            this.grpProducts.Controls.Add(this.txtShipping);
            this.grpProducts.Controls.Add(this.txtTax);
            this.grpProducts.Controls.Add(this.txtSubtotal);
            this.grpProducts.Controls.Add(this.lblTotal);
            this.grpProducts.Controls.Add(this.lblShipping);
            this.grpProducts.Controls.Add(this.lblTax);
            this.grpProducts.Controls.Add(this.lblSubtotal);
            this.grpProducts.Controls.Add(this.lstProducts);
            this.grpProducts.Location = new System.Drawing.Point(25, 47);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(435, 203);
            this.grpProducts.TabIndex = 3;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Products Selected";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(268, 28);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(57, 16);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // AudioBooksToolStripMenuItem
            // 
            this.AudioBooksToolStripMenuItem.Name = "AudioBooksToolStripMenuItem";
            this.AudioBooksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AudioBooksToolStripMenuItem.Text = "&Audio Books";
            this.AudioBooksToolStripMenuItem.Click += new System.EventHandler(this.AudioBooksToolStripMenuItem_Click);
            // 
            // PrintBooksToolStripMenuItem
            // 
            this.PrintBooksToolStripMenuItem.Name = "PrintBooksToolStripMenuItem";
            this.PrintBooksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PrintBooksToolStripMenuItem.Text = "P&rint Books";
            this.PrintBooksToolStripMenuItem.Click += new System.EventHandler(this.PrintBooksToolStripMenuItem_Click);
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintBooksToolStripMenuItem,
            this.AudioBooksToolStripMenuItem});
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ProductsToolStripMenuItem.Text = "&Products";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFileExit.Size = new System.Drawing.Size(143, 22);
            this.mnuFileExit.Text = "E&xit";
            // 
            // mnuFileReset
            // 
            this.mnuFileReset.Name = "mnuFileReset";
            this.mnuFileReset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuFileReset.Size = new System.Drawing.Size(143, 22);
            this.mnuFileReset.Text = "&Reset";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileReset,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuShoppingCart
            // 
            this.mnuShoppingCart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.ProductsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.mnuShoppingCart.Location = new System.Drawing.Point(0, 0);
            this.mnuShoppingCart.Name = "mnuShoppingCart";
            this.mnuShoppingCart.Size = new System.Drawing.Size(484, 24);
            this.mnuShoppingCart.TabIndex = 2;
            this.mnuShoppingCart.Text = "MenuStrip1";
            // 
            // Cart
            // 
            this.AcceptButton = this.btnRemove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(484, 280);
            this.Controls.Add(this.grpProducts);
            this.Controls.Add(this.mnuShoppingCart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart System";
            this.grpProducts.ResumeLayout(false);
            this.grpProducts.PerformLayout();
            this.mnuShoppingCart.ResumeLayout(false);
            this.mnuShoppingCart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtShipping;
        internal System.Windows.Forms.TextBox txtTax;
        internal System.Windows.Forms.TextBox txtSubtotal;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label lblShipping;
        internal System.Windows.Forms.Label lblTax;
        internal System.Windows.Forms.ListBox lstProducts;
        internal System.Windows.Forms.GroupBox grpProducts;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AudioBooksToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PrintBooksToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        internal System.Windows.Forms.ToolStripMenuItem mnuFileReset;
        internal System.Windows.Forms.ToolStripMenuItem mnuFile;
        internal System.Windows.Forms.MenuStrip mnuShoppingCart;
    }
}

