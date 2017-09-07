using OpenQA.Selenium.Appium.Actions.Enums;
using OpenQA.Selenium.Appium.Actions.Models;
using System.Collections.Generic;

namespace OpenQA.Selenium.Appium.Actions.Interfaces
{
    public interface IInputSource
    {
        string Id { get; }

        InputSourceType Type { get; }

        //InputSourceParameters Parameters { get; }

        IList<IInputAction> Actions { get; }

        Dictionary<string, object> GetParameters();

        void Perform(IActionsPerformer actionsPerformer);
    }
}
