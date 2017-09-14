using Appium.Integration.Tests.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Actions;
using OpenQA.Selenium.Appium.Actions.Enums;
using OpenQA.Selenium.Appium.Actions.Models;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium.Integration.Tests.Actions
{
    public class ActionsTest
    {
        private WindowsDriver<WindowsElement> driver;
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723/wd/hub";
        protected static WindowsDriver<WindowsElement> AppSession;
        protected static WindowsDriver<WindowsElement> DesktopSession;

        protected static RemoteWebElement Result;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");

            // TODO: What about supporting AppiumServers.sauceURI ???
            AppSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities, Env.INIT_TIMEOUT_SEC);
            AppSession.Manage().Timeouts().ImplicitlyWait(Env.IMPLICIT_TIMEOUT_SEC);

            AppSession.FindElementByName("Clear").Click();
            AppSession.FindElementByName("Seven").Click();
            Result = AppSession.FindElementByName("Display is  7 ") as RemoteWebElement;
            Assert.IsNotNull(Result);
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            Result = null;
            AppSession.CloseApp();
            AppSession.Dispose();
            AppSession = null;
        }

        [SetUp]
        public void SetUp()
        {
            AppSession.FindElementByName("Clear").Click();
            Assert.AreEqual("Display is  0 ", Result.Text);
        }

        [Test]
        public void MyTest()
        {
            IWebElement element = null;
            int xOffset = 0,
                yOffset = 0,
                x = 0,
                y = 0;
            string key = "7";
            string[] keys = new string[] { "key1", "key2", "key3" };
            double duration = 0;

            new OpenQA.Selenium.Appium.Actions.Actions()
                //.Add(new NullInputSource()
                //    // Pause
                //    .Pause()
                //    .Pause(duration))
                //.Add(new VirtualKeyboard()
                //    // PressKey
                //    .PressKey(key)
                //    // PressKeys
                //    .PressKeys(keys)
                //    // ReleaseKey
                //    .ReleaseKey(key)
                //    // ReleaseKeys
                //    .ReleaseKeys(keys)
                //    // Pause
                //    .Pause()
                //    .Pause(duration))
                //.Add(new VirtualMouse()
                //    // Press
                //    .Press()
                //    .Press(MouseButton.Left)
                //    .Press(element)
                //    .Press(element, MouseButton.Left)
                //    .Press(element, xOffset, yOffset)
                //    .Press(element, xOffset, yOffset, MouseButton.Left)
                //    .Press(x, y)
                //    .Press(x, y, Origin.Pointer)
                //    .Press(x, y, Origin.Pointer, MouseButton.Left)
                //    // MoveTo
                //    .MoveTo(element)
                //    .MoveTo(element, xOffset, yOffset)
                //    .MoveTo(x, y)
                //    .MoveTo(x, y, Origin.Pointer)
                //    // Release
                //    .Release()
                //    .Release(MouseButton.Left)
                //    .Release(element)
                //    .Release(element, xOffset, yOffset)
                //    .Release(element, xOffset, yOffset, MouseButton.Left)
                //    .Release(element, MouseButton.Left)
                //    .Release(x, y)
                //    .Release(x, y, Origin.Pointer)
                //    .Release(x, y, Origin.Pointer, MouseButton.Left)
                //    // Click
                //    .Click()
                //    .Click(MouseButton.Left)
                //    .Click(element)
                //    .Click(element, MouseButton.Left)
                //    .Click(element, xOffset, yOffset)
                //    .Click(element, xOffset, yOffset, MouseButton.Left)
                //    // Pause
                //    .Pause()
                //    .Pause(duration)
                //    // Cancel
                //    .Cancel())
                //.Add(new VirtualPen()
                //    // Press
                //    .Press()
                //    .Press(PenTip.Tip)
                //    .Press(element)
                //    .Press(element, PenTip.Tip)
                //    .Press(element, xOffset, yOffset)
                //    .Press(element, xOffset, yOffset, PenTip.Tip)
                //    .Press(x, y)
                //    .Press(x, y, Origin.Pointer)
                //    .Press(x, y, Origin.Pointer, PenTip.Tip)
                //    // MoveTo
                //    .MoveTo(element)
                //    .MoveTo(element, xOffset, yOffset)
                //    .MoveTo(x, y)
                //    .MoveTo(x, y, Origin.Pointer)
                //    // Release
                //    .Release()
                //    .Release(element)
                //    .Release(element, xOffset, yOffset)
                //    .Release(x, y)
                //    .Release(x, y, Origin.Pointer)
                //    // SetTipPressure
                //    .SetTipPressure(.5)
                //    // SetTipAngle
                //    .SetTipAngle(45)
                //    // PressButton
                //    .PressButton()
                //    .PressButton(PenButton.Eraser)
                //    // ReleaseButton
                //    .ReleaseButton()
                //    .ReleaseButton(PenButton.Eraser)
                //    // Click
                //    .Click()
                //    .Click(PenButton.Barrel)
                //    // Tap
                //    .Tap()
                //    .Tap(element)
                //    .Tap(element, xOffset, yOffset)
                //    .Tap(x, y)
                //    .Tap(x, y, Origin.Pointer)
                //    // Pause
                //    .Pause()
                //    .Pause(duration)
                //    // Cancel
                //    .Cancel())
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
                .Perform(AppSession);
        }
    }
}
