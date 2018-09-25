using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Models;
using Repository;

namespace ExamManagementSystem.Controllers
{
    public class BatchManager
    {
        BatchRepository newBatchRepository = new BatchRepository();
       public bool ManagerEntry(Batch newBatch)
       {
            int confirm = newBatchRepository.RepositoyEntry(newBatch);

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