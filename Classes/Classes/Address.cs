using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Address
    {
        #region Fields
        int index = 0;
        int house = 0;
        int apartment = 0;
        string country = String.Empty;
        string city = String.Empty;
        string street = String.Empty;
        #endregion

        #region Constructors
        public Address(int index, int house = 10, int apartment = 120, string country = "Ukraine", string city = "Dnipropetrovsk", string street = "K.Marks")
        {
            this.index = index;
            this.house = house;
            this.apartment = apartment;
            this.country = country;
            this.city = city;
            this.street = street;
        }
        public Address()
            : this(49005)
        {

        }
        #endregion

        #region Properties
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        #endregion

        #region Methods
        public void DisplayAddress()
        {
            Console.WriteLine("Your Address:");
            Console.WriteLine("| Country: {0} | City: {1} | Street: {2} | House: {3} | Apartment: {4} | Index: {5} | ", country, city, street, house, apartment, index);
        }
        public override string ToString()
        {
            Console.WriteLine("Your Address:");
            string str = string.Format("| Country: {0} | City: {1} | Street: {2} | House: {3} | Apartment: {4} | Index: {5} | ", country, city, street, house, apartment, index);
            return str;
        }
        #endregion
    }
}
