using OpenQA.Selenium.Appium.Actions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Actions.Enums;
using System.Drawing;

namespace OpenQA.Selenium.Appium.Actions
{
    public class VirtualDial : BaseInputSource
    {
        public override InputSourceType Type => InputSourceType.Dial;

        public VirtualDial Press()
        {
            Actions.Add(new DialAction(InputActionSubtype.KeyDown)); // No parameters necessary.
            return this;
        }

        public VirtualDial Release()
        {
            Actions.Add(new DialAction(InputActionSubtype.KeyUp)); // No parameters necessary.
            return this;
        }

        public VirtualDial Click()
        {
            return Press().Release();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="degrees">The degrees to rotate the VirtualDial. Positive value executes clockwise, negative is counter-clockwise.</param>
        /// <returns></returns>
        public VirtualDial Rotate(double degrees)
        {
            Actions.Add(new DialAction(InputActionSubtype.SetAngle)
            {
                 Angle = degrees
            });
            return this;
        }

        public VirtualDial SetScreenPlacement(IWebElement element)
        {
            Actions.Add(new DialAction(InputActionSubtype.SetPlacement)
            {
                Element = element
            });
            return this;
        }

        public VirtualDial SetScreenPlacement(IWebElement element, double? xOffset, double? yOffset)
        {
            Actions.Add(new DialAction(InputActionSubtype.SetPlacement)
            {
                Element = element,
                XOffset = xOffset,
                YOffset = yOffset
            });
            return this;
        }

        public VirtualDial SetScreenPlacement(double? x, double? y, Origin? origin = null)
        {
            Actions.Add(new DialAction(InputActionSubtype.SetPlacement)
            {
                X = x,
                Y = y,
                Origin = origin
            });
            return this;
        }

        public VirtualDial RemoveFromScreen()
        {
            // Empty Dial action with SetPlacement subtype assumes device removal from screen.
            Actions.Add(new DialAction(InputActionSubtype.SetPlacement));
            return this;
        }
    }
}
