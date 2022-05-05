using System;
namespace Classwork
{
    class Program
    {
        static void Main()
        {                  
            int[] evennumbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 8, 19, 11 };
            int[] oddnumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 18, 2, 12 };
            string[]  words =  {};
            //Element Operators
            //First or FirstOrDefault
            var numbers = evennumbers.FirstOrDefault();
            Console.WriteLine(numbers);
            //Last or LastOrDefault
            var allodds = oddnumbers.Last();
                Console.WriteLine(allodds);
            //Single or default
            var all = oddnumbers.SingleOrDefault(x => x == 3);
            Console.WriteLine(all);


            //var allSales = Sales.GetSales();
            //var allItems = Items.GetItems();

            //var groupboth = from a in allSales
            //                join b in allItems
            //                on a.Id equals b.SalesId into groupedboth
            //                select new
            //                {
            //                    a.Id,
            //                    a.Categories,
            //                    groupedboth
            //                };
            //foreach (var item in groupboth)
            //{
            //    Console.WriteLine($"ID:{item.Id}   Categories:{item.Categories} ");
            //    foreach (var itemss in item.groupedboth)
            //    {
            //        Console.WriteLine($"-----{itemss.RollNo}------{itemss.ItemName}");
            //    }
            //    Console.WriteLine("\n");
            //}

            ////Console.WriteLine("\n");
            //var sumamount = allItems.Sum(x => x.Amount);
            //Console.WriteLine($"Sum of the Amount is:  {sumamount}");

            //var avgRollNo = allItems.Average(x => x.RollNo);
            //Console.WriteLine($"Average of Roll Number is: {avgRollNo}");




        }
    }
    

}
