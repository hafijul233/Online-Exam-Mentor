using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Models;
using Repository;

namespace BLL
{
    public class ParticipantManager
    {
        ParticipantRepository newParticipantRepository = new ParticipantRepository();
        public bool ManagerEntry(Participant newParticipant)
        {
            int confirm = newParticipantRepository.RepositoyEntry(newParticipant);

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