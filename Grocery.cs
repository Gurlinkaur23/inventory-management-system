using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    /// <summary>
    ///  Grocery is a child / derived class of Products class and it inherits the methods and properties from the 
    /// Products class (Base class)
    /// </summary>
    internal class Grocery : Products
    {
        // Properties are encapsulated. They are kept private, which means they are only accessible inside this class
        // and not outside of it. The access for these properties is provided through public getters and setters.
        private DateTime ExpiryDate;

        /// <summary>
        /// Parameterized constructor of Grocery class. It initializes the properties of this class.
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        /// <param name="expiryDate"></param>
        public Grocery(string productName, int productId, int quantity, decimal price, DateTime expiryDate) :
            base(productName, productId, quantity, price)
        {
            ExpiryDate = expiryDate;
        }

        /// <summary>
        /// This method returns the value of expiry date. It also performs the validation and throws an exception
        /// in case of invalid expiry date.
        /// </summary>
        public DateTime GetSetExpiryDate
        {
            get { return ExpiryDate; }
            set
            {
                if (value <= DateTime.Now)
                    throw new ArgumentException("Expiry date must be in the future. Please enter a valid expiry date.");

                ExpiryDate = value;
            }
        }

        /// <summary>
        /// The CalculateDiscount() is an override method which is derived from the abstract base class.
        /// It returns the value of the discount for the Grocery products.
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateDiscount()
        {
            return 0.3m;
        }
    }
}
