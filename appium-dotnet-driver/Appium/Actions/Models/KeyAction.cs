using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public class KeyAction : BaseInputAction
    {
        public string[] Keys { get; set; }

        public KeyAction(InputActionSubtype subtype) : base (subtype)
        {
        }
    }
}
