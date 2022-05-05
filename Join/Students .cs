using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    public class Students
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
        public Gender Gender { get; set; }

      
        public static List<Students> GetClasses()
        {
            return new List<Students>
        {
            new Students{RollNo = 101 , Name ="Moyo" , Gender = Gender.Female, Standard =10},
            new Students{RollNo = 102 , Name ="Bisi" , Gender = Gender.Female, Standard =8},
            new Students{RollNo = 103 , Name ="Jimi" , Gender = Gender.Male, Standard =10},
            new Students{RollNo = 104 , Name ="Damilare" , Gender = Gender.Male, Standard =8},
            new Students{RollNo = 105 , Name ="Jummy" , Gender = Gender.Female, Standard =6},
            new Students{RollNo = 106 , Name ="Sola" , Gender = Gender.Male, Standard =6},
            new Students{RollNo = 107 , Name ="Ayo" , Gender = Gender.Male, Standard =6},
            new Students{RollNo = 108 , Name ="Gbemi" , Gender = Gender.Female}
        };
        }
    }
    public enum Gender
    {
        Female,
        Male,
    }
    public class Standard
    {
        public int ID { get; set; }
        public string ClassTeacher { get; set; }
        public double Fees { get; set; }

        public static List<Standard> GetStandards()
        {
            return new List<Standard>
            {
                new Standard{ID = 10, ClassTeacher = "Max", Fees = 100000 },
                new Standard{ID = 8, ClassTeacher = "Ajayi", Fees = 800000 },
                new Standard{ID = 6, ClassTeacher = "Geeta", Fees = 600000 },
                new Standard{ID = 4, ClassTeacher = "Rohas", Fees = 400000 },
            };

        }
    }
}
