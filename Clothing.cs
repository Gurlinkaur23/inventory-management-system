using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    /// <summary>
    /// Clothing is a child / derived class of Products class and it inherits the methods and properties from the 
    /// Products class (Base class)
    /// </summary>
    internal class Clothing : Products
    {
        // Properties are encapsulated. They are kept private, which means they are only accessible inside this class
        // and not outside of it. The access for these properties is provided through public getters and setters.
        private string Brand;
        private string Size;

        /// <summary>
        /// Parameterized constructor of Clothing class. It initializes the properties of this class.
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        /// <param name="brand"></param>
        /// <param name="size"></param>
        public Clothing(string productName, int productId, int quantity, decimal price, string brand, string size) :
            base(productName, productId, quantity, price)
        {
            Brand = brand;
            Size = size;
        }

        /// <summary>
        /// This method returns the value of product brand. It also performs the validation and throws an exception
        /// in case of invalid brand name.
        /// </summary>
        public string GetSetBrand
        {
            get { return Brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Brand cannot be empty or null. Please enter a valid brand name.");

                Brand = value;
            }
        }

        /// <summary>
        /// This method returns the value of Size. It also performs the validation and throws an exception
        /// in case of invalid Size.
        /// </summary>
        public string GetSetSize
        {
            get { return Size; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Size cannot be empty or null. Please enter a valid Size.");

                Size = value;
            }
        }

        /// <summary>
        /// The CalculateDiscount() is an override method which is derived from the abstract base class.
        /// It returns the value of the discount for the Clothing products.
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateDiscount()
        {
            return 0.1m;
        }
    }
}
