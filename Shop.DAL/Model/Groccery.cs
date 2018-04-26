using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Model
{
     public class Groccery
    {

       public Groccery()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; }
        public string Addtess { get; set; }
        public string Phone { get; set; }

        public List<Product> Products { get; set; }

        public Product this[int QR]   //
        {
            get
            {
                return Products.FirstOrDefault(o => o.Barcode == QR);

            }
        }

        public void Info()
        {
            Console.WriteLine("{0} \n {1} ({2})", Name, Addtess, Phone);
            foreach (Product item in Products)
            {
                item.PrintInfo();
            }
        }
    }
}
