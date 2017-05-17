using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Diagnostics;

namespace RoadAnomaliesService.Models
{
    public class Worker
    {
        private Thread workerThread;
        private DataController dataController;

        public Worker() {
            dataController = new DataController();
            workerThread = new Thread(this.DoWork);
            workerThread.Start();
        }

        public void DoWork() {

            while (true) {
                dataController.updateTrust();
                Debug.WriteLine(DateTime.Now);
                Thread.Sleep(30000); // millisecondi in una giornata 86400000
            }
        }
    }
}