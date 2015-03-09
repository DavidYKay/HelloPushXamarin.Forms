using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace HelloPushXamarin.Forms.iOS
{
  [Register ("AppDelegate")]
  public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
  {
    public override bool FinishedLaunching (UIApplication app, NSDictionary options)
    {
      global::Xamarin.Forms.Forms.Init ();
      
      Console.WriteLine ("Finished Launching");
      Console.WriteLine ("bundle ID: " + NSBundle.MainBundle.BundleIdentifier);

      app.RegisterForRemoteNotifications();

      LoadApplication (new App ());

      return base.FinishedLaunching (app, options);
    }

    public override void ReceivedRemoteNotification(UIApplication application, NSDictionary userInfo)
    {
      Console.WriteLine ("ReceivedRemoteNotification (foreground)");

    }

    public override void DidReceiveRemoteNotification (UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler) {
      Console.WriteLine ("DidReceiveRemoteNotification (background)");
    }

    public override void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken) {
      Console.WriteLine ("RegisteredForRemoteNotifications: " + deviceToken.ToString());

    }

    public override void DidRegisterUserNotificationSettings (UIApplication application, UIUserNotificationSettings notificationSettings) {
      Console.WriteLine ("DidRegisterUserNotificationSettings: " + notificationSettings);
    }

    public override void FailedToRegisterForRemoteNotifications (UIApplication application, NSError error) {
      Console.WriteLine ("FailedToRegisterForRemoteNotifications" + error);

    }

  }
}

