using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Collections.Concurrent;
using System.Threading;

namespace DataStructuresFinal
{
    /// <summary>
    /// Creates lists to hold fodd items stock and a binding list to hold CartClass objects.
    /// And it implments a login screen.
    /// </summary>
    public partial class MainPanelForm : Form
    {
        //==Data Structures to hold the inventory==
        /// <summary>
        /// Holds the userName entered by the user
        /// </summary>
        public static string userName;
        static Boolean inventoryLoaded = false;
        private static List<CartClass> itemList = new List<CartClass>();

        //Produce
        private static ConcurrentQueue<decimal> redApplesList = new ConcurrentQueue<decimal>();
        private static ConcurrentQueue<decimal> lettuceList = new ConcurrentQueue<decimal>();
        private static ConcurrentQueue<decimal> bananaList = new ConcurrentQueue<decimal>();

        //Meat
        private static ConcurrentQueue<decimal> chuckRoastList = new ConcurrentQueue<decimal>();
        private static ConcurrentQueue<decimal> chickenBreastList = new ConcurrentQueue<decimal>();
        private static ConcurrentQueue<decimal> salmonList = new ConcurrentQueue<decimal>();

        //Frozen
        private static ConcurrentQueue<decimal> iceCreamList = new ConcurrentQueue<decimal>();
        private static ConcurrentQueue<decimal> chickenDinnerList = new ConcurrentQueue<decimal>();
        private static ConcurrentQueue<decimal> frozenPizzaList = new ConcurrentQueue<decimal>();

        //Cans
        private static ConcurrentQueue<decimal> ravioliList = new ConcurrentQueue<decimal>();
        private static ConcurrentQueue<decimal> fruitCocktailList = new ConcurrentQueue<decimal>();
        private static ConcurrentQueue<decimal> beansStockList = new ConcurrentQueue<decimal>();
        //=========================================

        /// <summary>
        /// MainPanelForm Initialization that adds items to the list if they are empty.
        /// </summary>
        public MainPanelForm()
        {
            InitializeComponent();

            MainControlClass mainControl = new MainControlClass();

            // Load items if inventoryLoaded is false
            if (inventoryLoaded == false)
            {
                mainControl.AddToList(RedApplesList, 10, .25m);
                mainControl.AddToList(LettuceList, 10, 1.00m);
                mainControl.AddToList(BananaList, 10, 2.25m);
                mainControl.AddToList(ChuckRoastList, 10, 7.00m);
                mainControl.AddToList(ChickenBreastList, 10, 4.50m);
                mainControl.AddToList(SalmonList, 10, 5.99m);
                mainControl.AddToList(IceCreamList, 10, 10.00m);
                mainControl.AddToList(ChickenDinnerList, 10, 2.25m);
                mainControl.AddToList(FrozenPizzaList, 10, 1.99m);
                mainControl.AddToList(RavioliList, 10, .50m);
                mainControl.AddToList(FruitCocktailList, 10, .25m);
                mainControl.AddToList(BeansStockList, 10, .25m);
                inventoryLoaded = true;     // Set inventoryLoaded to true
            }
            
        }

        /// <summary>
        /// LoginButton click event. Check if user enterd something in the username and password text boxes then
        /// loads the CategoryUserControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginEmailTextBox.Text) && string.IsNullOrWhiteSpace(loginPasswordTextBox.Text))
            {
                MessageBox.Show("Enter You Username or password.");
            }
            else
            {
                //Loading the CategoryUserControl 
                CategoryUserControl ca = new CategoryUserControl();
                MainControlClass.ShowControl(ca, contentPanel);

                //make user enter info
                userName = loginEmailTextBox.Text;
            }
        }
        
        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Exits the form
        }

        //====Getters Setters=====
        /// <summary>
        /// Getter and setter for the redApplesList
        /// </summary>
        public ConcurrentQueue<decimal> RedApplesList
        {
            get { return redApplesList; }
            set { redApplesList = value; }
        }

        /// <summary>
        /// Getter and setter for the lettuceList
        /// </summary>
        public ConcurrentQueue<decimal> LettuceList
        {
            get { return lettuceList; }
            set { lettuceList = value; }
        }

        /// <summary>
        /// Getter and setter for the bananaList
        /// </summary>
        public ConcurrentQueue<decimal> BananaList
        {
            get { return bananaList; }
            set { bananaList = value; }
        }

        /// <summary>
        /// Getter and setter for the chuckRoastList
        /// </summary>
        public ConcurrentQueue<decimal> ChuckRoastList
        {
            get { return chuckRoastList; }
            set { chuckRoastList = value; }
        }

        /// <summary>
        /// Getter and setter for the chickenBreastList
        /// </summary>
        public ConcurrentQueue<decimal> ChickenBreastList
        {
            get { return chickenBreastList; }
            set { chickenBreastList = value; }
        }

        /// <summary>
        /// Getter and setter for the salmonList
        /// </summary>
        public ConcurrentQueue<decimal> SalmonList
        {
            get { return salmonList; }
            set { salmonList = value; }
        }

        /// <summary>
        /// Getter and setter for the iceCreamList
        /// </summary>
        public ConcurrentQueue<decimal> IceCreamList
        {
            get { return iceCreamList; }
            set { iceCreamList = value; }
        }

        /// <summary>
        /// Getter and setter for the chickenDinnerList
        /// </summary>
        public ConcurrentQueue<decimal> ChickenDinnerList
        {
            get { return chickenDinnerList; }
            set { chickenDinnerList = value; }
        }

        /// <summary>
        /// Getter and setter for the frozenPizzaList
        /// </summary>
        public ConcurrentQueue<decimal> FrozenPizzaList
        {
            get { return frozenPizzaList; }
            set { frozenPizzaList = value; }
        }

        /// <summary>
        /// Getter and setter for the ravioliList
        /// </summary>
        public ConcurrentQueue<decimal> RavioliList
        {
            get { return ravioliList; }
            set { ravioliList = value; }
        }

        /// <summary>
        /// Getter and setter for the fruitCocktailList
        /// </summary>
        public ConcurrentQueue<decimal> FruitCocktailList
        {
            get { return fruitCocktailList; }
            set { fruitCocktailList = value; }
        }

        /// <summary>
        /// Getter and setter for the beansStockList
        /// </summary>
        public ConcurrentQueue<decimal> BeansStockList
        {
            get { return beansStockList; }
            set { beansStockList = value; }
        }

        /// <summary>
        /// Getter and setter for the 
        /// </summary>
        public List<CartClass> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }
        //========================
    }
}