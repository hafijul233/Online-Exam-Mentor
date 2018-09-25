using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Models;
using Repository;

namespace BLL
{
    public class TrainerManager
    {
        TrainerRepository newTrainerRepository = new TrainerRepository();
        public bool ManagerEntry(Trainer newTrainer)
        {
            int confirm = newTrainerRepository.RepositoyEntry(newTrainer);

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