using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoadAnomaliesService.Models
{
    public class DataController
    {
        public void addAnomaly(float latitude, float longitude, float zReading) { }
        public List<Anomaly> getAllAnomaly()
        {
            List<Anomaly> result = new List<Anomaly>();
            return result;
        }
    }
}