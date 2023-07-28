using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator
{
    public class Question
    {
        public string isAvailableFunc { get; set; } = "";

        public List<Response> responses { get; set; } = new List<Response>();
        public string responseCond { get; set; } = "";

        int textIndex { get; set; }

        public Question(int textIndex)
        {
            this.textIndex = textIndex;
        }

        public string GetText(string dir)
        {
            string full = "";
            using (TextReader reader = File.OpenText(dir))
            {
                full = reader.ReadToEnd();
            }
            string[] split = full.Split('[');
            // Each entry starts [x] where x is the index
            return split[textIndex + 1].Substring(2);
        }
    }
}
