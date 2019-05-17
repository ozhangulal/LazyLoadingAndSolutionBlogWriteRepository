using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingAndSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //UYGULAMAYI DOWNLOAD ETTIKTEN SONRA APP.CONFIG ICERISINDE YER ALAN CONNECTION STRING IFADESINI DEGISTIRMEYI UNUTMAYINIZ !!!! 
            #region LazyLoading
            //LAZY LOADING
            NorthwindEntities _db = new NorthwindEntities();
            List<Customer> custList = _db.Customers.ToList();
            foreach (Customer item in custList)
            {
                Console.WriteLine(item.CompanyName + " " + item.Orders.Count);
            }
            Console.ReadLine();
            #endregion

            #region AnonymousType

            //Anonymous Type
            //Lazy Loading Solved

            //using (NorthwindEntities _db = new NorthwindEntities())
            //{
            //    var resultSet = from c in _db.Customers
            //                    select new
            //                    {
            //                        c.CompanyName,
            //                        c.Orders.Count
            //                    };
            //    foreach (var result in resultSet)
            //    {
            //        Console.WriteLine("Customer Name :{0} ({1})", result.CompanyName, result.Count.ToString());
            //    }
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
