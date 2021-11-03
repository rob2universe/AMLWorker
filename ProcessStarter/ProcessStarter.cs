using System;
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient;

namespace ProcessStarter
{
    class ProcessStarter
    {
        private static string logo = "CAMUNDA PROCESS STARTER";

        private static void Main(string[] args)
        {

            Console.WriteLine(logo + "\n\n" + "Starting a lot of process instances.");

            CamundaEngineClient camunda = new CamundaEngineClient();

            var data = new Dictionary<string, object>
            {
                { "counter", 0 }
            };

            Stopwatch stopWatch = new();
            stopWatch.Start();
            int i = 1;
            while (i <= 10000)
            {
                var pi = camunda.BpmnWorkflowService.StartProcessInstance("AMLProcessProcess", "bk" + i, data);
                Console.WriteLine(i + " : " + pi);
                i++;
            }
            stopWatch.Stop();
            Console.WriteLine("Elapsed: " + stopWatch.Elapsed);
            Console.ReadLine(); // wait for ANY KEY
        }
    }
}
