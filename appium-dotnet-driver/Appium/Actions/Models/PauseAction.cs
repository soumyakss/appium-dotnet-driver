using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public class PauseAction : BaseInputAction
    {
        public double? Duration { get; set; }

        public PauseAction() : base(InputActionSubtype.Pause)
        {
        }
    }
}