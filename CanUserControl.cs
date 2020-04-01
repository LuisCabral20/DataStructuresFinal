using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    public partial class CanUserControl : UserControl
    {
        public CanUserControl()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            CategoryUserControl cg = new CategoryUserControl();
            MainControlClass.showControl(cg, contentPanel);
        }
    }
}
