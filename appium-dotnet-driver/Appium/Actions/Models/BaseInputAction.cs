using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenQA.Selenium.Appium.Actions.Enums;
using OpenQA.Selenium.Appium.Actions.Interfaces;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public abstract class BaseInputAction : IInputAction
    {
        [JsonConverter(typeof(StringEnumConverter), true)]
        public InputActionSubtype Subtype { get; }

        public BaseInputAction(InputActionSubtype subtype)
        {
            Subtype = subtype;
        }
    }
}
