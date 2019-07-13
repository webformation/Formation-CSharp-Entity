using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureWorksLT2017Entities e = new AdventureWorksLT2017Entities();
            e.Database.Log = Console.Write;
            //e.Database.Log += System.Diagnostics.Debug.WriteLine;
            e.Database.Log += s => System.Diagnostics.Debug.WriteLine(s);
            var req = from commande in e.SalesOrderHeader
                      where commande.OrderDate == new DateTime(2008, 6, 1)
                      select new { commande.SalesOrderID, commande.SalesOrderDetail };
            Console.WriteLine(req.Expression);

            int iter = 0;
            foreach (var c in req)
            {
                if (iter++ == 0)
                {
                    //Console.WriteLine((System.Data.Objects.ObjectQuery)req).ToTraceString();
                    //Console.WriteLine( ((System.Data.Entity.Core.Objects.ObjectQuery)req).ToTraceString());
                    Console.ReadKey();
                }
                Console.WriteLine(String.Format("Numéro Commande {0}",c.SalesOrderID));
                foreach (var d in c.SalesOrderDetail )
                {
                    Console.Write(String.Format("Qte {0}, Produit {1};", d.OrderQty, d.ProductID));
                }
                Console.WriteLine();
            }
        }
    }
}
