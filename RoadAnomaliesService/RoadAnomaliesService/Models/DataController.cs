using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Sql;

namespace RoadAnomaliesService.Models
{
    public class DataController
    {
        private AnomalyContext AnomalyDb = new AnomalyContext();

        public void addAnomaly(double latitude, double longitude, double zReading)
        {

            List<Anomaly> allAnomaly = getAllAnomaly();
            bool isEntered = false;

            foreach (Anomaly a in allAnomaly)
            {
                if (Math.Abs(a.Latitude - latitude) <= Double.Epsilon && Math.Abs(a.Longitude - longitude) <= Double.Epsilon)
                {
                    isEntered = true;
                    a.FlagAnomaly = true;
                    a.ZReading = zReading;
                    a.Count += 1;
                    a.Trust = (a.Count * 0.7) + a.Trust;
                    a.Date = DateTime.Now;
                    AnomalyDb.SaveChanges();
                }
            }

            if (!isEntered)
            {
                Anomaly newAnomaly = new Anomaly{ Latitude=latitude,Longitude=longitude,FlagAnomaly=false,ZReading=zReading,Trust=70,Count=1,Date=DateTime.Now };
                AnomalyDb.anomalies.Add(newAnomaly);
                AnomalyDb.SaveChanges();
            }
        }

        public List<Anomaly> getAllAnomaly()
        {   
            List<Anomaly> result = new List<Anomaly>();
            result = AnomalyDb.anomalies.ToList();
            return result;
        }
    }
}