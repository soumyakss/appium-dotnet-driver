using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public class NullInputSource : BaseInputSource
    {
        public override InputSourceType Type => InputSourceType.None;

        public new NullInputSource Pause(double? duration = null)
        {
            Pause(duration);
            return this;
        }
    }
}
