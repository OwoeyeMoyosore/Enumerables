using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQAssignment
{
    public class Program
    {
        public static void Main()
        {
            //Question 3
            List<Employee>  employees= new  List<Employee>
            {
                new Employee(){ID = 001 , Name = "Owoeye Moyosore" , Age= 30 , Gender = "Female", Salary = 5000000},
                new Employee(){ID = 002 , Name = "Olaosebikan Folajimi" , Age= 23 , Gender = "Male", Salary = 100000},
                new Employee(){ID = 003, Name = "Toyosi Favour" , Age= 25 , Gender = "Female", Salary = 200000},
                new Employee(){ID = 004 , Name = "Obafemi Damilare" , Age= 25 , Gender = "Male", Salary = 150000},
                new Employee(){ID = 005 , Name = "Olaoye Olubisi" , Age= 22 , Gender = "Female", Salary = 250000},
                new Employee(){ID = 006 , Name = "Owoeye Ayomide" , Age= 26 , Gender = "Male", Salary = 1000000},
                new Employee(){ID = 007 , Name = "Ben Stone" , Age= 35 , Gender = "Male", Salary = 330000},
                new Employee(){ID = 008 , Name = "Vasquez Jared" , Age= 37 , Gender = "Male", Salary = 350000},
                new Employee(){ID = 009 , Name = "Michaela Stone",  Age= 20 , Gender = "Female", Salary = 900000},
                new Employee(){ID = 010 , Name = "Oyedeji Ayomikun" , Age= 35 , Gender = "Male", Salary = 4000000}
            };
            //Question 4
            var emp = employees.Where(x => x.Age > 25)
                               .OrderByDescending(x => x.Age);
            
            Console.WriteLine("Ages Greater than 25 in descending order ");
            foreach (var item in emp)
            {
                Console.WriteLine($"Id: {item.ID},   Name: {item.Name},   Age:{item.Age},  Gender:{item.Gender},    " +
                    $"Salary:{item.Salary}");
            }

            //Question 5
            Console.WriteLine("\n Females Only \n");
            var emps = employees.Where(x => x.Gender.Contains("Female"));
            foreach(var item in emps)
            {
                Console.WriteLine($"Id: {item.ID},   Name: {item.Name},   Age:{item.Age},  Gender:{item.Gender},    " +
                    $"Salary:{item.Salary}");
            }

            //Question 6
            Console.WriteLine("\n Ages that are 20, 30, 35 \n");
            var empss = employees.Where(x => x.Age.Equals(20) || x.Age.Equals(30) || x.Age.Equals(35));
            foreach(var item in empss)
            {
                Console.WriteLine($"Id: {item.ID},   Name: {item.Name},   Age:{item.Age},  Gender:{item.Gender},    " +
                    $"Salary:{item.Salary}");
            }
                

            //Question 7
            Console.WriteLine("\n Female Candidate whose ID is between 1 to 8 \n");
            var empsss = employees.Where(x => x.Gender.Contains("Female"))
                                    .Where (x => x.ID <= 008 && x.ID >= 001);
            foreach (var item in empsss)
            {
                Console.WriteLine($"Id: {item.ID},   Name: {item.Name},   Age:{item.Age},  Gender:{item.Gender},    " +
                    $"Salary:{item.Salary}");
            }

        }
    }
    public class Employee //Question 1
    {
        //Question 2
        public int ID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
            
             
    }
}
