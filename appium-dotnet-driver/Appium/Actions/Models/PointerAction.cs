using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public class PointerAction : BaseInputAction
    {
        public IWebElement Element { get; set; }

        public int? Button { get; set; } 

        public double? X { get; set; }

        public double? Y { get; set; }

        public double? XOffset { get; set; }

        public double? YOffset { get; set; }

        [JsonConverter(typeof(StringEnumConverter), true)]
        public Origin? Origin { get; set; }

        public PointerAction(InputActionSubtype subtype) : base(subtype)
        {
        }
    }
}
