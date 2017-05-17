using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Data.Entity;
using System.Threading;
using RoadAnomaliesService.Models;


namespace RoadAnomaliesService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private Worker worker;

        protected void Application_Start()
        {
            worker = new Worker();
            Database.SetInitializer<RoadAnomaliesService.Models.AnomalyContext>(null);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }       
    }
}
