using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using CamundaClient;

namespace AMLWorker
{
    class Program
    {
        private static string logo = "CAMUNDA C# TASK WORKER";

        private static void Main(string[] args)
        {

            Console.WriteLine(logo + "\n\n" + "Deploying models and start External Task Workers.\n\nPRESS ANY KEY TO STOP WORKERS.\n\n");

            CamundaEngineClient camunda = new CamundaEngineClient();

            camunda.Startup(); // Deploys all models to Camunda and Start all found ExternalTask-Workers
            var start = DateTime.Now;
            Console.ReadLine(); // wait for ANY KEY
            Console.WriteLine("Started: " + start);
            camunda.Shutdown(); // Stop Task Workers
        }
    }
}
