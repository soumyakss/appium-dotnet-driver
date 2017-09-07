using OpenQA.Selenium.Appium.Actions.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OpenQA.Selenium.Appium.Actions
{
    public class Actions : List<IInputSource>, IActions
    {
        public new IActions Add(IInputSource source)
        {
            base.Add(source);
            return this;
        }
        
        public void Cancel()
        {
            Clear();
        }

        public Dictionary<string, object> GetParameters()
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };

            var json = JsonConvert.SerializeObject(this, settings);
            System.Diagnostics.Debug.WriteLine(json);

            return new Dictionary<string, object>()
            {
                { "sources", json }
            };


            //var sourceParameters = new List<Dictionary<string, object>>();
            //foreach (var source in this)
            //{
            //    sourceParameters.Add(source.GetParameters());
            //}





            //return new Dictionary<string, object>()
            //{
            //    { "sources", sourceParameters }
            //};
        }

        public void Perform(IActionsPerformer actionsPerformer)
        {
            if (Count == 0)
            {
                throw new ArgumentException("Actions must have at least one action source added before it can be performed");
            }

            actionsPerformer.PerformActions(this);
        }
    }
}
