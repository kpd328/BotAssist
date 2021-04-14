using BotAssist.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace BotAssist.Model.Object {
    public class Bot : INotifyPropertyChanged {
        public string Name { get; set; }
        public string Site { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Favorite { get; set; } = false;
        public string FavoriteIcon => Favorite ? "ic_favorite_gray_18dp" : "ic_favorite_border_grey_18dp";
        public IList<Command> Commands { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private ICommand favbutton;
        public ICommand FavButton => favbutton ??= new Xamarin.Forms.Command(() => {
            Favorite = !Favorite;
            OnPropertyChanged(nameof(Favorite));
            OnPropertyChanged(nameof(FavoriteIcon));
        });

        private ICommand favbutton2;
        public ICommand FavButtonParam => favbutton2 ??= new Xamarin.Forms.Command((context) => {
            Favorite = !Favorite;
            OnPropertyChanged(nameof(Favorite));
            OnPropertyChanged(nameof(FavoriteIcon));
            (context as BotListViewmodel).FilterItems();
        });

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
