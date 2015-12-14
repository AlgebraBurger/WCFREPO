using System;
using System.Collections.Generic;
using System.Linq;
using WCF.SERVICEINTERFACE;

namespace WCF.SERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFProductService" in both code and config file together.
    public class WCFProductService : IWCFProductService
    {
       

        public List<string> ListProducts()
        {

            Console.WriteLine("Call to DB");

            List<string> productList = new List<string>();

            try
            {
                using (AdventureWorks2014Entities database = new AdventureWorks2014Entities())
                {
                    var products = from p in database.Products
                                               select p.ProductNumber;
                    productList = products.ToList();
                }   
            }
            catch
            {

            }

            return productList;
            
        }
    }
}
