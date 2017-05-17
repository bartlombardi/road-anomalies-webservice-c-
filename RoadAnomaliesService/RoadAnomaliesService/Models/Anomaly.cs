using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace RoadAnomaliesService.Models
{
    [Table("Anomalies")]
    public class Anomaly
    {
        public int Id { get; set; }

        public double Latitude
        {
            get; set;
        }

        public double Longitude
        {
            get; set;
        }

        public bool FlagAnomaly
        {
            get; set;
        }

        public double ZReading
        {
            get; set;
        }

        public double Trust
        {
            get; set;
        }

        public int Count
        {
            get; set;
        }

        public DateTime Date { get; set; }

        public DateTime Update { get; set; }

    }
}