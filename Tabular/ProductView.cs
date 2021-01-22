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
    public partial class ProductView : UserControl
    {
        public EventHandler Saved;
        public CustomerInfo _customerInfo;

        public ProductView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Parent.BackgroundImage = SystemIcons.Exclamation.ToBitmap();
            Saved?.Invoke(this, new EventArgs());
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            var main = (MainPage)this.Parent;
            _customerInfo = main.Customer;
            CustNo.Text = _customerInfo.CustomerNumber;
            CustName.Text = _customerInfo.CustomerName;
        }
    }
}
