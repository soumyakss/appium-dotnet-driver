using OpenQA.Selenium.Appium.Actions.Enums;
using OpenQA.Selenium.Appium.Actions.Models;

namespace OpenQA.Selenium.Appium.Actions
{
    public class VirtualPen : PointerInputSource
    {
        public VirtualPen() : base(PointerType.Pen)
        {
        }

        #region Press
        public VirtualPen Press(PenTip tip = PenTip.Tip)
        {
            PointerDown((int)tip);
            return this;
        }

        public VirtualPen Press(IWebElement element, PenTip tip = PenTip.Tip)
        {
            return MoveTo(element).Press(tip);
        }

        public VirtualPen Press(double? x, double? y, Origin? origin = null, PenTip tip = PenTip.Tip)
        {
            return MoveTo(x, y, origin).Press(tip);
        }

        public VirtualPen Press(IWebElement element, double? xOffset, double? yOffset, PenTip tip = PenTip.Tip)
        {
            return MoveTo(element, xOffset, yOffset).Press(tip);
        }
        #endregion

        #region Release
        public VirtualPen Release()
        {
            PointerUp();
            return this;
        }

        public VirtualPen Release(double? x, double? y, Origin? origin = null)
        {
            return MoveTo(x, y, origin).Release();
        }

        public VirtualPen Release(IWebElement element)
        {
            return MoveTo(element).Release();
        }

        public VirtualPen Release(IWebElement element, double? xOffset, double? yOffset)
        {
            return MoveTo(element, xOffset, yOffset).Release();
        }
        #endregion

        #region MoveTo
        public VirtualPen MoveTo(IWebElement element)
        {
            PointerMove(element, null, null, null, null);
            return this;
        }

        public VirtualPen MoveTo(IWebElement element)
        {
            PointerMove(element, null, null, null, null);
            return this;
        }

        public VirtualPen MoveTo(IWebElement element, double? xOffset, double? yOffset)
        {
            PointerMove(element, xOffset, yOffset, null, null);
            return this;
        }

        public VirtualPen MoveTo(double? x, double? y, Origin? origin = null)
        {
            PointerMove(x, y, origin);
            return this;
        }
        #endregion

        #region Tap
        public VirtualPen Tap()
        {
            return Press().Release();
        }

        public VirtualPen Tap(IWebElement element)
        {
            return Press(element).Release();
        }

        public VirtualPen Tap(double? x, double? y, Origin? origin = null)
        {
            return Press(x, y, origin).Release();
        }

        public VirtualPen Tap(IWebElement element, double? xOffset, double? yOffset)
        {
            return Press(element, xOffset, yOffset).Release();
        }
        #endregion

        #region Pen Buttons
        protected void PressButton(int? button)
        {
            Actions.Add(new PointerAction(InputActionSubtype.KeyDown)
            {
                Button = button
            });
        }

        protected void ReleaseButton(int? button)
        {
            Actions.Add(new PointerAction(InputActionSubtype.KeyUp)
            {
                Button = button
            });
        }

        public VirtualPen PressButton(PenButton button = PenButton.Barrel)
        {
            PressButton((int?)button);
            return this;
        }

        public VirtualPen ReleaseButton(PenButton button = PenButton.Barrel)
        {
            ReleaseButton((int?)button);
            return this;
        }

        public VirtualPen Click(PenButton button = PenButton.Barrel)
        {
            return PressButton(button).ReleaseButton(button);
        }
        #endregion

        #region Pressure & Angle
        protected void SetPressure(double? percentage)
        {
            Actions.Add(new PenAction(InputActionSubtype.SetPressure)
            {
                Pressure = percentage
            });
        }

        protected void SetAngle(double? degrees)
        {
            Actions.Add(new PenAction(InputActionSubtype.SetAngle)
            {
                Angle = degrees
            });
        }

        public VirtualPen SetTipPressure(double? percentage)
        {
            SetPressure(percentage);
            return this;
        }

        public VirtualPen SetTipAngle(double? degrees)
        {
            SetAngle(degrees);
            return this;
        }
        #endregion

        public VirtualPen Cancel()
        {
            PointerCancel();
            return this;
        }

        public new VirtualPen Pause(double? duration = null)
        {
            base.Pause(duration);
            return this;
        }
    }
}
