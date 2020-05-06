using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    /// <summary>
    /// Usercontrol to simulate a checkout screen.
    /// </summary>
    public partial class CheckOutUserControl : UserControl
    {
        //=======Class varibles======
        private MainPanelForm MP = new MainPanelForm();         //Creates an object of the MainPanelForm

        private static decimal cartSum = 0m;            // Will hold the total amount of all items in the cart
        private static int selectedTimeIndex = -1;      // Will hold the index of the day selected by the user
        private static string userSelectedDay = "";     // Will hold the day selected by the user
        private static Boolean hoursLoadedFlag = false; // Flag to detrmin if lists and dictionary need to be populated
        private bool isCartEmpty;                       // Flag to detrmin if there is anything in the users cart

        //Lists to represent days of the week
        private static BindingList<string> monday = new BindingList<string>();
        private static BindingList<string> tuesday = new BindingList<string>();
        private static BindingList<string> wednesday = new BindingList<string>();
        private static BindingList<string> thursday = new BindingList<string>();
        private static BindingList<string> friday = new BindingList<string>();
        private static BindingList<string> saturday = new BindingList<string>();

        /// <summary>
        /// Dictionary that take in a string and a Bindinglist. The key will be one of the days of the week
        /// reresented as a string and its value will be a list holding available times for that day.
        /// </summary>
        public static Dictionary<string, BindingList<string>> dictionary = new Dictionary<string, BindingList<string>>();

        //=====================

        /// <summary>
        /// initialization of the checkout user control
        /// </summary>
        public CheckOutUserControl()
        {
            InitializeComponent();

            // Check if cart is empty
            isCartEmpty = MP.ItemList.Any();

            // If the hoursloaded flag is flase
            // the load the times into them
            // add the lists into a dictionary
            // set flag to true
            if (hoursLoadedFlag == false)
            {
                AddDefalutHours(ref monday);
                AddDefalutHours(ref tuesday);
                AddDefalutHours(ref wednesday);
                AddDefalutHours(ref thursday);
                AddDefalutHours(ref friday);
                AddDefalutHours(ref saturday);
                dictionary.Add("Monday", monday);
                dictionary.Add("Tuesday", tuesday);
                dictionary.Add("Wednesday", wednesday);
                dictionary.Add("Thursday", thursday);
                dictionary.Add("Friday", friday);
                dictionary.Add("Saturday", saturday);
                hoursLoadedFlag = true;
            }

            // For Design
            // if the cart is not empty
            // make emptycart img and label not visible
            // Set the total title and lable visible
            if (isCartEmpty == true)
            {
                emptyCartLabel.Visible = false;
                emptyCartPictureBox.Visible = false;
                totalPrintLabel.Visible = true;
                totalTitleLabel.Visible = true;
            }

            //========Loading the cart data=======
            cartDataGridView.AutoGenerateColumns = true;
            var Source = new BindingSource();
            Source.DataSource = MP.ItemList; // Sets the dataGridViews datasource to the
            cartDataGridView.DataSource = Source;
            //=====================================

            //======Styling the datagridView=======
            cartDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 22, 39);
            cartDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Bauhaus 93", 14f);
            this.cartDataGridView.DefaultCellStyle.Font = new Font("Bauhaus 93", 10f);
            cartDataGridView.EnableHeadersVisualStyles = false;

            //Adding delete button to the table
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            cartDataGridView.Columns.Add(btn);
            btn.HeaderText = " ";
            btn.Name = "Delete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            //========================================

            SettingTheSum(1);       //Sets the sum label
        }

        /// <summary>
        /// Checkout return button click event.
        /// shows the CategoryUserControl in the main content panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            CategoryUserControl cg = new CategoryUserControl();
            MainControlClass.ShowControl(cg, contentPanel);
        }

        /// <summary>
        /// CheckoutButton click event that will make sure the user has entered all
        /// necessary data before opening the final checkout messagebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            // Check if cart is empty
            if (MP.ItemList.Count == 0)
            {
                // Changed visiability on items it the checkOut split container
                MessageBox.Show("Your cart is Empty");
                emptyCartLabel.Visible = true;
                emptyCartPictureBox.Visible = true;
                totalPrintLabel.Visible = false;
                totalTitleLabel.Visible = false;
            }
            else
            {
                // Default day is monday
                // Make sure time is selected
                if (timePickComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Pick a Time");
                }
                else
                {
                    // Time is selected
                    // Save selected time so you can potentially remove it in the CustomScheduleMsgBox
                    // Save selcted day index so it can potentially be removed in the CustomScheduleMsgBox
                    userSelectedDay = dayPickComboBox.SelectedItem.ToString();
                    selectedTimeIndex = timePickComboBox.SelectedIndex;

                    // Open the final CustomScheduleMsgBox control
                    CustomScheduleMsgBox cs = new CustomScheduleMsgBox();
                    cs.Show();
                    cs.Focus();
                }
            }
        }

        /// <summary>
        /// Click event for a cell in the cartdatagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the cart has 1 item in it
            // Then the next click event means the cart will be empty
            // So change the visiability on items it the checkOut split container
            if (MP.ItemList.Count == 1)
            {
                emptyCartLabel.Visible = true;
                emptyCartPictureBox.Visible = true;
                totalPrintLabel.Visible = false;
                totalTitleLabel.Visible = false;
            }

            // CoulumnIndex 0 is the delete button column
            // If the delete button is clicked then
            // Remove the slected row
            // Refresh the cart
            // Update the sum
            if (cartDataGridView.CurrentCell.ColumnIndex.Equals(0))
            {
                //get name
                int namePriceIndex = cartDataGridView.CurrentCell.RowIndex;
                string nameAdd = cartDataGridView.Rows[namePriceIndex].Cells[1].Value.ToString();
                decimal priceAdd = (decimal)cartDataGridView.Rows[namePriceIndex].Cells[2].Value;

                //add back to stock
                MainControlClass.AddToList(nameAdd, priceAdd);
                MP.ItemList.RemoveAt(cartDataGridView.CurrentCell.RowIndex);

                var Source = new BindingSource();
                Source.DataSource = MP.ItemList; // Sets the dataGridViews datasource to the
                cartDataGridView.DataSource = Source;
                cartDataGridView.Refresh();
                SettingTheSum(2);   // The sum coulmn index is at 2.
            }
        }

        /// <summary>
        /// checkOutUserControl load event. Sets the time combobox content equal to Mondays available times.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckOutUserControl_Load(object sender, EventArgs e)
        {
            // Default day is monday
            // Get list items from monday
            // Add into the time combo box
            foreach (string hours in monday)
            {
                timePickComboBox.Items.Add(hours);
            }
        }

        /// <summary>
        /// Change event for the dayComboBox. Updates the timeComboBox based on the selecteed day.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DayPickComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dayToGet = dayPickComboBox.SelectedItem.ToString();  // Get names of selected day
            BindingList<string> temp;                                   // Temp Binding list to keep selected day values
            dictionary.TryGetValue(dayToGet, out temp);                 // Try to get a list using the dayToGet string as a key
            timePickComboBox.Items.Clear();                             // Clear any time currently in the timeComboBox so they dont duplicate

            // Loop to add items into the string
            foreach (string hours in temp)
            {
                timePickComboBox.Items.Add(hours);
            }
        }

        //========Methods=========
        /// <summary>
        /// Adds strings reresenting available time in to the referenced list.
        /// </summary>
        /// <param name="days">The list being referenced</param>
        public void AddDefalutHours(ref BindingList<string> days)
        {
            days.Add("1PM");
            days.Add("2PM");
            days.Add("3PM");
            days.Add("4PM");
            days.Add("5PM");
            days.Add("6PM");
        }

        /// <summary>
        /// Calculates the sum of each item in the given cellValue
        /// </summary>
        /// <param name="cellValue">The cells we want to sum</param>
        public void SettingTheSum(int cellValue)
        {
            cartSum = 0m;   //Resetting the sum to 0

            // Loop to get the sum of all items in the selected cells
            for (int i = 0; i < cartDataGridView.Rows.Count; ++i)
            {
                cartSum += Convert.ToDecimal(cartDataGridView.Rows[i].Cells[cellValue].Value);
            }
            totalPrintLabel.Text = cartSum.ToString();  // Printing to the total label
        }

        //=========================

        //====Getters and setters====
        /// <summary>
        /// Getter and setter for userSelectedDay variable
        /// </summary>
        public string UserSelectedDay
        {
            get { return userSelectedDay; }
            set { userSelectedDay = value; }
        }

        /// <summary>
        /// Getter and setter for selectedTimeIndex variable
        /// </summary>
        public int SelectedTimeIndex
        {
            get { return selectedTimeIndex; }
            set { selectedTimeIndex = value; }
        }

        /// <summary>
        /// Getter and setter for cartSum variable
        /// </summary>
        public decimal CartSum
        {
            get { return cartSum; }
            set { cartSum = value; }
        }

        //===========================
    }
}