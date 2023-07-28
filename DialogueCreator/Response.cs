using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator
{
    public class Response
    {
        public Character speaker;
        public bool end;
        //public Sound audio;      
        public List<Question> playerResponses = new List<Question>();
        // Set this if there is the posibility of the player having no options and the dialogue does not end
        public Response next = null;
        public string action = "";

        int textIndex;

        public Response() { }
        public Response(Character speaker, bool end, int textIndex)
        {
            this.speaker = speaker;
            this.end = end;
            this.textIndex = textIndex;
        }

        public string GetText()
        {
            string full = "";
            using (TextReader reader = File.OpenText(speaker.textFileDir))
            {
                full = reader.ReadToEnd();
            }
            string[] split = full.Split('[');
            // Each entry starts [x] where x is the index
            return split[textIndex + 1].Substring(2);
        }
    }
}
