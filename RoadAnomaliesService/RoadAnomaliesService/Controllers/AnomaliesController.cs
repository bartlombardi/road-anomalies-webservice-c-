using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RoadAnomaliesService.Models;

namespace RoadAnomaliesService.Controllers
{
    public class AnomaliesController : ApiController
    {
        public DataController DataController = new DataController();
        
        // GET: api/Anomalies
        public IEnumerable<Anomaly> Get() { return DataController.getAllAnomaly(); }

        //// GET: api/Anomalies/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Anomalies
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Anomalies/5
        public void Put(double latitude, double longitude, double zReading)
        {
            DataController.addAnomaly(latitude, longitude, zReading);
        }

        // DELETE: api/Anomalies/5
        public void Delete(int id)
        {
        }
    }
}
