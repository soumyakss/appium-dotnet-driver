using OpenQA.Selenium.Appium.Actions.Enums;
using System.Collections.Generic;

namespace OpenQA.Selenium.Appium.Actions.Interfaces
{
    public interface IInputSource
    {
        string Id { get; }

        InputSourceType Type { get; }

        IList<IInputAction> Actions { get; }
    }
}
