using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenQA.Selenium.Appium.Actions.Enums;

namespace OpenQA.Selenium.Appium.Actions.Models
{
    public class PointerInputSource : BaseInputSource
    {
        [JsonConverter(typeof(StringEnumConverter), true)]
        public override InputSourceType Type => InputSourceType.Pointer;

        public PointerInputSource(PointerType pointerType)
        {
            Parameters.PointerType = pointerType;
        }

        protected void PointerDown()
        {
            PointerDown(null);
        }

        protected void PointerDown(int? button)
        {
            Actions.Add(new PointerAction(InputActionSubtype.PointerDown));
        }

        protected void PointerUp()
        {
            PointerUp(null);
        }

        protected void PointerUp(int? button)
        {
            Actions.Add(new PointerAction(InputActionSubtype.PointerUp));
        }

        protected void PointerMove(IWebElement element, double? xOffset, double? yOffset, double? xSpeed, double? ySpeed)
        {
            Actions.Add(new PointerAction(InputActionSubtype.PointerMove)
            {
                Element = element,
                XOffset = xOffset,
                YOffset = yOffset,
                XSpeed = xSpeed,
                YSpeed = ySpeed
            });
        }

        protected void PointerMove(double? x, double? y, double? xSpeed, double? ySpeed, Origin? origin)
        {
            Actions.Add(new PointerAction(InputActionSubtype.PointerMove)
            {
                X = x,
                Y = y,
                XSpeed = xSpeed,
                YSpeed = ySpeed,
                Origin = origin
            });
        }

        protected void PointerCancel()
        {
            Actions.Add(new PointerAction(InputActionSubtype.PointerCancel));
        }
    }
}
