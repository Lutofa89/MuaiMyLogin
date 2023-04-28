using MuaiMyLogin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuaiMyLogin.ViewModels
{
    public partial class LoginPageVieuwModels : BaseViewModels
    {
        [ObservableProgperty]
        private string _userName;
        [ObservableProgperty]
        private string _password;

        readonly ILoginRepository loginRepository = new LoginServices()

        [Icommand]
        public async void Login()
        {

        }
    }
}
