using Exam.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DAL.Data
{
    public class DBInitializer
    {
        public static void Initialize(ExamContext context)
        {
            context.Database.EnsureCreated();

            // Look for any schools.
            if (context.Schools.Any())
            {
                return;   // DB has been seeded
            }

            for (int i = 1; i <= 10; i++)
            {
                context.Add(new School() { Name = $"School {i}" });
            }

            context.SaveChanges();
        }
    }
}
