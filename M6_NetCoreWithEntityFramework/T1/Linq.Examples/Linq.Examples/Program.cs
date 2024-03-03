using Linq.Examples.Entities;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Linq.Examples
{
    class Program
    {
        static IList<Student> studentlist = new List<Student>()
        {
            new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 },
            new Student() { StudentID = 2, StudentName = "Stive", Age = 21, StandardID = 1 },
            new Student() { StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2 },
            new Student() { StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2 },
            new Student() { StudentID = 5, StudentName = "Ron", Age = 21 },
            new Student() { StudentID = 6, StudentName = "Rick", Age = 14 }
        };

        static IList<Standard> standardlist = new List<Standard>()
        {
            new Standard() { StandardID = 1, StandardName = "Standard 1"},
            new Standard() { StandardID = 2, StandardName = "Standard 2"},
            new Standard() { StandardID = 3, StandardName = "Standard 3"}
        };

        static void Main(string[] args)
        {
            //var test = studentlist.Where(x => x.Age >= 18).Count();

            //var test = studentlist.Where(x => x.Age >= 18).Where(st => st.StandardID > 0).Count();

            //var test = studentlist.Where(x => x.Age >= 18).Where(st => st.StandardID > 0);

            //var test = studentlist.Where(x => x.Age >= 18).Where(st => st.StandardID > 0).Select(x => x.StudentName);

            //var test = studentlist.Where(x => (x.Age >= 18 && x.StandardID > 0) ) .Select(x => x.StudentName);


            //var teenStudentsName = from s in studentlist where s.Age > 12 && s.Age < 20 select new { StudentName = s.StudentName };
            
            //var teenStudentsName = from s in studentlist where s.Age > 12 && s.Age < 20 select new { Namee = s.StudentName };


            var studentsGroupNyStandard = from s in studentlist
                                          where s.Age > 12 && s.Age <= 20
                                          group s by s.StandardID into sg 
                                          orderby sg.Key 
                                          select new { 
                                              StandardID = sg.Key, 
                                              Items = sg 
                                          };

            var studentWithStandard = from s in studentlist
                                      join stand in standardlist
                                      on s.StandardID equals stand.StandardID
                                      select new
                                      {
                                          StudentName = s.StudentName,
                                          StandardName = stand.StandardName
                                      };

            foreach (var element in studentWithStandard)
            {
                Console.WriteLine($"Student: {element.StudentName} is in {element.StandardName}");
            }

            //foreach (var element in studentsGroupNyStandard)
            //{
            //    Console.WriteLine(element.StandardID);

            //    foreach (var student in element.Items)
            //    {
            //        Console.WriteLine(student.StudentName);
            //    }

            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
