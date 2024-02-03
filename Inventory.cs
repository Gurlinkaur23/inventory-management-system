using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    /// <summary>
    /// This class manages the entire products stock of the retail store. It includes mthods for updating the product
    /// information, adding the products and removing the products.
    /// </summary>
    internal class Inventory
    {
        /// <summary>
        /// List of products in the inventory is encapsulated and is kept internal, which means that it will only be
        /// accessible within the same assembly.
        /// </summary>
        internal List<Products> ProductsList { get; set; }

        /// <summary>
        /// Parameterized constructor of the Inventory class. It initializes the List of products in the inventory.
        /// </summary>
        /// <param name="productsList"></param>
        public Inventory(List<Products> productsList)
        {
            ProductsList = productsList;
        }

        /// <summary>
        /// This method accepts some details of the product as parameters. It checks if the given ID of the product matches
        /// with the ID of any product in the productsList. If it matches, then it finds that product object from the list
        /// based on the ID. Then it updates the product information.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="updatedProductName"></param>
        /// <param name="updatedQuantity"></param>
        /// <param name="updatedPrice"></param>
        public void UpdateProductInformation(int productId, string updatedProductName,
            int updatedQuantity, decimal updatedPrice)
        {
            if (ProductsList.Any(product => product.GetSetProductId == productId))
            {
                Products productToUpdate = ProductsList.FirstOrDefault(product => product.GetSetProductId == productId);

                productToUpdate.GetSetProductName = updatedProductName;
                productToUpdate.GetSetQuantity = updatedQuantity;
                productToUpdate.GetSetPrice = updatedPrice;

                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine($"The product information for {updatedProductName} has been updated.");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The product {updatedProductName} does not exist in the inventory.");
            }

        }

        /// <summary>
        /// This method accepts a product and first checks if the ID of the entered product is already in the productsList.
        /// If the ID is unique, then it checks for the name of the product to be unique. Then, it adds the product to
        /// the productsList.
        /// </summary>
        /// <param name="newProduct"></param>
        public void AddProducts(Products newProduct)
        {
            try
            {
                if (!ProductsList.Any(product => product.GetSetProductId == newProduct.GetSetProductId))
                {
                    if (!ProductsList.Any(product => product.GetSetProductName == newProduct.GetSetProductName))
                    {
                        ProductsList.Add(newProduct);
                        //Console.WriteLine($"The product '{newProduct.GetSetProductName}' is added to the inventory.");
                    }
                    else
                        throw new Exception($"The product {newProduct.GetSetProductName} already exists in the inventory.");
                }
                else
                {
                    throw new Exception($"The product with ID {newProduct.GetSetProductId} already exists in the inventory." +
                        $"Please use a unique ID for the products.");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// This method accepts a product ID and checks if the inventory contains that ID. If so, then it finds that 
        /// product based on the ID and removes it from the inventory.
        /// </summary>
        /// <param name="productId"></param>
        public void RemoveProducts(int productId)
        {
            try
            {
                if (ProductsList.Any(product => product.GetSetProductId == productId))
                {
                    Products productToRemove = ProductsList.FirstOrDefault(product => product.GetSetProductId == productId);
                    ProductsList.Remove(productToRemove);
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine($"The product with ID {productId} is removed from the inventory.");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine();
                }
                else
                {
                    throw new Exception($"The product with ID {productId} does not exist in the inventory.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
