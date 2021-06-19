using System;
using exercicioherpoli2.Entities;
using System.Globalization;
using System.Collections.Generic;




namespace exercicioherpoli2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            System.Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                System.Console.WriteLine($"Product #{i} data:");
                System.Console.Write("Common, used or imported (c/u/i)? ");
                char x = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if( x == 'c'){

                    list.Add(new Product(name,price));
                }else if(x=='u'){

                   System.Console.Write("Manufacture date (DD/MM/YYYY):"); 
                   DateTime manufacture = DateTime.Parse(Console.ReadLine());

                   list.Add(new UsedProduct(name,price,manufacture));
                }else if(x == 'i'){

                    System.Console.Write("Customs fee: ");
                    double custormfree = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    
                   



                    list.Add(new ImportedProduct(name,price,custormfree));
                }



                }

                System.Console.WriteLine("PRICE TAGS:");
                foreach (Product item in list)
                {
                    System.Console.WriteLine(item.PriceTag());
                }

                
            }
    }  
}
