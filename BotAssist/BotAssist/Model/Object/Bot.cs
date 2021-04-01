using System;
using System.Collections.Generic;
using System.Text;

namespace BotAssist.Model.Object {
    public class Bot {
        public string Name { get; set; }
        public string Site { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Favorite { get; set; }
        public string FavoriteIcon => Favorite ? "ic_favorite_custom_18dp" : "ic_favorite_gray_18dp";
    }
}
