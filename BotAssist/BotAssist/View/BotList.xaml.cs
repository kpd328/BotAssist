using BotAssist.Model.Object;
using System;
using System.Collections.Generic;
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

            Items = new ObservableCollection<Bot>(new HashSet<Bot> {
                new Bot {
                    Name = "Avrae",
                    Site = "avrae.io",
                    Description = "The most comprehensive DnD Discord bot.",
                    ImageUrl = "https://images.discordapp.net/avatars/261302296103747584/b4926b52f7f1c966e01e25f0b33253f1.png?size=128",
                    Favorite = true,
                    Commands = new List<Model.Object.Command> {
                        new Model.Object.Command {
                            Name = "Set Character with D&D Beyond",
                            ShortCommand = "!beyond",
                            Description = "To add a character from D&D Beyond, use the following command",
                            CommandTemplate = "!beyond {0}",
                            Bot = "Avrae",
                            Fields = new List<Input> {
                                new Input {
                                    Entry = new Entry {
                                        Placeholder = "https://ddb.ac/characters/..."
                                    }
                                }
                            }
                        },
                        new Model.Object.Command {
                            Name = "Set Character with Dicecloud",
                            ShortCommand = "!dicecloud",
                            Description = "To add a character from Dicecloud, use the following command",
                            CommandTemplate = "!dicecloud {0}",
                            Bot = "Avrae",
                            Fields = new List<Input> {
                                new Input {
                                    Entry = new Entry {
                                        Placeholder = "https://dicecloud.com/character/..."
                                    }
                                }
                            }
                        },
                        new Model.Object.Command {
                            Name = "Set Character with Google Sheets",
                            ShortCommand = "!gsheet",
                            Description = "To add a character from GSheet, use the following command",
                            CommandTemplate = "!gsheet {0}",
                            Bot = "Avrae",
                            Fields = new List<Input> {
                                new Input {
                                    Entry = new Entry {
                                        Placeholder = "https://docs.google.com/spreadsheets/d/..."
                                    }
                                }
                            }
                        },
                        new Model.Object.Command {
                            Name = "Make Check",
                            ShortCommand = "!check",
                            Description = "You’re ready to roll now! You can use the !check command to roll skill checks",
                            CommandTemplate = "!check {0} {1}",
                            Bot = "Avrae",
                            Fields = new List<Input> {
                                new Input {
                                    Entry = new Picker {
                                        ItemsSource = new List<string> {
                                            "Strength",
                                            "Dexterity",
                                            "Constitution",
                                            "Intelligence",
                                            "Wisdom",
                                            "Charisma",
                                            "Acrobatice",
                                            "Animal Handling",
                                            "Arcana",
                                            "Athletics",
                                            "Deception",
                                            "History",
                                            "Insight",
                                            "Intimidation",
                                            "Investigation",
                                            "Medicine",
                                            "Nature",
                                            "Perception",
                                            "Performance",
                                            "Persuasion",
                                            "Religion",
                                            "Sleight of Hand",
                                            "Stealth",
                                            "Survival",
                                            "Initiative"
                                        }
                                    }
                                },
                                new Input {
                                    Entry = new Picker {
                                        ItemsSource = new List<string> {
                                            "",
                                            "adv",
                                            "dis"
                                        }
                                    }
                                }
                            }
                        },
                    }
                },
                new Bot {
                    Name = "MEE6",
                    Site = "mee6.xyz",
                    Description = "The most complete & easy-to-use Discord bot! Advanced auto-moderation, leveling, Twitch and Youtube alerts & much more!",
                    ImageUrl = "https://images.discordapp.net/avatars/159985870458322944/b50adff099924dd5e6b72d13f77eb9d7.png?size=128",
                    Favorite = true,
                    Commands = new List<Model.Object.Command> {

                    }
                },
                new Bot {
                    Name = "Rythm",
                    Site = "rythm.fm",
                    Description = "Rythm makes it possible to listen to your favorite music with all your friends. Add it to Discord today and start listening!",
                    ImageUrl = "https://images.discordapp.net/avatars/235088799074484224/9b29bfc497a70b6cc85bb2087936f8fd.png?size=128",
                    Favorite = false,
                    Commands = new List<Model.Object.Command> {

                    }
                },
                new Bot {
                    Name = "EPIC RPG",
                    Site = "",
                    Description = "A simple RPG with dungeons, armors, swords, PvP, leaderboards, gambling and memes",
                    ImageUrl = "https://images.discordapp.net/avatars/555955826880413696/aca9824ea3aaac3f2d9e318394c67b39.png?size=128",
                    Favorite = true,
                    Commands = new List<Model.Object.Command> {

                    }
                },
            });
            Items[0].Commands[0].Fields[0].Entry.SetBinding(Entry.TextProperty, new Binding("Output", source: Items[0].Commands[0].Fields[0].Entry));
            Items[0].Commands[1].Fields[0].Entry.SetBinding(Entry.TextProperty, new Binding("Output", source: Items[0].Commands[1].Fields[0].Entry));
            Items[0].Commands[2].Fields[0].Entry.SetBinding(Entry.TextProperty, new Binding("Output", source: Items[0].Commands[2].Fields[0].Entry));

            MyListView.ItemsSource = Items;
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e) => Navigation.PushAsync(new BotCommandList(e.Item as Bot));
    }
}
