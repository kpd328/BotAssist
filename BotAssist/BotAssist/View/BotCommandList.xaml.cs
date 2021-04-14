using BotAssist.Model.Object;
using BotAssist.View.HardCode.Avrae;
using BotAssist.View.HardCode.Rythm;
using BotAssist.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotAssist.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BotCommandList : ContentPage {
        public ObservableCollection<Model.Object.Command> Items { get; set; }

        public BotCommandList(Bot bot, BotListViewmodel viewmodel) {
            InitializeComponent();

            BindingContext = bot;

            Items = new ObservableCollection<Model.Object.Command>(bot.Commands);
            MyListView.ItemsSource = Items;

            var fav = new ToolbarItem {
                Text = "Favorite",
                CommandParameter = viewmodel
            };
            fav.BindingContext = bot;
            fav.SetBinding(MenuItem.IconImageSourceProperty, "FavoriteIcon");
            fav.SetBinding(MenuItem.CommandProperty, "FavButtonParam");
            ToolbarItems.Add(fav);
            ToolbarItems.Add(new ToolbarItem("Search", "ic_search_custom_24dp", () => Navigation.PushAsync(new SearchPage(Items))));
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e) {
            switch((e.Item as Model.Object.Command).ShortCommand) {
                case "!beyond":
                    Navigation.PushAsync(new Beyond());
                    break;
                case "!dicecloud":
                    Navigation.PushAsync(new Dicecloud());
                    break;
                case "!gsheet":
                    Navigation.PushAsync(new Gsheet());
                    break;
                case "!check":
                    Navigation.PushAsync(new Check());
                    break;
                case "!summon":
                    Navigation.PushAsync(new Summon());
                    break;
                case "!play":
                    Navigation.PushAsync(new Play());
                    break;
                default:
                    Navigation.PushAsync(new BotCommand(e.Item as Model.Object.Command));
                    break;
            }
        }
    }
}
