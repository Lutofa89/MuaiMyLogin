using MuaiMyLogin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuaiMyLogin.Services
{
    public class LoginServices : ILoginRepository
    {
        // On a implémenté l'interface
        public async Task<UserInfo> Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
