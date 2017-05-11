using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RoadAnomaliesService.Models
{
    public class AnomalyContext : DbContext 
    {
        public DbSet<Anomaly> anomalies { get; set; }
    }
}