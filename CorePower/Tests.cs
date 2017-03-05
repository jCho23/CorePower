using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace CorePower
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}


		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("locations_searchZip");
			app.Screenshot("Tapped on 'Search Zip-Code' Text Field");
			app.EnterText("94111");
			app.Screenshot("We entered in our Zip-Code");
			app.PressEnter();
			app.Screenshot("Then we will Tap the 'Enter' key");
			app.Tap("name");
			app.Screenshot("Lets select the closest CorePower Yoga");

			app.Tap("tile_promo_title");
			app.Screenshot("We Tapped on'Announcements");
			Thread.Sleep(8000);
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			app.Tap("tile_contactus_title");
			app.Screenshot("Then, we Tapped on the 'Contact' Button");
			Thread.Sleep(8000);
			app.Back();
			app.Screenshot("Dismissed keyboard");app.Screenshot("We Tapped the 'Back' Button");

			app.Tap("tile_card_title");
			app.Screenshot("We Tapped on 'Key Tag'");
			Thread.Sleep(8000);
			app.DismissKeyboard();
			app.Screenshot("Dismissed keyboard");
			Thread.Sleep(8000);
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");
			app.Tap("tile_feedback_title");
			app.Screenshot("Then, we Tapped on the 'Feedback' Button");
			app.Tap("feedbackText");
			app.Screenshot("Next, we Tapped on the 'Feeback' Text Field");
			app.EnterText("Microsoft loves CorePower");

			app.DismissKeyboard();
			app.Screenshot("Dismissed keyboard");
			app.Tap("feedbackSendButton_bottom");
			app.Screenshot("We Tapped on the 'Send Feedback' Button");
			app.Tap("button3");
			app.Screenshot("Then, we Tapped on the 'OK' Button");

			app.Tap("spinnerTarget");
			app.Screenshot("Let's Tap on the 'Select Feedbacl' Spinner");
			app.Tap("text1");
			app.Screenshot("We selected our feedback type");
			app.Tap("feedbackSendButton_bottom");
			app.Screenshot("We Tapped on the 'Send Feedback' Button");
		}

	}
}
