using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public class InputSourceParameters
    {
        [JsonConverter(typeof(StringEnumConverter), true)]
        public PointerType PointerType { get; set; }
    }
}
