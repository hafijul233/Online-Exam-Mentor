using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Models;
using Repository;

namespace BLL
{
    public class LoginDataManager
    {
        LoginDataRepository newLoginDataRepository = new LoginDataRepository();
        public bool ManagerEntry(LoginData newLoginData)
        {
            int confirm = newLoginDataRepository.RepositoyEntry(newLoginData);

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