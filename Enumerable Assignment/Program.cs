using System;
namespace EnumAssignment
{
    public class Program
    {
        public static void Main()
        {
            //Question 4
            List<Product> myProducts = new List<Product>()
            {
                new Product{ Name = "Cornflakes" , Quantity = 12},
                new Product{ Name = "Milk" , Quantity = 20},
                new Product{ Name = "Soap" , Quantity = 5},
                new Product{ Name = "Golden Morn" , Quantity = 6},
                new Product{ Name = "Sanitary Towel " , Quantity = 10},
                new Product{ Name = "Ice Cream " , Quantity = 5},
                new Product{ Name = "Milo" , Quantity = 4},
                new Product{ Name = "Dettol" , Quantity = 2},
                new Product{ Name = "Insecticide" , Quantity = 3},
                new Product{ Name = "Sugar" , Quantity = 7},
            };
            //Normal Order
            //Console.WriteLine("Before Sorting");
            //foreach (var product in myProducts)
            //{
                //Console.WriteLine($"Name:{product.Name}   Quantity: {product.Quantity}");
            //}
           
            //Sorting
            myProducts.Sort(new ProductSorting());
            foreach(var product in myProducts)
            {
               
                Console.WriteLine(product);
            }
            //vvvConsole.ReadKey();
        }
        public class ProductSorting : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                if (x.Quantity < y.Quantity)
                {
                    return 1;
                }
                else if (x.Quantity > y.Quantity)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
    public class Product//Question 1
    {
        //Question 2
        public string Name { get; set; }
        public int Quantity { get; set; }
        //Question 3
        public override string ToString()
        {
            return $"Name of Product: {Name}  ,   Quantity: {Quantity}";
        }


    }
 }

vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvbvbvbbvb