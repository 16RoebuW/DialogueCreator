using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator
{
    public class Character
    {
        public string name;
        public string displayName;
        public string title;
        public string localTexturePath;
        //public Texture2D image;
        public string localTextFilePath;
        public Response initialResponse;

        public Character() { }
        public Character(string name, string displayName, string title, string textFileDir)
        {
            this.name = name;
            this.displayName = displayName;
            this.title = title;
            this.localTextFilePath = textFileDir;
        }
    }
}
