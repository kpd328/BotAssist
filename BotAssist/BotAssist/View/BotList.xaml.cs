using BotAssist.Model.Object;
using BotAssist.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotAssist.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BotList : ContentPage {
        BotListViewmodel Viewmodel { get; set; }

        public BotList(BotListViewmodel viewmodel) {
            InitializeComponent();

            Viewmodel = viewmodel;
            BindingContext = Viewmodel;

            ToolbarItems.Add(new ToolbarItem("Search", "ic_search_custom_24dp", () => Navigation.PushAsync(new SearchPage(Viewmodel.AllItems))));
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e) => Navigation.PushAsync(new BotCommandList(e.Item as Bot, Viewmodel));

        private void Button_Clicked(object sender, EventArgs e) {
            Viewmodel.FilterItems();
        }
    }
}
