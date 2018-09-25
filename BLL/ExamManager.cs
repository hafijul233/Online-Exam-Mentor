using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Models;
using Repository;

namespace BLL
{
    public class ExamManager
    {
        ExamRepository newExamRepository = new ExamRepository();
        public bool ManagerEntry(Exam newExam)
        {
            int confirm = newExamRepository.RepositoyEntry(newExam);

            if (confirm > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}