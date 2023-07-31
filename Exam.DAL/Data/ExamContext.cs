using Exam.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DAL.Data
{
    public class ExamContext : DbContext
    {
        public ExamContext()
        {
        }

        public ExamContext(DbContextOptions<ExamContext> options) : base(options)
        {
        }

        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().ToTable("School");
        }
    }
}
