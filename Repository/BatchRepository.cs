using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using Models;

namespace Repository
{
    public class BatchRepository
    {
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        public int RepositoyEntry(Batch newBatch)
        {

            _EMSDb.Batches.Add(newBatch);

            int confirm = _EMSDb.SaveChanges();

            return confirm;
        }
    }
}
