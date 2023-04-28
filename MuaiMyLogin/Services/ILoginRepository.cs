using MuaiMyLogin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuaiMyLogin.Services
{
    public  interface ILoginRepository
    {

        Task<UserInfo> Login(string username, string password);

    }
}
