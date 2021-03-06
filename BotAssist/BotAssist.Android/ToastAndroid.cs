using Android.App;
using Android.Widget;
using BotAssist.Droid;
using System;

[assembly: Xamarin.Forms.Dependency(typeof(ToastAndroid))]
namespace BotAssist.Droid {
    public class ToastAndroid : IToast {
        public void LongAlert(string message) {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortAlert(string message) {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}