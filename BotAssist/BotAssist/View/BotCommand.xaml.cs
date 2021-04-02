using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotAssist.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BotCommand : ContentPage {
        public Model.Object.Command Item { get; set; }

        public BotCommand(Model.Object.Command command) {
            InitializeComponent();

            Item = command;
            BindingContext = Item;
        }
    }
}