using BotAssist.Model.Object;
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

        public BotCommandList(Bot bot) {
            InitializeComponent();

            Items = new ObservableCollection<Model.Object.Command>(bot.Commands);
            MyListView.ItemsSource = Items;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e) => Navigation.PushAsync(new BotCommand(e.Item as Model.Object.Command));
    }
}
