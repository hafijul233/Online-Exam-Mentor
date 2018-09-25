using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using Models;

namespace Repository
{
    public class ExamRepository
    {
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        public int RepositoyEntry(Exam newExam)
        {

            _EMSDb.Exams.Add(newExam);

            int confirm = _EMSDb.SaveChanges();

            return confirm;
        }
    }
}
