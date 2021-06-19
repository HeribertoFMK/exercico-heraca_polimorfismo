
using System;
using System.Globalization;


namespace exercicioherpoli2.Entities
{
    public class UsedProduct: Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct(string name, double price,DateTime manufacturedate): base(name,price){

            manufactureDate = manufacturedate;

        }

        public override string PriceTag()
        {
            return Name
            + " (Used)"
            +" $ "
            + Price
            + " (Manufacture date:"
            +manufactureDate.ToString("dd/MM/yyyy")
            +" )";

        }
    }
}


