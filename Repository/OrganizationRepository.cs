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
        public int RepositoyEntry(Organization organization)
        {

            _EMSDb.Organizations.Add(organization);

            int confirm = _EMSDb.SaveChanges();

            return confirm;
        }
    }
}
