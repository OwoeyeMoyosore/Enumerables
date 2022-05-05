using System;
using System.Collections.Generic;
namespace LinqQuantifier
{
    public class Program
    {
        static void Main()
        {
            var value = student.GetStudents();
            int[] evennumbers = { };
            int[] oddnumbers = {1,3,5,7,9,11,13,15,17,19,20,18,2,12 };
            int[] samenumbers = { 1, 1, 1, 1, 1, 1, 1, 1, };
            string[] words = {"chalk","pencil","marker" };

            //Quantifiers
            //Any
            var anynumbers = oddnumbers.Any(x => x == 3);
            Console.WriteLine(anynumbers);

            var keyword = words.Any(x => x == "marker");
            Console.WriteLine(keyword);

            //All
            var allnumbers = oddnumbers.All(x => x == 9);
            Console.WriteLine(allnumbers);
            var allnumbersss = samenumbers.All(x => x == 1);
            Console.WriteLine(allnumbersss);

            //selectmany
            var items = value.SelectMany(x=>x.courses,
                              (studentname,dept) => new 
                                {
                                  newstudentname = studentname.name,
                                  studentplaces = studentname.places,
                                  department = dept
                                }).ToList();
            foreach(var item in items)
            {
                Console.WriteLine($"{item.department} : {item.newstudentname} : {item.studentplaces}");
            }
            //Conversion of list to dictionary
            Console.WriteLine("Dictionary");
            var diction = value.ToDictionary<student, int>(s => s.Id);
            foreach(var item in diction.Keys)
            {
                Console.WriteLine("key: {0} ===> value:{1}", item, diction[item].name);
            }

        }

    }
    public class student
    {
        public string name { get; set; }
        public string places { get; set; }
        public List<string> courses { get; set; }
        public int Id { get; set; }

        public static List<student> GetStudents()
        {
            return new List<student>
            {
                new student {Id = 9 , name = "john", places = "Lagos", courses = new List<string>(){"BIO 101", "GST 101", "MTH 202"} },
                new student {Id =4 , name = "Edward", places = "Ibadan" , courses = new List<string>(){"CHM 202" ,"PHY 302" , "CSC 402" } },
                new student {Id = 12, name = "Ali", places = "Jos" , courses = new List<string>(){"CHM 104" ,"BIO 202" , "CSC 499" } }
            };
        }
    }
}

