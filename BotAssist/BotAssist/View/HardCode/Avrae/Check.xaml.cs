using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotAssist.View.HardCode.Avrae {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Check : ContentPage, INotifyPropertyChanged {
        private string input1 = "";
        private string input2 = "";
        private int? input3 = null;
        private int? input4 = null;
        private int? input5 = null;
        private int? input6 = null;
        private string input7 = "";

        public new event PropertyChangedEventHandler PropertyChanged;
        public string Input1 {
            get => input1;
            set {
                input1 = value;
                OnPropertyChanged(nameof(Input1));
                OnPropertyChanged(nameof(Output));
            }
        }
        public string Input2 {
            get => input2;
            set {
                input2 = value;
                OnPropertyChanged(nameof(Input2));
                OnPropertyChanged(nameof(Output));
            }
        }
        public string Input3 {
            get => input3.ToString();
            set {
                try {
                    input3 = int.Parse(value);
                } catch(Exception) {
                    input3 = null;
                }
                OnPropertyChanged(nameof(Input3));
                OnPropertyChanged(nameof(Output));
            }
        }
        public string Input4 {
            get => input4.ToString();
            set {
                try {
                    input4 = int.Parse(value);
                } catch(Exception) {
                    input4 = null;
                }
                OnPropertyChanged(nameof(Input4));
                OnPropertyChanged(nameof(Output));
            }
        }
        public string Input5 {
            get => input5.ToString();
            set {
                try {
                    input5 = int.Parse(value);
                } catch(Exception) {
                    input5 = null;
                }
                OnPropertyChanged(nameof(Input5));
                OnPropertyChanged(nameof(Output));
            }
        }
        public string Input6 {
            get => input6.ToString();
            set {
                try {
                    input6 = int.Parse(value);
                } catch(Exception) {
                    input6 = null;
                }
                OnPropertyChanged(nameof(Input6));
                OnPropertyChanged(nameof(Output));
            }
        }
        public string Input7 {
            get => input7.ToString();
            set {
                input7 = value;
                OnPropertyChanged(nameof(Input7));
                OnPropertyChanged(nameof(Output));
            }
        }
        public string SubOut1 => Input3 == "" ? "" : $"-b {Input3}";
        public string SubOut2 => Input4 == "" ? "" : $"-dc {Input4}";
        public string SubOut3 => Input5 == "" ? "" : $"-mc {Input5}";
        public string SubOut4 => Input6 == "" ? "" : $"-rr {Input6}";

        public string Output => string.Join(separator: ' ', "!check", Input1, Input2, SubOut1, SubOut2, SubOut3, SubOut4, Input7);
        public Check() {
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