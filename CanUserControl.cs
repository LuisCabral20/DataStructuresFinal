using System;
using System.Linq;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    /// <summary>
    /// Implments the can user control
    /// </summary>
    public partial class CanUserControl : UserControl
    {
        //== Create Objects ==
        private readonly MainControlClass MC = new MainControlClass();

        private readonly MainPanelForm MP = new MainPanelForm();

        /// <summary>
        /// CanUserControl default constructor that initializes the component.
        /// </summary>
        public CanUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the form back to the checkout usercontrol.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            CategoryUserControl cg = new CategoryUserControl();
            MainControlClass.ShowControl(cg, contentPanel);
        }

        /// <summary>
        /// Sets the stock text to the items current stock onload of the userControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CanUserControl_Load(object sender, EventArgs e)
        {
            ravioliStocklabel.Text = MP.RavioliList.Count().ToString();
            fruitCocktailLabel.Text = MP.FruitCocktailList.Count().ToString();
            beansStockLabel.Text = MP.BeansStockList.Count().ToString();
        }

        /// <summary>
        /// This is the Click event for the Ravioli buy button. It takes an item in the
        /// ravioli list and adds it to the user cart list. Then it updates the raviolis
        /// stock text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RavioliBuyButton_Click(object sender, EventArgs e)
        {
            MC.AddToCart(MP.RavioliList, "Ravoili");
            MC.RemoveFromList(MP.RavioliList);
            ravioliStocklabel.Text = MP.RavioliList.Count().ToString();
        }

        /// <summary>
        /// This is the Click event for the Fruit Cocktail buy button. It takes an item in the
        /// Fruit Cocktail list and adds it to the user cart list. Then it updates the Fruit Cocktails
        /// stock text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FruitCocktailBuyButton_Click(object sender, EventArgs e)
        {
            MC.AddToCart(MP.FruitCocktailList, "Fruit Cocktail");
            MC.RemoveFromList(MP.FruitCocktailList);
            fruitCocktailLabel.Text = MP.FruitCocktailList.Count().ToString();
        }

        /// <summary>
        /// This is the Click event for the Beans buy button. It takes an item in the
        /// Beans list and adds it to the user cart list. Then it updates the Beans
        /// stock text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeansBuyButton_Click(object sender, EventArgs e)
        {
            MC.AddToCart(MP.BeansStockList, "Beans");
            MC.RemoveFromList(MP.BeansStockList);
            beansStockLabel.Text = MP.BeansStockList.Count().ToString();
        }
    }
}