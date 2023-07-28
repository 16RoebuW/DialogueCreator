using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator
{
    public class Character
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public string title { get; set; }
        //public Texture2D image;
        public string textFileDir { get; set; }
        public Response initialResponse { get; set; }

        public Character(string name, string displayName, string title, string textFileDir)
        {
            this.name = name;
            this.displayName = displayName;
            this.title = title;
            this.textFileDir = textFileDir;
        }
    }
}
