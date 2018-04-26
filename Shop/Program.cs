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

            foreach (Groccery item in w)
            {
                item.Info();
            }

        }
    }
}
