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
        public delegate bool qIsAvailable();
        public qIsAvailable isAvailable;

        public List<Response> responses = new List<Response>();
        public delegate int ResponseDelegate();
        public ResponseDelegate responseCond = null;

        int textIndex;

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
