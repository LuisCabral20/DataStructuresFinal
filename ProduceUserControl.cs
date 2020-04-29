using System;
using System.Linq;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    /// <summary>
    /// UserControl representing selection of Produce to buy.
    /// </summary>
    public partial class ProduceUserControl : UserControl
    {
        // Creating objects of other class and forms
        private readonly MainControlClass mainControl = new MainControlClass();

        private readonly MainPanelForm mainPanel = new MainPanelForm();

        /// <summary>
        ///  Defalut constructor for the ProduceUserControl
        /// </summary>
        public ProduceUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ReturnButton click event that sets the content panel to show the CategoryUserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            CategoryUserControl cg = new CategoryUserControl();
            MainControlClass.ShowControl(cg, contentPanel);
        }

        /// <summary>
        /// Click event for the BananaBuyButton. Removes an item from the Banana list and
        /// Adds it into the cart. Then updates the items stock label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BananaBuyButton_Click(object sender, EventArgs e)
        {
            mainControl.AddToCart(mainPanel.BananaList, "Bananas");
            mainControl.RemoveFromList(mainPanel.BananaList);
            bananaStockLabel.Text = mainPanel.BananaList.Count().ToString();
        }

        /// <summary>
        /// Click event for the LettuceBuyButton. Removes an item from the Lettuce list and
        /// Adds it into the cart. Then updates the items stock label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LettuceBuyButton_Click(object sender, EventArgs e)
        {
            mainControl.AddToCart(mainPanel.LettuceList, "Lettuce");
            mainControl.RemoveFromList(mainPanel.LettuceList);
            lettuceLabel.Text = mainPanel.LettuceList.Count().ToString();
        }

        /// <summary>
        /// Click event for the AppleBuyButton. Removes an item from the Apple list and
        /// Adds it into the cart. Then updates the items stock label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppleBuyButton_Click(object sender, EventArgs e)
        {
            mainControl.AddToCart(mainPanel.RedApplesList, "Red Apple");
            mainControl.RemoveFromList(mainPanel.RedApplesList);
            appleStocklabel.Text = mainPanel.RedApplesList.Count().ToString();
        }

        /// <summary>
        /// Produce load event, sets the stock labels based on their item count.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProduceUserControl_Load(object sender, EventArgs e)
        {
            bananaStockLabel.Text = mainPanel.BananaList.Count().ToString();
            lettuceLabel.Text = mainPanel.LettuceList.Count().ToString();
            appleStocklabel.Text = mainPanel.RedApplesList.Count().ToString();
        }
    }
}