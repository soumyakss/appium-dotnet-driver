using System.Collections.Generic;

namespace OpenQA.Selenium.Appium.Actions.Interfaces
{
    public interface IActions
    {
        IActions Add(IInputSource source);

        void Cancel();

        void Perform(IActionsPerformer actionsPerformer);

        Dictionary<string, object> GetParameters();
    }
}
