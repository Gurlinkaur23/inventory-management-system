using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    /// <summary>
    /// Electronics is a child / derived class of Products class and it inherits the methods and properties from the 
    /// Products class (Base class)
    /// </summary>
    internal class Electronics : Products
    {
        // Properties are encapsulated. They are kept private, which means they are only accessible inside this class
        // and not outside of it. The access for these properties is provided through public getters and setters.
        private int Warranty;
        private string Model;

        /// <summary>
        /// Parameterized constructor of Electronics class. It initializes the properties of this class.
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        /// <param name="warranty"></param>
        /// <param name="model"></param>
        public Electronics(string productName, int productId, int quantity, decimal price, int warranty, string model) :
            base(productName, productId, quantity, price)
        {
            Warranty = warranty;
            Model = model;
        }

        /// <summary>
        /// This method returns the value of Warranty. It also performs the validation and throws an exception
        /// in case of invalid Warranty.
        /// </summary>
        public int GetSetWarranty
        {
            get { return Warranty; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Warranty cannot be less than or equal to 0. Please enter a " +
                        "valid warranty period.");

                Warranty = value;
            }
        }

        /// <summary>
        /// This method returns the value of Model. It also performs the validation and throws an exception
        /// in case of invalid Model.
        /// </summary>
        public string GetSetModel
        {
            get { return Model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Model name cannot be empty or null. Please enter a valid model.");

                Model = value;
            }
        }

        /// <summary>
        /// The CalculateDiscount() is an override method which is derived from the abstract base class.
        /// It returns the value of the discount for the Electronics products.
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateDiscount()
        {
            return 0.05m;
        }
    }
}
