using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Validation;
using System.Web.Http.Validation.Providers;
using HomeSurfer.Web.Filters;

namespace HomeSurfer.Web
{
    public class CustomGlobalConfig
    {
        public static void Customize(HttpConfiguration config)
        {

            config.Services.RemoveAll(typeof (ModelValidatorProvider), v => v is InvalidModelValidatorProvider);
            config.Filters.Add(new ValidationActionFilter());
        }
    }
}