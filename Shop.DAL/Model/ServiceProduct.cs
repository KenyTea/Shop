using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Model
{
   public class ServiceProduct
    {
        private Random Rand = new Random();

        public void GenerateProduct(Groccery Shop)
        {
            for (int i = 0; i < Rand.Next(5, 20); i++)
            {
                Product p = new Product();
                p.Barcode = Rand.Next(10000, 30000);
                p.Cur.CurCode = 398;
                p.Cur.CurName = "KZT";
                p.DateOfProduction = DateTime.Now.AddDays(-Rand.Next(0, 1000));
                p.ExpiredDay = Rand.Next(1, 10);
                p.ExpiredTime = DateTime.Now.AddDays(Rand.Next(0, 20));
                p.Name = string.Format("Product {0}", Rand.Next());
                p.Price = Rand.NextDouble();

                Shop.Products.Add(p);
            }
        }

        public List<Groccery> GenerateShop()
        {
            List<Groccery> Shops = new List<Groccery>();
            for (int i = 0; i < Rand.Next(1,10); i++)
            {
                Groccery G = new Groccery();
                G.Name = "Shop" + Rand.Next();
                GenerateProduct(G);
                Shops.Add(G); 
            }
            return Shops;
        }
    }
}
