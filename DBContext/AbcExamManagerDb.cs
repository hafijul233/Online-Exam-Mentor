using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataBaseContext
{
    public class AbcExamManagerDb : DbContext
    {
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<LoginData> LoginDatas { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        

    }
}
