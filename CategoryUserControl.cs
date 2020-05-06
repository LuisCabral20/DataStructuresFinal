using System;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    /// <summary>
    /// Custom usercontrol that implments a food category
    /// selection screen.
    /// </summary>
    public partial class CategoryUserControl : UserControl
    {
        /// <summary>
        /// The defalut constrouctor for CategoryUserControl
        /// </summary>
        public CategoryUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Click event for the Frozen Category. This event will set the content panel
        /// to display the FrozenUserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrozenPictureBox_Click(object sender, EventArgs e)
        {
            CategoryUserControl cg = new CategoryUserControl();
            FrozenUserControl fz = new FrozenUserControl();
            MainControlClass.ShowControl(fz, contentPanel);
            cg.Dispose();
        }

        /// <summary>
        /// This is the Click event for the Produce Category. This event will set the content panel
        /// to display the ProduceUserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProducePictureBox_Click(object sender, EventArgs e)
        {
            CategoryUserControl cg = new CategoryUserControl();
            ProduceUserControl pd = new ProduceUserControl();
            MainControlClass.ShowControl(pd, contentPanel);
            cg.Dispose();
        }

        /// <summary>
        /// This is the Click event for the CanGoods Category. This event will set the content panel
        /// to display the CanUserControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CanGoodsPictureBox_Click(object sender, EventArgs e)
        {
            CategoryUserControl cg = new CategoryUserControl();
            CanUserControl cn = new CanUserControl();
            MainControlClass.ShowControl(cn, contentPanel);
            cg.Dispose();
        }

        /// <summary>
        /// This is the Click event for the Meat And Fish Category. This event will set the content panel
        /// to display the MeatUserControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeatAndFishPictureBox_Click(object sender, EventArgs e)
        {
            CategoryUserControl cg = new CategoryUserControl();
            MeatUserControl me = new MeatUserControl();
            MainControlClass.ShowControl(me, contentPanel);
            cg.Dispose();
        }

        /// <summary>
        /// This is the exit button click event. It will close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        /// <summary>
        /// CheckOutButton click event. Will Set the content panel to show the CheckOutUserControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            CheckOutUserControl co = new CheckOutUserControl();
            MainControlClass.ShowControl(co, contentPanel);
        }
    }
}