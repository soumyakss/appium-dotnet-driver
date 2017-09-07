using OpenQA.Selenium.Appium.Actions.Interfaces;
using System.Collections.Generic;

namespace OpenQA.Selenium.Appium
{
    public abstract partial class AppiumDriver<W> : IActionsPerformer where W : IWebElement
    {
        public void PerformActions(IActions actions)
        {
            // Serialize the actions to json
            string json = "";

            // Stuff it into a dictionary
            var parameters = new Dictionary<string, object>()
            {
                { "sources", json }
            };

            // Send it out for Execution
            Execute(AppiumDriverCommand.PerformActions, parameters);
        }
    }
}
