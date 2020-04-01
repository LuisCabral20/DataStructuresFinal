using System;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    public partial class CategoryUserControl : UserControl
    {

        public CategoryUserControl()
        {
            InitializeComponent();
        }

        private void FrozenPictureBox_Click(object sender, EventArgs e)
        {
            FrozenUserControl fz = new FrozenUserControl();
            MainControlClass.showControl(fz, contentPanel);
        }

        private void producePictureBox_Click(object sender, EventArgs e)
        {
            ProduceUserControl pd = new ProduceUserControl();
            MainControlClass.showControl(pd, contentPanel);
        }

        private void canGoodsPictureBox_Click(object sender, EventArgs e)
        {
            CanUserControl cn = new CanUserControl();
            MainControlClass.showControl(cn, contentPanel);
        }

        private void meatAndFishPictureBox_Click(object sender, EventArgs e)
        {
            MeatUserControl me = new MeatUserControl();
            MainControlClass.showControl(me, contentPanel);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            CheckOutUserControl co = new CheckOutUserControl();
            MainControlClass.showControl(co, contentPanel);
        }
    }
}