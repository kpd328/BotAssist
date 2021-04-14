using BotAssist.Model.Object;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotAssist.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage {
        public SearchPage(ObservableCollection<Bot> context) {
            InitializeComponent();
        }

        public SearchPage(ObservableCollection<Model.Object.Command> context) {
            InitializeComponent();
        }
    }
}