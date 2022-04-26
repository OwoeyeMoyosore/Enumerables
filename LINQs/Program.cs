using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using LearnCSharp.Library;

namespace LearnCSharp.Cmd
{
    public class Program
    {

        static string[] Keywords = {"purpose", "chalk", "crayon", "bags",
            "pencil", "books","board", "marker","duster","shoe" };



        public static void Main()
        {
            var pro = new List<product>();
            pro.Add(new product { Name = "Biro", price = 100, Quantity = 5, Places = "Lagos" });
            pro.Add(new product { Name = "chalk", price = 1000, Quantity = 3, Places = "Lagos" });
            pro.Add(new product { Name = "Bag", price = 1500, Quantity = 4, Places = "Ogun" });
            pro.Add(new product { Name = "Shoe", price = 500, Quantity = 1, Places = "Ogun" });
            pro.Add(new product { Name = "Books", price = 2000, Quantity = 3, Places = "Abuja" });

            //var word = pro.Where(y => y.price > 500)
            //               .OrderByDescending(x => x.Quantity)
            //               .ThenBy(x => x.Name)
            //               .Select(x => (Productname:x.Name, ProQuantity:x.Quantity));

            var word = pro.GroupBy(x => x.Places)
                           .Select(x => (x.Key,
                           proname: x.Select(x => x)))
                           .OrderBy(x => x.Key);


            foreach (var item in word)
            {
                Console.WriteLine(item.Key);
                foreach (var items in item.proname)
                {
                    Console.WriteLine($"    productname:{items.Name}:  {items.price}");
                }
            }
            //var word = Keywords.Where(b => !b.Contains("a") || !b.Contains("o"));
            //                        //.Select(z => z);
            //foreach(var item in word)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
    public class product
    {
        public string Name { get; set; }
        public double price { get; set; }
        public int Quantity { get; set; }
        public string Places { get; set; }
    }
}