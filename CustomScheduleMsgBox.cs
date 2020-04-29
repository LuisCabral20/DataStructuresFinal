using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    /// <summary>
    /// Create a custome message box that will be used as the final screen in checking out.
    /// </summary>
    public partial class CustomScheduleMsgBox : Form
    {
        private CheckOutUserControl CO = new CheckOutUserControl();     // CheckOutUserControl object

        /// <summary>
        /// CustomScheduleMsgBox Initialization
        /// </summary>
        public CustomScheduleMsgBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// AcceptButton click event that saves the users data into a text file called receipt and closes the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            //save data

            //Remove data from list

            //Messagebox show
            MessageBox.Show("Your order is complete");

            //close whole program
            System.Environment.Exit(1);
        }

        /// <summary>
        /// CustomScheduleMsgBox load event. The label values will be set.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomScheduleMsgBox_Load(object sender, EventArgs e)
        {
            string dayToRemove = CO.UserSelectedDay;    // Get users selected day
            int indexRemove = CO.SelectedTimeIndex;     // Get index of users selected time
            BindingList<string> temp;                   // Temp list to hold returend dictionary value
            CheckOutUserControl.dictionary.TryGetValue(dayToRemove, out temp);      // Trys to return a list using dayToRemove as a key

            //setting labels
            userContentLabel.Text = MainPanelForm.userName;
            totalContentLabel.Text = CO.CartSum.ToString();
            dayContentLabel.Text = dayToRemove;
            timeContentLabel.Text = temp.ElementAt(indexRemove).ToString();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}