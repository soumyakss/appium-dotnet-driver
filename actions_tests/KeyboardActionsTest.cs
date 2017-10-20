using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Actions;
using OpenQA.Selenium.Appium.Actions.Enums;
using System.Collections.Generic;

namespace Appium.Integration.Tests.Actions
{
	[TestClass]
	public class KeyboardActionsTest : TestBase
	{
		[TestMethod]
		public void VirtualKeyboard_PressKeyTest()
		{
			var key = "should point to a const";
			var actualParameters = new OpenQA.Selenium.Appium.Actions.Actions()
									.Add(new VirtualKeyboard()
									.PressKey(key))
									.GetParameters();

			Assert.AreEqual(ExpectedParameters(InputActionSubtype.KeyDown, new string[] { key }), actualParameters);
		}

		[TestMethod]
		public void VirtualKeyboard_ReleaseKeyTest()
		{
			var key = "should point to a const";
			var actualParameters = new OpenQA.Selenium.Appium.Actions.Actions()
								  .Add(new VirtualKeyboard()
								  .ReleaseKey(key))
								  .GetParameters();

			Assert.AreEqual(ExpectedParameters(InputActionSubtype.KeyUp, new string[] { key }), actualParameters);
		}

		[TestMethod]
		public void VirtualKeyboard_PressKeysTest()
		{
			var keys = new string[] { "" };
			var actualParameters = new OpenQA.Selenium.Appium.Actions.Actions()
									.Add(new VirtualKeyboard()
									.PressKeys(keys))
									.GetParameters();

			Assert.AreEqual(ExpectedParameters(InputActionSubtype.KeyDown, keys), actualParameters);
		}

		[TestMethod]
		public void VirtualKeyboard_ReleaseKeysTest()
		{
			var keys = new string[] { "" };
			var actualParameters = new OpenQA.Selenium.Appium.Actions.Actions()
									.Add(new VirtualKeyboard()
									.ReleaseKeys(keys))
									.GetParameters();

			Assert.AreEqual(ExpectedParameters(InputActionSubtype.KeyUp, keys), actualParameters);
		}

		[TestMethod]
		public void VirtualKeyboard_PauseTest()
		{
			var keys = new string[] { "" };
			var actualParameters = new OpenQA.Selenium.Appium.Actions.Actions()
									.Add(new VirtualKeyboard()
									.Pause())
									.GetParameters();

			Assert.AreEqual(ExpectedParameters(InputActionSubtype.Pause, null), actualParameters);
		}

		[TestMethod]
		public void VirtualKeyboard_PauseDurationTest()
		{
			int duration = 0;
			var keys = new string[] { "" };
			var actualParameters = new OpenQA.Selenium.Appium.Actions.Actions()
									.Add(new VirtualKeyboard()
									.Pause(duration))
									.GetParameters();

			Assert.AreEqual(ExpectedParameters(InputActionSubtype.Pause, null, duration), actualParameters);
		}

		/// <summary>
		/// Default duration = 1 tick
		/// </summary>
		/// <param name="subType"></param>
		/// <param name="keys"></param>
		/// <param name="duration"></param>
		/// <returns></returns>
		private static Dictionary<string, object> ExpectedParameters(InputActionSubtype subType, string[] keys, int? duration = 1)
		{
			var actions = new Dictionary<string, object>[] { };

			if (subType.Equals(InputActionSubtype.KeyDown) || subType.Equals(InputActionSubtype.KeyUp))
			{				
				for (int i = 0; i < keys.Length; i++)
				{
					actions[i] = new Dictionary<string, object>
							{
								{ "subtype", subType },
								{ "value", keys[i] }
							};
				}
			}

			if (subType.Equals(InputActionSubtype.Pause))
			{				
				for (int i = 0; i < keys.Length; i++)
				{
					actions[i] = new Dictionary<string, object>
							{
								{ "subtype", subType },
								{ "duration",duration }
							};
				}
			}

			return new Dictionary<string, object>()
			{
				{
					"sources", new Dictionary<string, object>[]
					{
						new Dictionary<string, object>
						{
							{ "type", InputSourceType.Key.ToString() },
							{ "actions", actions}
						}
					}
				}
			};
		}

		
}
