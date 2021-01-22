namespace Tabular
{
    partial class ProductView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.PartName = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CustName = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.CustNo = new System.Windows.Forms.TextBox();
            this.CustomerNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Location = new System.Drawing.Point(12, 26);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(31, 13);
            this.PartsLabel.TabIndex = 1;
            this.PartsLabel.Text = "Parts";
            // 
            // PartName
            // 
            this.PartName.Location = new System.Drawing.Point(49, 23);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(100, 20);
            this.PartName.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(303, 21);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CustName
            // 
            this.CustName.Location = new System.Drawing.Point(197, 49);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(100, 20);
            this.CustName.TabIndex = 10;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(160, 52);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 9;
            this.Namelabel.Text = "Name";
            // 
            // CustNo
            // 
            this.CustNo.Location = new System.Drawing.Point(197, 23);
            this.CustNo.Name = "CustNo";
            this.CustNo.Size = new System.Drawing.Size(100, 20);
            this.CustNo.TabIndex = 8;
            // 
            // CustomerNoLabel
            // 
            this.CustomerNoLabel.AutoSize = true;
            this.CustomerNoLabel.Location = new System.Drawing.Point(160, 26);
            this.CustomerNoLabel.Name = "CustomerNoLabel";
            this.CustomerNoLabel.Size = new System.Drawing.Size(35, 13);
            this.CustomerNoLabel.TabIndex = 7;
            this.CustomerNoLabel.Text = "Cust#";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.CustNo);
            this.Controls.Add(this.CustomerNoLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PartName);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(398, 268);
            this.Load += new System.EventHandler(this.ProductView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.TextBox PartName;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox CustNo;
        private System.Windows.Forms.Label CustomerNoLabel;
    }
}
