using System;
using System.Globalization;


namespace exercicioherpoli2.Entities
{
    public class ImportedProduct : Product
    {
        public double CustormFree{ get; set; }

        public ImportedProduct(string name, double price,double custormfree): base(name,price){


            CustormFree = custormfree;

        }

       

        public double TotalPrice(){


            return Price + CustormFree;

        }
        public override string PriceTag()
        {
            return Name 
            +" $ "
            + TotalPrice().ToString("F2",CultureInfo.InvariantCulture)
            + " (Customs free: "
            + CustormFree.ToString("F2",CultureInfo.InvariantCulture)
            +" }";

            
        
        }


    }
}
