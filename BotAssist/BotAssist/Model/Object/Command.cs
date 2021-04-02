using System;
using System.Collections.Generic;
using System.Text;

namespace BotAssist.Model.Object {
    public class Command {
        public string Name { get; set; }
        public string ShortCommand { get; set; }
        public string Description { get; set; }
        public string Bot { get; set; }
        public string CommandTemplate { get; set; }
        public IList<Input> Fields { get; set; }
    }
}
