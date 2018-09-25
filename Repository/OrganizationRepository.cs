using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using Models;

namespace Repository
{
    public class OrganizationRepository
    {
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        public int RepositoyEntry(Organization newOrganization)
        {

            _EMSDb.Organizations.Add(newOrganization);

            int confirm = _EMSDb.SaveChanges();

            return confirm;
        }
    }
}
