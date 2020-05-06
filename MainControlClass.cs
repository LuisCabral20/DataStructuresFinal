using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DataStructuresFinal
{
    /// <summary>
    /// Class that holds the method to fill a content panel based on a userControl. And
    /// Methods that add and remove items from a lists.
    /// </summary>
    internal class MainControlClass
    {
        /// <summary>
        /// Adds a decimal price into a given list.
        /// </summary>
        /// <param name="inventory">The list where the items will be added</param>
        /// <param name="amountToAdd">How many of the itesm to be added</param>
        /// <param name="price">The item we are adding</param>
        public void AddToList(ConcurrentQueue<decimal> inventory, int amountToAdd, decimal price)
        {
            try
            {
                for (int i = 0; i < amountToAdd; i++)
                {
                    inventory.Enqueue(price);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Removes an item from a givent list
        /// </summary>
        /// <param name="inventory">The list we will be trying to remove from</param>
        public void RemoveFromList(ConcurrentQueue<decimal> inventory)
        {
            inventory.TryDequeue(out decimal removed);
        }

        /// <summary>
        /// Adds an item into the users cart.
        /// </summary>
        /// <param name="inventoryItem">The list where we will get the item to add</param>
        /// <param name="name">Name of the item</param>
        public void AddToCart(ConcurrentQueue<decimal> inventoryItem, String name)
        {
            // If items inventory is empty
            if (inventoryItem.Count == 0)
            {
                MessageBox.Show("Out of stock");
            }
            // Item has more inventory
            else
            {
                MainPanelForm MP = new MainPanelForm();
                inventoryItem.TryPeek(out decimal price);       // Gets the price from the list
                MP.ItemList.Add(new CartClass(name, price));    // Adds into the cart
                ListSort();                            //Sorting
            }
        }

        /// <summary>
        /// This method will fill the content of the form with a given usercontrol
        /// </summary>
        /// <param name="control">The user control to fill the content</param>
        /// <param name="content">A content panel that holds the work area</param>
        public static void ShowControl(System.Windows.Forms.Control control, System.Windows.Forms.Control content)
        {
            try
            {
                content.Controls.Clear();
                control.Dock = DockStyle.Fill;
                content.BringToFront();
                control.Focus();
                content.Controls.Add(control);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                System.Environment.Exit(1);
            }
        }

        public static void AddToList(string listName, decimal price)
        {
            MainPanelForm MP = new MainPanelForm();

            switch (listName)
            {
                case "Red Apple":
                    MP.RedApplesList.Enqueue(price);
                    break;

                case "Beans":
                    MP.BeansStockList.Enqueue(price);
                    break;

                case "Fruit Cocktail":
                    MP.FruitCocktailList.Enqueue(price);
                    break;

                case "Ravoili":
                    MP.RavioliList.Enqueue(price);
                    break;

                case "Lettuce":
                    MP.LettuceList.Enqueue(price);
                    break;

                case "Frozen Pizza":
                    MP.FrozenPizzaList.Enqueue(price);
                    break;

                case "Chicken Dinner":
                    MP.ChickenDinnerList.Enqueue(price);
                    break;

                case "Bananas":
                    MP.BananaList.Enqueue(price);
                    break;

                case "Chicken Breast":
                    MP.ChickenBreastList.Enqueue(price);
                    break;

                case "Salmon":
                    MP.SalmonList.Enqueue(price);
                    break;

                case "Chuck Roast Cut":
                    MP.ChuckRoastList.Enqueue(price);
                    break;

                case "Ice Cream":
                    MP.IceCreamList.Enqueue(price);
                    break;
            }
        }

        public static void ListSort()
        {
            MainPanelForm MP = new MainPanelForm();

            if (MP.ItemList.Count <=1)
            {
                return;
            }
            else
            {
                CartClass[] array = new CartClass[MP.ItemList.Count];
                MP.ItemList.CopyTo(array, 0);
                ArraySort(array);
                MP.ItemList.Clear();
                foreach (CartClass cart in array)
                {
                    MP.ItemList.Add(cart);
                }
            }
        }

        public static void ArraySort(CartClass[] arrayName)
        {
            for (int i = 0; i < arrayName.Length - i - 1; i++)
                if (arrayName[i].Price > arrayName[i + 1].Price)
                {
                    // swap
                    CartClass temp = arrayName[i];
                    arrayName[i] = arrayName[i + 1];
                    arrayName[i + 1] = temp;
                }
        }
    }
}