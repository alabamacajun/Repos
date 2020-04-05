using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabular
{
    public partial class SalesView : UserControl
    {
        public EventHandler Saved;

        public SalesView()
        {
            InitializeComponent();
        }

        private void SetChanged()
        {
            var parent = (TabPage)Parent;
            parent.ImageIndex = 1;
        }

        private void SetSaved()
        {
            var parent = (TabPage)Parent;
            parent.ImageIndex = 2;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SetSaved();
        }

        private void CustNo_Leave(object sender, EventArgs e)
        {
            if(CustNo.Text.Length > 0) SetChanged();
        }
    }
}
