using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoadAnomaliesService.Models
{
    public class Anomaly
    {
        private float latitute;
        private float longitude;
        private bool flagAnomaly;
        private float zReading;
        private float trust;
        private int count;

        public float Latitute
        {
            get
            {
                return latitute;
            }

            set
            {
                latitute = value;
            }
        }

        public float Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
            }
        }

        public bool FlagAnomaly
        {
            get
            {
                return flagAnomaly;
            }

            set
            {
                flagAnomaly = value;
            }
        }

        public float ZReading
        {
            get
            {
                return zReading;
            }

            set
            {
                zReading = value;
            }
        }

        public float Trust
        {
            get
            {
                return trust;
            }

            set
            {
                trust = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public Anomaly() { }

        public Anomaly(float latitute, float longitude, bool flagAnomaly, float zReading, float trust, int count)
        {
            this.latitute = latitute;
            this.longitude = longitude;
            this.flagAnomaly = flagAnomaly;
            this.zReading = zReading;
            this.trust = trust;
            this.count = count;
        }

    }
}