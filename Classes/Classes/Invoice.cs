using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Invoice
    {
        #region Fields
        readonly int account;
        readonly string customer;
        readonly string provider;
        int quantity = 0;
        string article = "";
        #endregion

        #region Properties
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Article
        {
            get { return article; }
            set { article = value; }
        }
        #endregion

        #region Constructor
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        #endregion

        #region Methods
        public void Display()
        {
            double general = account * Quantity;
            double general_vat = general + 0.2 * general;

            string output = string.Format(@"
                             Customer: {0}
                             Provider: {1}
                             Account: {2}
                             Quantity: {3}
                             Article: {4}
                             General without VAT: {5}
                             General with VAT:{6}
", customer, provider, account, Quantity, Article, general, general_vat);
            Console.WriteLine(output);
        }
        #endregion
    }
}
