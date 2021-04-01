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
    public partial class BotList : ContentView {
        public ObservableCollection<Bot> Items { get; set; }

        public BotList() {
            InitializeComponent();

            Items = new ObservableCollection<Bot>
            {
                new Bot {
                    Name = "Avrae",
                    Site = "avrae.io",
                    Description = "The most comprehensive DnD Discord bot.",
                    ImageUrl = "https://images.discordapp.net/avatars/261302296103747584/b4926b52f7f1c966e01e25f0b33253f1.png?size=128",
                    Favorite = true
                },
                new Bot {
                    Name = "MEE6",
                    Site = "mee6.xyz",
                    Description = "The most complete & easy-to-use Discord bot! Advanced auto-moderation, leveling, Twitch and Youtube alerts & much more!",
                    ImageUrl = "https://images.discordapp.net/avatars/159985870458322944/b50adff099924dd5e6b72d13f77eb9d7.png?size=128",
                    Favorite = true
                },
                new Bot {
                    Name = "Rythm",
                    Site = "rythm.fm",
                    Description = "Rythm makes it possible to listen to your favorite music with all your friends. Add it to Discord today and start listening!",
                    ImageUrl = "https://images.discordapp.net/avatars/235088799074484224/9b29bfc497a70b6cc85bb2087936f8fd.png?size=128",
                    Favorite = false
                },
                new Bot {
                    Name = "EPIC RPG",
                    Site = "",
                    Description = "A simple RPG with dungeons, armors, swords, PvP, leaderboards, gambling and memes",
                    ImageUrl = "https://images.discordapp.net/avatars/555955826880413696/aca9824ea3aaac3f2d9e318394c67b39.png?size=128",
                    Favorite = true
                },
            };

            MyListView.ItemsSource = Items;
        }
    }
}
