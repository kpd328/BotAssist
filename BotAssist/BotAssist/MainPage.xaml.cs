using BotAssist.Model.Object;
using BotAssist.View;
using BotAssist.ViewModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace BotAssist {
    public partial class MainPage : FlyoutPage {
        public ObservableCollection<Bot> Items { get; set; }

        public MainPage() {
            InitializeComponent();

            var BotListVM = new BotListViewmodel();

            Flyout = new Favorites(BotListVM);
            Detail = new NavigationPage(new BotList(BotListVM));
        }
    }
}
