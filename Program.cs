using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsDAL dal = new ProductsDAL();
            Products p = new Products();
            p.Prodid = 78;
            p.ProductName = "Indian " +
                "Lays";
            dal.UpdateProductUsingTranScope(p);
            Console.WriteLine("Updated Successfully");
            Console.ReadLine();
        }
    }
}
