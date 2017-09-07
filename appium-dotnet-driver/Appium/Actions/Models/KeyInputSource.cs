using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public class KeyInputSource : BaseInputSource
    {
        public override InputSourceType Type => InputSourceType.Key;

        public void KeyDown(string[] keys)
        {
            Actions.Add(new KeyAction(InputActionSubtype.KeyDown)
            {
                Keys = keys
            });
        }

        public void KeyUp(string[] keys)
        {
            Actions.Add(new KeyAction(InputActionSubtype.KeyUp)
            {
                Keys = keys
            });
        }
    }
}
