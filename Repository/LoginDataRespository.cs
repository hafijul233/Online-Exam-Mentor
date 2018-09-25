using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using Models;

namespace Repository
{
    public class LoginDataRepository
    {
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        public int RepositoyEntry(LoginData newLoginData)
        {

            _EMSDb.LoginDatas.Add(newLoginData);

            int confirm = _EMSDb.SaveChanges();

            return confirm;
        }
    }
}
