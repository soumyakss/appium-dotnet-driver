using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public class PenAction : PointerAction
    {
        public double? Pressure { get; set; }

        public double? Angle { get; set; }

        public PenAction(InputActionSubtype subtype) : base(subtype)
        {
        }
    }
}
