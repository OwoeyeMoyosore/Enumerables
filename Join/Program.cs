using System;
namespace Join
{
    public  class Program
    {
        static void Main()
        {
            var allstudents = Students.GetClasses();
            var teacher = Standard.GetStandards();

            //Extension method based syntax
            var newdata = allstudents.GroupJoin(teacher,
                          b => b.Standard,
                          x => x.ID, (bt, groupedteacher) => new
                          {
                              studentname = bt.Name,
                              ID = bt.Standard,
                              bt.Gender,
                              groupedteacher
                          });
            foreach(var item in newdata)
            {
                Console.WriteLine($"name: {item.studentname} : Id: {item.ID} : Gender: {item.Gender}");
                foreach(var item2 in item.groupedteacher)
                {
                    Console.WriteLine($"----{item2.ID}-----{item2.ClassTeacher}----{item2.Fees}");
                }
            }
            //left outer join
            var datas = from d in teacher
                        join c in allstudents
                        on d.ID equals c.Standard into groupedstudent
                        from g in groupedstudent.DefaultIfEmpty()
                        select new
                        {
                            d.ID,
                            d.ClassTeacher,
                            classstudent = g == null ? "no student" : g.Name,
                            classnumber = g ==null ? 0 :g.RollNo
                        };
            foreach(var item in datas)
            {
                //Console.WriteLine(item.classstudent);
                Console.WriteLine($"name: {item.ClassTeacher} : id:{item.classstudent}");
            }
            /*
             * //Group Join
            var data = from d in teacher
                       join c in allstudents
                       on d.ID equals c.Standard into groupedstudent
                       select new
                       {
                           d.ID,
                           d.ClassTeacher,
                           groupedstudent

                       };
            foreach(var item in data)
            {
                Console.WriteLine($"name: {item.ClassTeacher} : id:{item.ID}");
                foreach(var itempro in item.groupedstudent)
                {
                    Console.WriteLine($"------{itempro.Name}------{itempro.RollNo}");
                }
            }*/
            /*
            //Join
            //Query Syntax
            var data = from b in allstudents
                       join x in teacher
                       on b.Standard equals x.ID
                       select new
                       {
                           b.Name,
                           x.ClassTeacher,
                           x.ID,
                           b.Gender
                       };
            //Extension Method/BasedSyntax
            var newdata = allstudents.Join(teacher,
                            b => b.Standard,
                            x => x.ID, (bt, xl) => new
                            {
                                studentname = bt.Name,
                                teacher = xl.ClassTeacher,
                                studentID = bt.Standard,
                                xl.Fees,
                                bt.Gender
                            }).Where(b => b.studentID > 6)
                              .OrderByDescending(x => x.Fees);
            foreach(var item in  newdata)
            {
                Console.WriteLine($"StudentName -----{item.studentname}:" +
                    $" Teacher:----{item.teacher} :ID----{item.studentID}" +
                    $" : SchoolLevy-----{item.Fees}") ;
            }*/

            Console.WriteLine("Hello World");
            
        }
    }
}
