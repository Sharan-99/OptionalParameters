using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        private static void OrderDetails(string sellerName,string productName,int orderQuantity=1,bool isReturnable=true)
        {
            Console.WriteLine("Here is the order detail - {0} number of {1} by {2} is ordered. It’s returnable status is {3}",orderQuantity,productName,sellerName,isReturnable);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            OrderDetails("Lenovo","Laptops");         //calling only with required parameters
            OrderDetails("Lenovo", "Laptops",2,false);  //calling with required and optional parameters
            Console.ReadKey();
        }
    }
}
