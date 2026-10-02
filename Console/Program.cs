using System;

namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student()


                
                {
                    StudentName = "Anoop",
                    DateOfBirth = new DateTime(1997, 02, 15),
                    Height = 175.5m,
                    Weight = 75.0f
                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}