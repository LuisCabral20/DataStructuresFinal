using System;
using System.Linq;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    /// <summary>
    /// UserControl representing selection of meats and fish to buy
    /// </summary>
    public partial class MeatUserControl : UserControl
    {
        // Creating objects of other class and forms
        private readonly MainControlClass mainControl = new MainControlClass();

        private readonly MainPanelForm mainPanel = new MainPanelForm();

        /// <summary>
        /// Defalut constructor for the meatUserControl
        /// </summary>
        public MeatUserControl()
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
        /// MeatUserControl load event, sets the stock labels based on their item count.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeatUserControl_Load(object sender, EventArgs e)
        {
            salmonStockLabel.Text = mainPanel.SalmonList.Count().ToString();
            chickenBreastLabel.Text = mainPanel.ChickenBreastList.Count().ToString();
            chuckRoastStocklabel.Text = mainPanel.ChuckRoastList.Count().ToString();
        }

        /// <summary>
        /// Click event for the ChuckRoastBuyButton. Removes an item from the ChuckRoast list and
        /// Adds it into the cart. Then updates the items stock label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChuckRoastBuyButton_Click(object sender, EventArgs e)
        {
            mainControl.AddToCart(mainPanel.ChuckRoastList, "Chuck Roast Cut");
            mainControl.RemoveFromList(mainPanel.ChuckRoastList);
            chuckRoastStocklabel.Text = mainPanel.ChuckRoastList.Count().ToString();
        }

        /// <summary>
        /// Click event for the ChickenBreastBuyButton. Removes an item from the ChickenBreast list and
        /// Adds it into the cart. Then updates the items stock label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChickenBreastBuyButton_Click(object sender, EventArgs e)
        {
            mainControl.AddToCart(mainPanel.ChickenBreastList, "Chicken Breast");
            mainControl.RemoveFromList(mainPanel.ChickenBreastList);
            chickenBreastLabel.Text = mainPanel.ChickenBreastList.Count().ToString();
        }

        /// <summary>
        /// Click event for the SalmonBuyButton. Removes an item from the Salmon list and
        /// Adds it into the cart. Then updates the items stock label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalmonBuyButton_Click(object sender, EventArgs e)
        {
            mainControl.AddToCart(mainPanel.SalmonList, "Salmon");
            mainControl.RemoveFromList(mainPanel.SalmonList);
            salmonStockLabel.Text = mainPanel.SalmonList.Count().ToString();
        }
    }
}