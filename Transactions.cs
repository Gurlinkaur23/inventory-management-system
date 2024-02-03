using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    /// <summary>
    /// This class is responsible for performing various transactions of the products in the inventory
    /// </summary>
    internal class Transactions
    {
        /// <summary>
        /// List of products in the inventory is encapsulated and is kept internal, which means that it will only be
        /// accessible within the same assembly.
        /// </summary>
        internal List<Products> ProductsList { get; set; }

        /// <summary>
        /// Parameterized constructor of the Transactions class. It initializes the List of products in the inventory.
        /// </summary>
        /// <param name="productsList"></param>
        public Transactions(List<Products> productsList)
        {
            ProductsList = productsList;
        }

        /// <summary>
        /// This method contains the functionality for the transaction process. It takes in the product and some product
        /// details as parameters. First it checks if the product exists in the inventory based on the product name.
        /// Then it checks if there are enough quantities of the product for the transaction process to take place.
        /// Then it perfroms the transaction by deducting the discount amount. It updates the quantity of the product.
        /// And at the last, it displays the transaction summary.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        /// <param name="discount"></param>
        /// <param name="productName"></param>
        public void ProcessTransactions(Products product, int quantity, decimal discount, string productName)
        {
            // Check if the product exists in the inventory based on the product name (regardless of the case)
            Products transactionProduct = ProductsList.FirstOrDefault(p => string.Equals(p.GetSetProductName, productName,
                StringComparison.OrdinalIgnoreCase));

            if (transactionProduct != null)
            {
                // Checking if there are enough quantities in the inventory
                if (transactionProduct.GetSetQuantity >= quantity)
                {
                    // Performing transaction
                    decimal priceAfterDiscount = transactionProduct.GetSetPrice - (transactionProduct.GetSetPrice * discount);
                    decimal totalPrice = priceAfterDiscount * quantity;

                    // Updating the quantity of the product in the inventory after the transaction
                    transactionProduct.GetSetQuantity -= quantity;

                    // Displaying the transaction summary
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("Transaction summary:");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine();
                    Console.WriteLine($"Product: {productName}\n" +
                        $"Quantity: {quantity}\n" +
                        $"Total Price: {totalPrice}\n");
                    Console.WriteLine("- * - * - * - * - * - * - * - * - * - * - * - * - * -");
                }
                else
                {
                    Console.WriteLine($"Not enough quantities available for {productName}. " +
                        $"Available quantities are : {transactionProduct.GetSetQuantity}");
                }
            }
            else
            {
                Console.WriteLine($"Product {productName} does not exist in the inventory.");
            }
        }

    }
}
