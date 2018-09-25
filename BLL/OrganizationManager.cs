using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BLL
{
    public class OrganizationManager
    {
        OrganizationRepository newOrganizationRepository = new OrganizationRepository();

        public bool ManagerEntry(Organization organization)
        {
            int confirm = newOrganizationRepository.RepositoyEntry(organization);

            if (confirm > 0)
            {
                return true;
            }
            return false;
        }
    }
}
