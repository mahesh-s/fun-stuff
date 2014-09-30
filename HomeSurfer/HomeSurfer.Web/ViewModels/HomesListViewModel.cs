using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeSurfer.Web.App_Start;
using HomeSurferModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HomeSurfer.Web.ViewModels
{
    public class HomesListViewModel:ViewModelBase
    {

        public IList<Home> Homes { get; set; }

        public string HomesJSON
        {
            get
            {
                var settings =new JsonSerializerSettings();
                settings.ContractResolver =new CamelCasePropertyNamesContractResolver();

                var homes = JsonConvert.SerializeObject(Homes, settings);
                return homes;
            }
        }

       
    }
}