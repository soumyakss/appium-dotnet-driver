using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public class KeyInputSource : BaseInputSource
    {
        public override InputSourceType Type => InputSourceType.Key;

        protected void KeyDown(string[] keys)
        {
            Actions.Add(new KeyAction(InputActionSubtype.KeyDown)
            {
                Keys = keys
            });
        }

        protected void KeyUp(string[] keys)
        {
            Actions.Add(new KeyAction(InputActionSubtype.KeyUp)
            {
                Keys = keys
            });
        }
    }
}
