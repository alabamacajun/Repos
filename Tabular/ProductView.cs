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

        public ProductView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Parent.BackgroundImage = SystemIcons.Exclamation.ToBitmap();
            Saved?.Invoke(this, new EventArgs());
        }
    }
}
