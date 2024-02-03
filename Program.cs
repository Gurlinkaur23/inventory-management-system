using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("- * - * - * - * - * - * - * - * - * - * - * - * - * -");
                Console.WriteLine("- - - - - - INVENTORY MANAGEMENT SYSTEM - - - - - -");
                Console.WriteLine("- * - * - * - * - * - * - * - * - * - * - * - * - * -");
                Console.WriteLine();

                // Making a list to store different products
                List<Products> productsList = new List<Products>();

                // Creating objects from different classes
                Inventory inventory = new Inventory(productsList);
                Transactions transactions = new Transactions(productsList);
                Program program = new Program();

                // Creating clothing products
                Clothing clothingProduct1 = new Clothing("Shirt", 1, 5, 18.75m, "Gucci", "Small");
                Clothing clothingProduct2 = new Clothing("Jeans", 2, 10, 20, "LV", "Medium");
                Clothing clothingProduct3 = new Clothing("Hoodies", 3, 8, 25, "Gap", "Large");

                // Creating electronic products
                Electronics electronicsProduct1 = new Electronics("TV", 11, 14, 150.50m, 5, "Philips");
                Electronics electronicsProduct2 = new Electronics("Refrigerator", 12, 6, 99.99m, 8, "LG");
                Electronics electronicsProduct3 = new Electronics("Mobile Phone", 13, 25, 500, 4, "IPhone");

                // Creating Grocery products
                Grocery groceryProduct1 = new Grocery("Red Onions", 21, 100, 2.75m, DateTime.Now.AddDays(10));
                Grocery groceryProduct2 = new Grocery("Gala Apples", 22, 50, 1.50m, DateTime.Now.AddDays(5));
                Grocery groceryProduct3 = new Grocery("Milk", 23, 20, 6, DateTime.Now.AddDays(5));

                // Adding the products to the inventory
                inventory.AddProducts(clothingProduct1);
                inventory.AddProducts(clothingProduct2);
                inventory.AddProducts(clothingProduct3);
                inventory.AddProducts(electronicsProduct1);
                inventory.AddProducts(electronicsProduct2);
                inventory.AddProducts(electronicsProduct3);
                inventory.AddProducts(groceryProduct1);
                inventory.AddProducts(groceryProduct2);
                inventory.AddProducts(groceryProduct3);

                // Displaying the current products in the inventory 
                program.DisplayProductsInInventory(productsList);

                // Removing the products from the inventory
                inventory.RemoveProducts(1);
                inventory.RemoveProducts(23);

                // Displaying the current products in the inventory
                program.DisplayProductsInInventory(productsList);

                // Updating the product information
                inventory.UpdateProductInformation(2, "Trousers", 15, 20.75m);

                // Displaying the current products in the inventory
                program.DisplayProductsInInventory(productsList);

                // Processing transactions
                transactions.ProcessTransactions(groceryProduct3, 10, groceryProduct3.CalculateDiscount(), "Red Onions");

                // Displaying the current products in the inventory
                program.DisplayProductsInInventory(productsList);

                Console.ReadKey();

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        /// <summary>
        /// This method displays the product details in the inventory to the console by looping through the
        /// list of products in the inventory.
        /// </summary>
        /// <param name="productsList"></param>
        public void DisplayProductsInInventory(List<Products> productsList)
        {
            Console.WriteLine("Current Products in Inventory:");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");

            foreach (var product in productsList)
            {
                Console.WriteLine($"Product ID: {product.GetSetProductId}");
                Console.WriteLine($"Product Name: {product.GetSetProductName}");
                Console.WriteLine($"Quantity: {product.GetSetQuantity}");
                Console.WriteLine($"Price: {product.GetSetPrice:C}");
                Console.WriteLine();
                Console.WriteLine("- * - * - * - * - * - * - * - * - * - * - * - * - * -");
                Console.WriteLine();
            }
        }
    }
}
