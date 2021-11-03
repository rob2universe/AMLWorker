using System;
using System.Collections.Generic;
using CamundaClient.Dto;
using CamundaClient.Worker;

namespace AMLWorker
{

    [ExternalTaskTopic("amlC")]
    [ExternalTaskVariableRequirements("counter")]
    class AMLAdapterC : IExternalTaskAdapter
    {

        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            long counter = Convert.ToInt64(externalTask.Variables["counter"].Value);
            resultVariables.Add("counter", ++counter);
            Console.WriteLine(DateTime.Now + " - C - " + externalTask.ActivityId);
        }

    }
}
