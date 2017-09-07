using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using OpenQA.Selenium.Appium.Actions.Enums;
using OpenQA.Selenium.Appium.Actions.Interfaces;
using System.Collections.Generic;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public abstract class BaseInputSource : IInputSource
    {
        public IList<IInputAction> Actions { get; set; }

        public string Id { get; set; }

        public InputSourceParameters Parameters { get; set; }

        [JsonConverter(typeof(StringEnumConverter), true)]
        public abstract InputSourceType Type { get; }

        public Dictionary<string, object> GetParameters()
        {
            var sourceParameters = new List<Dictionary<string, object>>();
            foreach (var action in Actions)
            {
                //sourceParameters.Add(action);
            }

            return new Dictionary<string, object>()
            {
                { "actions", sourceParameters }
            };
        }

        public void Pause(double? duration = null)
        {
            Actions.Add(new PauseAction()
            {
                Duration = duration
            });
        }

        public void Perform(IActionsPerformer actionsPerformer)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };

            var json = JsonConvert.SerializeObject(this, settings);
            System.Diagnostics.Debug.WriteLine(json);
        }
    }
}
