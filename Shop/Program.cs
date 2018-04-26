using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DAL.Model;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProduct q = new ServiceProduct();
            List<Groccery> w = q.GenerateShop();

            foreach (Groccery item in w.OrderBy(o => o.Products.Count()))
            {
                item.Info();
            }



            Console.WriteLine("Enter Shop");
            string t = Console.ReadLine();

           // Console.Clear();

            Groccery yt = w.FirstOrDefault(o => o.Name == t);
            if (yt != null)
            {
                Console.WriteLine("Enter QR");
                int temp = Int32.Parse(Console.ReadLine());
                Product findProduct = yt[temp];
                findProduct.PrintInfo();
            }
        }
    }
}
