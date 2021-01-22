namespace Tabular
{
    partial class SalesView
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
            this.CustNo = new System.Windows.Forms.TextBox();
            this.CustomerNoLabel = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SalesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustNo
            // 
            this.CustNo.Location = new System.Drawing.Point(56, 18);
            this.CustNo.Name = "CustNo";
            this.CustNo.Size = new System.Drawing.Size(100, 20);
            this.CustNo.TabIndex = 4;
            this.CustNo.Leave += new System.EventHandler(this.CustNo_Leave);
            // 
            // CustomerNoLabel
            // 
            this.CustomerNoLabel.AutoSize = true;
            this.CustomerNoLabel.Location = new System.Drawing.Point(19, 21);
            this.CustomerNoLabel.Name = "CustomerNoLabel";
            this.CustomerNoLabel.Size = new System.Drawing.Size(35, 13);
            this.CustomerNoLabel.TabIndex = 3;
            this.CustomerNoLabel.Text = "Cust#";
            // 
            // CustName
            // 
            this.CustName.Location = new System.Drawing.Point(56, 44);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(100, 20);
            this.CustName.TabIndex = 6;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(19, 47);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 5;
            this.Namelabel.Text = "Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(239, 21);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SalesDataGridView
            // 
            this.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDataGridView.Location = new System.Drawing.Point(3, 85);
            this.SalesDataGridView.Name = "SalesDataGridView";
            this.SalesDataGridView.Size = new System.Drawing.Size(333, 150);
            this.SalesDataGridView.TabIndex = 8;
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SalesDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.CustNo);
            this.Controls.Add(this.CustomerNoLabel);
            this.Name = "SalesView";
            this.Size = new System.Drawing.Size(339, 238);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustNo;
        private System.Windows.Forms.Label CustomerNoLabel;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView SalesDataGridView;
    }
}
