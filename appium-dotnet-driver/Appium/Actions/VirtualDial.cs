using OpenQA.Selenium.Appium.Actions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions
{
    public class VirtualDial : KeyInputSource
    {
        public override InputSourceType Type => InputSourceType.Dial;

        public VirtualDial Press()
        {
            KeyDown(null);
            return this;
        }

        public VirtualDial Release()
        {
            KeyUp(null);
            return this;
        }

        public VirtualDial Rotate(double degrees)
        {
            Actions.Add(new KeyAction(InputActionSubtype.KeyDown)
            {
                Keys = keys
            });
            return this;
        }
    }
}
