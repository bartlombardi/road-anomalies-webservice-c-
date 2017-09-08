using System.Collections.Generic;
using System.Web.Http;
using RoadAnomaliesService.Models;

namespace RoadAnomaliesService.Controllers
{
    public class AnomaliesController : ApiController
    {
        public DataController DataController = new DataController();
        
        public IEnumerable<Anomaly> Get() { return DataController.getAllAnomaly(); }

        public void Get(double latitude, double longitude)
        {
            DataController.addAnomaly(latitude, longitude);
        }

    }
}
