using OpenQA.Selenium.Appium.Actions.Enums;
using OpenQA.Selenium.Appium.Actions.Models;

namespace OpenQA.Selenium.Appium.Actions
{
    public class VirtualMouse : PointerInputSource
    {
        public VirtualMouse() : base(PointerType.Mouse)
        {
        }

        #region Press
        public VirtualMouse Press(MouseButton button = MouseButton.Left)
        {
            PointerDown((int)button);
            return this;
        }

        public VirtualMouse Press(IWebElement element, MouseButton button = MouseButton.Left)
        {
            return MoveTo(element).Press(button);
        }

        public VirtualMouse Press(double? x, double? y, Origin? origin = null, MouseButton button = MouseButton.Left)
        {
            return MoveTo(x, y, origin).Press(button);
        }

        public VirtualMouse Press(IWebElement element, double? xOffset, double? yOffset, MouseButton button = MouseButton.Left)
        {
            return MoveTo(element, xOffset, yOffset).Press(button);
        }
        #endregion

        #region Release
        public VirtualMouse Release(MouseButton button = MouseButton.Left)
        {
            PointerUp((int)button);
            return this;
        }

        public VirtualMouse Release(double? x, double? y, Origin? origin = null, MouseButton button = MouseButton.Left)
        {
            return MoveTo(x, y, origin).Release(button);
        }

        public VirtualMouse Release(IWebElement element, MouseButton button = MouseButton.Left)
        {
            return MoveTo(element).Release(button);
        }

        public VirtualMouse Release(IWebElement element, double? xOffset, double? yOffset, MouseButton button = MouseButton.Left)
        {
            return MoveTo(element, xOffset, yOffset).Release(button);
        }
        #endregion

        #region MoveTo
        public VirtualMouse MoveTo(IWebElement element)
        {
            PointerMove(element, null, null, null, null);
            return this;
        }

        public VirtualMouse MoveTo(IWebElement element, double? xOffset, double? yOffset)
        {
            PointerMove(element, xOffset, yOffset, null, null);
            return this;
        }

        public VirtualMouse MoveTo(IWebElement element, double? xOffset, double? yOffset, double? xSpeed, double? ySpeed)
        {
            PointerMove(element, xOffset, yOffset, xSpeed, ySpeed);
            return this;
        }

        public VirtualMouse MoveTo(double? x, double? y, Origin? origin = null)
        {
            PointerMove(x, y, null, null, origin);
            return this;
        }

        public VirtualMouse MoveTo(double? x, double? y, double? xSpeed, double? ySpeed, Origin? origin = null)
        {
            PointerMove(x, y, xSpeed, ySpeed, origin);
            return this;
        }
        #endregion

        #region Click
        public VirtualMouse Click(MouseButton button = MouseButton.Left)
        {
            return Press(button).Release(button);
        }

        public VirtualMouse Click(IWebElement element, MouseButton button = MouseButton.Left)
        {
            return Press(element, button).Release(button);
        }

        public VirtualMouse Click(double? x, double? y, Origin? origin = null, MouseButton button = MouseButton.Left)
        {
            return Press(x, y, origin, button).Release(button);
        }

        public VirtualMouse Click(IWebElement element, double? xOffset, double? yOffset, MouseButton button = MouseButton.Left)
        {
            return Press(element, xOffset, yOffset, button).Release(button);
        }
        #endregion

        public VirtualMouse Cancel()
        {
            PointerCancel();
            return this;
        }

        public new VirtualMouse Pause(double? duration = null)
        {
            base.Pause(duration);
            return this;
        }
    }
}
