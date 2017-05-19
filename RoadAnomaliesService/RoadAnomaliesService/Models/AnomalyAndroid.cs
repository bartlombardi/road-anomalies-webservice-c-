using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RoadAnomaliesService.Models
{
    [Table("Anomalies")]
    public class AnomalyAndroid
    {
        public double Latitude
        {
            get; set;
        }

        public double Longitude
        {
            get; set;
        }

        public double Trust
        {
            get; set;
        }
    }
}