using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotAssist.View.HardCode.Avrae {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Beyond : ContentPage, INotifyPropertyChanged {
        private string input = "";

        public new event PropertyChangedEventHandler PropertyChanged;
        public string Input {
            get => input;
            set {
                input = value;
                OnPropertyChanged(nameof(Input));
                OnPropertyChanged(nameof(Output));
            }
        }
        public string Output => $"!beyond {Input}".Trim();

        public Beyond() {
            InitializeComponent();
            BindingContext = this;
        }

        protected new virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private async void Button_Clicked(object sender, EventArgs e) {
            await Clipboard.SetTextAsync(Output);
            DependencyService.Get<IToast>().ShortAlert("Copied to Clipboard.");
            //DependencyService.Get<IOpenApp>().OpenExternalApp();
        }
    }
}