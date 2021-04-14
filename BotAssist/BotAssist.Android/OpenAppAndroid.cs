using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BotAssist.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(OpenAppAndroid))]
namespace BotAssist.Droid {
    [Activity(Label = "OpenAppAndroid")]
    public class OpenAppAndroid : Activity, IOpenApp {
        public OpenAppAndroid() { }

        public void OpenExternalApp() {
            Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage("yoururl");

            // If not NULL run the app, if not, take the user to the app store
            if(intent != null) {
                intent.AddFlags(ActivityFlags.NewTask);
                Forms.Context.StartActivity(intent);
            } else {
                intent = new Intent(Intent.ActionView);
                intent.AddFlags(ActivityFlags.NewTask);
                intent.SetData(Android.Net.Uri.Parse("discord://"));
                Forms.Context.StartActivity(intent);
            }
        }
    }
}