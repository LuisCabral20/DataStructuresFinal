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
    public partial class CategoryUserControl : UserControl
    {

        public CategoryUserControl()
        {
            InitializeComponent();
        }

        private void frozenPictureBox_Click(object sender, EventArgs e)
        {
            //TODO
            //add click events for all foods
            FrozenUserControl fz = new FrozenUserControl();
            MainControlClass.showControl(fz, contentPanel);

        }

        private void producePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void canGoodsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void meatAndFishPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
