using System;
using System.Linq;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    /// <summary>
    /// UserControl representing selection of frozen foods to buy.
    /// </summary>
    public partial class FrozenUserControl : UserControl
    {
        // Creating objects of other class and forms
        private readonly MainControlClass mainControl = new MainControlClass();

        private readonly MainPanelForm mainPanel = new MainPanelForm();

        /// <summary>
        /// Initialize of the frozenUserControl
        /// </summary>
        public FrozenUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ReturnButton click event that sets the content panel to show the CategoryUserControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            CategoryUserControl cg = new CategoryUserControl();
            MainControlClass.ShowControl(cg, contentPanel);
        }

        /// <summary>
        /// Click event for the pizzaBuyButton. Removes an item from the pizza list and
        /// Adds it into the cart. Then updates the items stock label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrozzenPizzaBuyButton_Click(object sender, EventArgs e)
        {
            mainControl.AddToCart(mainPanel.FrozenPizzaList, "Frozen Pizza");
            mainControl.RemoveFromList(mainPanel.FrozenPizzaList);
            frozzenPizzaStockLabel.Text = mainPanel.FrozenPizzaList.Count().ToString();
        }

        /// <summary>
        /// Click event for the FrozenChickenDinnerBuyButton. Removes an item from the FrozenChickenDinner list and
        /// Adds it into the cart. Then updates the items stock label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrozenChickenDinnerBuyButton_Click(object sender, EventArgs e)
        {
            mainControl.AddToCart(mainPanel.ChickenDinnerList, "Chicken Dinner");
            mainControl.RemoveFromList(mainPanel.ChickenDinnerList);
            frozenChickenDinnerLabel.Text = mainPanel.ChickenDinnerList.Count().ToString();
        }

        /// <summary>
        /// Click event for the IceCreamBuyButton. Removes an item from the IceCream list and
        /// Adds it into the cart. Then updates the items stock label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IceCreamBuyButton_Click(object sender, EventArgs e)
        {
            mainControl.AddToCart(mainPanel.IceCreamList, "Ice Cream");
            mainControl.RemoveFromList(mainPanel.IceCreamList);
            iceCreamStocklabel.Text = mainPanel.IceCreamList.Count().ToString();
        }

        /// <summary>
        /// FrozenUserControl load event, sets the stock labels based on their item count.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrozenUserControl_Load(object sender, EventArgs e)
        {
            frozzenPizzaStockLabel.Text = mainPanel.FrozenPizzaList.Count().ToString();
            frozenChickenDinnerLabel.Text = mainPanel.ChickenDinnerList.Count().ToString();
            iceCreamStocklabel.Text = mainPanel.IceCreamList.Count().ToString();
        }
    }
}