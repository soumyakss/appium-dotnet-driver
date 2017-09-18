using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Actions;
using OpenQA.Selenium.Appium.Actions.Enums;
using OpenQA.Selenium.Appium.Actions.Models;
using System.Collections.Generic;

namespace Appium.Integration.Tests.Actions
{
    [TestClass]
    public class ActionsTest : TestBase
    {
        [TestMethod]
        public void NullInputSourceTest()
        {
            var parameters = new OpenQA.Selenium.Appium.Actions.Actions()
                .Add(new NullInputSource()
                    // Pause
                    .Pause()
                    .Pause(100))
                .GetParameters();

            Assert.AreEqual(parameters, new Dictionary<string, object>()
            {

            });
        }

        [TestMethod]
        public void VirtualKeyboardTest()
        {
            var key = "";
            var keys = new string[] { "" };
            var duration = 0;

            var parameters = new OpenQA.Selenium.Appium.Actions.Actions()
                .Add(new VirtualKeyboard()
                    // PressKey
                    .PressKey(key)
                    // PressKeys
                    .PressKeys(keys)
                    // ReleaseKey
                    .ReleaseKey(key)
                    // ReleaseKeys
                    .ReleaseKeys(keys)
                    // Pause
                    .Pause()
                    .Pause(duration))
                .GetParameters();

            Assert.AreEqual(parameters, new Dictionary<string, object>()
            {

            });
        }

        [TestMethod]
        public void VirtualMouseTest()
        {
            IWebElement element = null;
            var xOffset = 0;
            var yOffset = 0;
            var x = 0;
            var y = 0;
            var duration = 0;

            var parameters = new OpenQA.Selenium.Appium.Actions.Actions()
                .Add(new VirtualMouse()
                    // Press
                    .Press()
                    .Press(MouseButton.Left)
                    .Press(element)
                    .Press(element, MouseButton.Left)
                    .Press(element, xOffset, yOffset)
                    .Press(element, xOffset, yOffset, MouseButton.Left)
                    .Press(x, y)
                    .Press(x, y, Origin.Pointer)
                    .Press(x, y, Origin.Pointer, MouseButton.Left)
                    // MoveTo
                    .MoveTo(element)
                    .MoveTo(element, xOffset, yOffset)
                    .MoveTo(x, y)
                    .MoveTo(x, y, Origin.Pointer)
                    // Release
                    .Release()
                    .Release(MouseButton.Left)
                    .Release(element)
                    .Release(element, xOffset, yOffset)
                    .Release(element, xOffset, yOffset, MouseButton.Left)
                    .Release(element, MouseButton.Left)
                    .Release(x, y)
                    .Release(x, y, Origin.Pointer)
                    .Release(x, y, Origin.Pointer, MouseButton.Left)
                    // Click
                    .Click()
                    .Click(MouseButton.Left)
                    .Click(element)
                    .Click(element, MouseButton.Left)
                    .Click(element, xOffset, yOffset)
                    .Click(element, xOffset, yOffset, MouseButton.Left)
                    // Pause
                    .Pause()
                    .Pause(duration)
                    // Cancel
                    .Cancel())
                .GetParameters();

            Assert.AreEqual(parameters, new Dictionary<string, object>()
            {

            });
        }

        [TestMethod]
        public void VirtualPenTest()
        {
            IWebElement element = null;
            var xOffset = 0;
            var yOffset = 0;
            var x = 0;
            var y = 0;
            var duration = 0;

            var parameters = new OpenQA.Selenium.Appium.Actions.Actions()
                .Add(new VirtualPen()
                    // Press
                    .Press()
                    .Press(PenTip.Tip)
                    .Press(element)
                    .Press(element, PenTip.Tip)
                    .Press(element, xOffset, yOffset)
                    .Press(element, xOffset, yOffset, PenTip.Tip)
                    .Press(x, y)
                    .Press(x, y, Origin.Pointer)
                    .Press(x, y, Origin.Pointer, PenTip.Tip)
                    // MoveTo
                    .MoveTo(element)
                    .MoveTo(element, xOffset, yOffset)
                    .MoveTo(x, y)
                    .MoveTo(x, y, Origin.Pointer)
                    // Release
                    .Release()
                    .Release(element)
                    .Release(element, xOffset, yOffset)
                    .Release(x, y)
                    .Release(x, y, Origin.Pointer)
                    // SetTipPressure
                    .SetTipPressure(.5)
                    // SetTipAngle
                    .SetTipAngle(45)
                    // PressButton
                    .PressButton()
                    .PressButton(PenButton.Eraser)
                    // ReleaseButton
                    .ReleaseButton()
                    .ReleaseButton(PenButton.Eraser)
                    // Click
                    .Click()
                    .Click(PenButton.Barrel)
                    // Tap
                    .Tap()
                    .Tap(element)
                    .Tap(element, xOffset, yOffset)
                    .Tap(x, y)
                    .Tap(x, y, Origin.Pointer)
                    // Pause
                    .Pause()
                    .Pause(duration)
                    // Cancel
                    .Cancel())
                .GetParameters();

            Assert.AreEqual(parameters, new Dictionary<string, object>()
            {

            });
        }

        [TestMethod]
        public void VirtualTouchTest()
        {
            IWebElement element = null;
            var xOffset = 0;
            var yOffset = 0;
            var x = 0;
            var y = 0;
            var duration = 0;

            var parameters = new OpenQA.Selenium.Appium.Actions.Actions()
                .Add(new VirtualTouch()
                    // Press
                    .Press()
                    .Press(element)
                    .Press(element, xOffset, yOffset)
                    .Press(x, y)
                    .Press(x, y, Origin.Pointer)
                    // MoveTo
                    .MoveTo(element)
                    .MoveTo(element, xOffset, yOffset)
                    .MoveTo(x, y)
                    .MoveTo(x, y, Origin.Pointer)
                    // Release
                    .Release()
                    .Release(element)
                    .Release(element, xOffset, yOffset)
                    .Release(x, y)
                    .Release(x, y, Origin.Pointer)
                    // Tap
                    .Tap()
                    .Tap(element)
                    .Tap(element, xOffset, yOffset)
                    .Tap(x, y)
                    .Tap(x, y, Origin.Pointer)
                    // Pause
                    .Pause()
                    .Pause(duration)
                    // Cancel
                    .Cancel())
                .GetParameters();

            Assert.AreEqual(parameters, new Dictionary<string, object>()
            {

            });
        }
    }
}
