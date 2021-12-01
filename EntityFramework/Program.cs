using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Context;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Students>();
            using (var context = new UniversityDbContext())
            {
                students = context.Students.ToList();
            }
            students.ForEach(x => Console.WriteLine(x.Name));
            Console.ReadLine();
        }
    }
}






