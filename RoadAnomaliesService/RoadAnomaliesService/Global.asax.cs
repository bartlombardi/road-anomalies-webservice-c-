using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Data.Entity;

namespace RoadAnomaliesService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<RoadAnomaliesService.Models.AnomalyContext>(null);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
