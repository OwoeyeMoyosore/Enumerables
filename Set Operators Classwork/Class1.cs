using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public class Sales
    {
        public int Id { get; set; }
        public string Categories { get; set; }

        public static List<Sales> GetSales()
        {
            return new List<Sales>
            {
                new Sales{Id = 2, Categories ="Stationeries"},
                new Sales{Id = 6, Categories ="Fruits"},
                new Sales{Id = 8, Categories ="Drinks"},
                new Sales{Id = 10, Categories = "Beverages"},
                new Sales{Id = 12, Categories = "Flour"}
            };
        }
    }
    public class Items
    {
        public int RollNo { get; set; }
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public int SalesId { get; set; }

        public static List<Items> GetItems()
        {
            return new List<Items>
            {
                new Items{RollNo = 10, ItemName = "Books", Amount = 500, SalesId = 2 },
                new Items{RollNo = 20, ItemName = "Bottled Fanta", Amount = 150, SalesId = 8 },
                new Items{RollNo = 30, ItemName = "Apple", Amount = 200, SalesId = 6 },
                new Items{RollNo = 40, ItemName = "Bread", Amount = 650, SalesId = 12 },
                new Items{RollNo = 60, ItemName = "Milo", Amount = 1000, SalesId = 10 },
                new Items{RollNo = 80, ItemName = "Pencil", Amount = 500, SalesId = 2  },
                new Items{RollNo = 2, ItemName = "Sans", Amount = 250, SalesId = 8 },
                new Items{RollNo = 3, ItemName = "Pineapple", Amount = 2200, SalesId = 6 },
                new Items{RollNo = 5, ItemName = "Rice", Amount = 5050, SalesId = 12 },
                new Items{RollNo = 4, ItemName = "Cocoa", Amount = 1000, SalesId = 10 },
                new Items{RollNo = 7, ItemName = "Chalk", Amount = 500, SalesId = 2 },
                new Items{RollNo = 9, ItemName = "Cocacola", Amount = 150, SalesId = 8 },
                new Items{RollNo = 1, ItemName = "Lemon", Amount = 200, SalesId = 6 },
                new Items{RollNo = 8, ItemName = "Cereal", Amount = 650 },
                new Items{RollNo = 15, ItemName = "Chocolate", Amount = 1000},
            };
        }
    }

}
