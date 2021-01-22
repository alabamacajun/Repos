using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabular
{
    public partial class MainPage : Form
    {
        private ImageList _iconImages;

        public CustomerInfo Customer;

        public MainPage()
        {
            Customer = new CustomerInfo();

            InitializeComponent();
            _iconImages = new ImageList();
            _iconImages.TransparentColor = Color.Blue;
            _iconImages.ColorDepth = ColorDepth.Depth32Bit;
            _iconImages.ImageSize = new Size(25, 25);
            _iconImages.Images.Add(Tabular.Resource1.blankImage);
            _iconImages.Images.Add(SystemIcons.Exclamation.ToBitmap());
            _iconImages.Images.Add(SystemIcons.Shield.ToBitmap());
            SalesOrderTabs.ImageList = _iconImages;
        }

        private void salesView1_Load(object sender, EventArgs e)
        {
            var s = (SalesView)sender;
            SalesOrderTabs.TabPages[0].ImageIndex = 0;
        }

        private void productView1_Load(object sender, EventArgs e)
        {
            var s = (ProductView)sender;
            SalesOrderTabs.TabPages[1].ImageIndex = 0;
        }
    }
}
