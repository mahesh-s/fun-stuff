using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeSurferModels;

namespace HomeSurfer.Web.ViewModels
{
    public class HomeViewModel:ViewModelBase
    {
        public HomeViewModel()
        {
            Home  =new Home();
        }

        public Home Home { get; set; }
        public bool IsNew { get; set; }
    }
}