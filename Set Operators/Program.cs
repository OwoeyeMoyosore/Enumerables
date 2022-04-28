using System;
namespace SetOperators
{
    public  class Program
    {
        static void Main()
        {
            int[] evennumbers = {2,4,6,8,10,12,14,16,18,20,8,19,11};
            int[] oddnumbers = {1,3,5,7,9,11,13,15,17,19,18,2,12};

            //Aggregate Operators

            //sum
            var sumnumbers = evennumbers.Union(oddnumbers)
                                        //.Where(x => x< 20)
                                        .Sum(x => x);
                Console.WriteLine(sumnumbers);

            //Min
            var minnumbers = oddnumbers.Min(x => x);
                Console.WriteLine(minnumbers);

            //Max
            var maxnumbers = oddnumbers.Max(x => x);
            Console.WriteLine(maxnumbers);

            //Average
            var averagenumbers = oddnumbers.Average(x => x);
            Console.WriteLine(averagenumbers);

            //AGGREGATE METHOD
            int[] num = { 2, 5, 6, 7 };
            var allsum = num.Aggregate((a,b) => a - b + b);
            Console.WriteLine("Aggregate :"+ allsum);
            ////Union
            //var numbers = evennumbers.Where(x => x > 10)
            //                              .Union(evennumbers.Where(x => x < 10));

            //var allnumbers = evennumbers.Union(oddnumbers)
            //                        .OrderBy(x => x);//ascending order 

            //foreach (var i in allnumbers)
            //{
            //    Console.WriteLine(i);
            //}

            ////intersect
            //var intersectnumber = evennumbers.Intersect(oddnumbers)
            //                                 .OrderBy(x => x);
            //foreach(var i in intersectnumber)
            //{
            //    Console.WriteLine("INTERSECT: " + i);
            //}

            //Except
            var exceptnumber = oddnumbers.Except(evennumbers)
                                          .OrderBy(x => x);

            foreach(var i in exceptnumber)
            {
                Console.WriteLine($"Except Number:  {i}");
            }

            //Distinct
            var distinctnumber = evennumbers.Distinct()
                                            .OrderBy(x => x);
            foreach(var i in distinctnumber)
            {
                Console.WriteLine($"Distinct number: {i}");
            }

        }

    }
}
