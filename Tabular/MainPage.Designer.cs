namespace Tabular
{
    partial class MainPage
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
            this.SalesOrderTabs = new System.Windows.Forms.TabControl();
            this.SalesPage = new System.Windows.Forms.TabPage();
            this.salesView1 = new Tabular.SalesView();
            this.ProductPage = new System.Windows.Forms.TabPage();
            this.productView1 = new Tabular.ProductView();
            this.SalesOrderTabs.SuspendLayout();
            this.SalesPage.SuspendLayout();
            this.ProductPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesOrderTabs
            // 
            this.SalesOrderTabs.Controls.Add(this.SalesPage);
            this.SalesOrderTabs.Controls.Add(this.ProductPage);
            this.SalesOrderTabs.Location = new System.Drawing.Point(12, 12);
            this.SalesOrderTabs.Name = "SalesOrderTabs";
            this.SalesOrderTabs.SelectedIndex = 0;
            this.SalesOrderTabs.Size = new System.Drawing.Size(501, 330);
            this.SalesOrderTabs.TabIndex = 0;
            // 
            // SalesPage
            // 
            this.SalesPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalesPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesPage.Controls.Add(this.salesView1);
            this.SalesPage.Location = new System.Drawing.Point(4, 23);
            this.SalesPage.Name = "SalesPage";
            this.SalesPage.Padding = new System.Windows.Forms.Padding(3);
            this.SalesPage.Size = new System.Drawing.Size(493, 303);
            this.SalesPage.TabIndex = 0;
            this.SalesPage.Text = "Sales";
            this.SalesPage.UseVisualStyleBackColor = true;
            // 
            // salesView1
            // 
            this.salesView1.Location = new System.Drawing.Point(7, 7);
            this.salesView1.Name = "salesView1";
            this.salesView1.Size = new System.Drawing.Size(483, 294);
            this.salesView1.TabIndex = 0;
            this.salesView1.Load += new System.EventHandler(this.salesView1_Load);
            // 
            // ProductPage
            // 
            this.ProductPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPage.Controls.Add(this.productView1);
            this.ProductPage.Location = new System.Drawing.Point(4, 23);
            this.ProductPage.Name = "ProductPage";
            this.ProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductPage.Size = new System.Drawing.Size(493, 303);
            this.ProductPage.TabIndex = 1;
            this.ProductPage.Text = "Products";
            this.ProductPage.UseVisualStyleBackColor = true;
            // 
            // productView1
            // 
            this.productView1.Location = new System.Drawing.Point(7, 7);
            this.productView1.Name = "productView1";
            this.productView1.Size = new System.Drawing.Size(284, 268);
            this.productView1.TabIndex = 0;
            this.productView1.Load += new System.EventHandler(this.productView1_Load);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesOrderTabs);
            this.Name = "MainPage";
            this.Text = "Sales Data";
            this.SalesOrderTabs.ResumeLayout(false);
            this.SalesPage.ResumeLayout(false);
            this.ProductPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SalesOrderTabs;
        private System.Windows.Forms.TabPage SalesPage;
        private System.Windows.Forms.TabPage ProductPage;
        private SalesView salesView1;
        private ProductView productView1;
    }
}

