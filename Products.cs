using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    /// <summary>
    /// Products is an abstract class and a base class from which Clothing, Electronics and Grocery classes inherit.
    /// it contains an abstract method called CalculateDiscount(). The implementation for this method will be
    /// done in the child classes.
    /// </summary>
    internal abstract class Products
    {
        // The properties of this class are encapsulated and will only be accessible in the derived classes of this
        // abstract class.
        protected string ProductName;
        protected int ProductId;
        protected int Quantity;
        protected decimal Price;

        /// <summary>
        /// This is the parameterized constructor of this class. It initializes the properties of Products.
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        public Products(string productName, int productId, int quantity, decimal price)
        {
            ProductName = productName;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        /// <summary>
        /// This method returns the value of product name. It also performs the validation and throws an exception
        /// in case of invalid product name.
        /// </summary>
        public string GetSetProductName
        {
            get { return ProductName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Product name cannot be empty or null. Please enter a valid product name.");

                ProductName = value;
            }
        }

        /// <summary>
        /// This method returns the value of product ID. It also performs validation and throws an exception in case
        /// of invalid ID.
        /// </summary>
        public int GetSetProductId
        {
            get { return ProductId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Product ID must be greater than 0. Please enter a valid product ID.");

                ProductId = value;
            }
        }

        /// <summary>
        /// This method returns the value of quantity.  It also performs validation and throws an exception in case
        /// of invalid quantity.
        /// </summary>
        public int GetSetQuantity
        {
            get { return Quantity; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Product quantity must be greater than 0. Please enter a valid" +
                        " product quantity.");
                
                Quantity = value;
            }
        }

        /// <summary>
        /// This method returns the value of the price of the product. It also performs validation and throws an
        /// exception in case of invalid price.
        /// </summary>
        public decimal GetSetPrice
        {
            get { return Price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Price cannot be 0 or less than 0. Please enter a valid price.");

                Price = value;
            }
        }

        /// <summary>
        /// This is an abstract method. It contains just the "method signature" and doesnot contain the method body.
        /// The derived classes of this abstract class will contain the implementation for this abstract method.
        /// </summary>
        /// <returns></returns>
        public abstract decimal CalculateDiscount();

    }

}
