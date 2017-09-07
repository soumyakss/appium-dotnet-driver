using OpenQA.Selenium.Appium.Actions.Enums;
using OpenQA.Selenium.Appium.Actions.Models;

namespace OpenQA.Selenium.Appium.Actions
{
    public class VirtualTouch : PointerInputSource
    {
        public VirtualTouch() : base(PointerType.Touch)
        {
        }

        #region Press
        public VirtualTouch Press()
        {
            PointerDown();
            return this;
        }

        public VirtualTouch Press(IWebElement element)
        {
            return MoveTo(element).Press();
        }

        public VirtualTouch Press(double? x, double? y, Origin? origin = null)
        {
            return MoveTo(x, y, origin).Press();
        }

        public VirtualTouch Press(IWebElement element, double? xOffset, double? yOffset)
        {
            return MoveTo(element, xOffset, yOffset).Press();
        }
        #endregion

        #region Release
        public VirtualTouch Release(MouseButton button = MouseButton.Left)
        {
            PointerUp((int)button);
            return this;
        }

        public VirtualTouch Release(double? x, double? y, Origin? origin = null)
        {
            return MoveTo(x, y, origin).Release();
        }

        public VirtualTouch Release(IWebElement element)
        {
            return MoveTo(element).Release();
        }

        public VirtualTouch Release(IWebElement element, double? xOffset, double? yOffset)
        {
            return MoveTo(element, xOffset, yOffset).Release();
        }
        #endregion

        #region MoveTo
        public VirtualTouch MoveTo(IWebElement element)
        {
            PointerMove(element, null, null);
            return this;
        }

        public VirtualTouch MoveTo(IWebElement element, double? xOffset, double? yOffset)
        {
            PointerMove(element, xOffset, yOffset);
            return this;
        }

        public VirtualTouch MoveTo(double? x, double? y, Origin? origin = null)
        {
            PointerMove(x, y, origin);
            return this;
        }
        #endregion

        #region Tap
        public VirtualTouch Tap()
        {
            return Press().Release();
        }

        public VirtualTouch Tap(IWebElement element)
        {
            return Press(element).Release();
        }

        public VirtualTouch Tap(double? x, double? y, Origin? origin = null)
        {
            return Press(x, y, origin).Release();
        }

        public VirtualTouch Tap(IWebElement element, double? xOffset, double? yOffset)
        {
            return Press(element, xOffset, yOffset).Release();
        }
        #endregion

        public VirtualTouch Cancel()
        {
            PointerCancel();
            return this;
        }

        public new VirtualTouch Pause(double? duration = null)
        {
            base.Pause(duration);
            return this;
        }
    }
}
