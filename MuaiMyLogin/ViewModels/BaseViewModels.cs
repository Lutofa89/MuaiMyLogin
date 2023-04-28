using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuaiMyLogin.ViewModels
{
    
    public partial class BaseViewModels : ObservableObject
    {  [ObservableProgperty]
        public bool _isBusy;
        [ObservableProgperty]
        public string _title;


    }
}
