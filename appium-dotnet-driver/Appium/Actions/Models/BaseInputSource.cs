using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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

        public BaseInputSource()
        {
            Actions = new List<IInputAction>();
            Parameters = new InputSourceParameters();
        }

        public void Pause(double? duration = null)
        {
            Actions.Add(new PauseAction()
            {
                Duration = duration
            });
        }
    }
}
