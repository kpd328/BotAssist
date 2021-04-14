using BotAssist.Model.Object;
using BotAssist.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotAssist.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favorites : ContentPage {
        BotListViewmodel Viewmodel { get; set; }
        public Favorites(BotListViewmodel viewmodel) {
            InitializeComponent();

            Viewmodel = viewmodel;
            BindingContext = Viewmodel;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e) => Navigation.PushAsync(new BotCommandList(e.Item as Bot, Viewmodel));
    }
}