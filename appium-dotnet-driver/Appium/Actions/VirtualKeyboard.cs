using OpenQA.Selenium.Appium.Actions.Models;

namespace OpenQA.Selenium.Appium.Actions
{
    public class VirtualKeyboard : KeyInputSource
    {
        public VirtualKeyboard PressKey(string key)
        {
            KeyDown(new string[] { key });
            return this;
        }

        public VirtualKeyboard ReleaseKey(string key)
        {
            KeyUp(new string[] { key });
            return this;
        }

        public VirtualKeyboard PressKeys(string[] keys)
        {
            KeyDown(keys);
            return this;
        }

        public VirtualKeyboard ReleaseKeys(string[] keys)
        {
            KeyUp(keys);
            return this;
        }

        public new VirtualKeyboard Pause(double? duration = null)
        {
            base.Pause(duration);
            return this;
        }
    }
}
