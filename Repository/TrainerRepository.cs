using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using Models;

namespace Repository
{
    public class TrainerRepository
    {
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        public int RepositoyEntry(Trainer newTrainer)
        {

            _EMSDb.Trainers.Add(newTrainer);

            int confirm = _EMSDb.SaveChanges();

            return confirm;
        }
    }
}
