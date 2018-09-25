using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using Models;

namespace Repository
{
    public class ParticipantRepository
    {
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        public int RepositoyEntry(Participant newParticipant)
        {

            _EMSDb.Participants.Add(newParticipant);

            int confirm = _EMSDb.SaveChanges();

            return confirm;
        }
    }
}
