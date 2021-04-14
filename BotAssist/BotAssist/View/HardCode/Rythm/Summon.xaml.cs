using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotAssist.View.HardCode.Rythm {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Summon : ContentPage {
        public string Command => "!summon";

        public Summon() {
            InitializeComponent();
            BindingContext = this;
        }

        private async void Button_Clicked(object sender, EventArgs e) {
            await Clipboard.SetTextAsync(Command);
            DependencyService.Get<IToast>().ShortAlert("Copied to Clipboard.");
        }
    }
}