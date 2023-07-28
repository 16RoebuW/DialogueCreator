using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueCreator
{
    public partial class Tester : Form
    {
        // This will act as the DialogueManager

        //Character npc = new Character("Nigel Percy Cooke", "Nigel P. Cooke", "The unforgiving", Application.StartupPath + @"/Text/Nigel_Percy_Cooke.txt");
        Button[] buttons = new Button[4];
        Question[] displayedQs = new Question[4];
        //Character lomse = new Character("lomse", "W. Lomse", "The grafted", Application.StartupPath + @"/Text/lomse.txt");
        public delegate void procedures();
        public delegate bool boolFuncs();
        public delegate int intFuncs();
        Dictionary<string, Delegate> delegDict = new Dictionary<string, Delegate>();

        string playerDialogueDir = Application.StartupPath + @"/Text/Player.txt";
        string saveLocation = Application.StartupPath + "/Saved Conversations/";

        public Tester()
        {
            InitializeComponent();
        }

        private void Tester_Load(object sender, EventArgs e)
        {
            lbxDialogue.Items.Clear();
            buttons[0] = btnOption1;
            buttons[1] = btnOption2;
            buttons[2] = btnOption3;
            buttons[3] = btnOption4;
            foreach (Button b in buttons)
            {
                b.Click += ClickOption;
            }

            boolFuncs getSecretOption = GetSecretOption;
            delegDict.Add("GetSecretOption", getSecretOption);
            intFuncs chooseResponse1 = ChooseResponse1;
            delegDict.Add("ChooseResponse1", chooseResponse1);
            procedures makeBackRed = MakeBackRed;
            delegDict.Add("MakeBackRed", makeBackRed);

            /*npc.initialResponse = new Response(npc, false, 0);
            npc.initialResponse.playerResponses.Add(new Question(0));
            npc.initialResponse.playerResponses.Add(new Question(1));
            npc.initialResponse.playerResponses.Add(new Question(2));
            npc.initialResponse.playerResponses.Add(new Question(3));
            npc.initialResponse.playerResponses[3].isAvailableFunc = "GetSecretOption";
            npc.initialResponse.playerResponses[0].responseCond = "ChooseResponse1";

            Response boring = new Response(npc, true, 1);
            npc.initialResponse.playerResponses[0].responses.Add(boring);
            Response agree = new Response(npc, false, 2);
            agree.next = npc.initialResponse;
            npc.initialResponse.playerResponses[1].responses.Add(agree);
            Response good = new Response(npc, true, 3);
            npc.initialResponse.playerResponses[2].responses.Add(good);
            Response special = new Response(npc, false, 4);
            Response lomseEnter = new Response(lomse, true, 0);
            special.next = lomseEnter;
            npc.initialResponse.playerResponses[0].responses.Add(special);           
            Response secret = new Response(npc, true, 5);
            secret.action = "MakeBackRed";
            npc.initialResponse.playerResponses[3].responses.Add(secret);

            string json = JsonConvert.SerializeObject(npc, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects, ReferenceLoopHandling = ReferenceLoopHandling.Ignore});
            File.WriteAllText(saveLocation + "npc.txt", json);*/

            Character npc = JsonConvert.DeserializeObject<Character>(File.ReadAllText(saveLocation + "npc.txt"), new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects, ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            StartDialogue(npc);
        }

        private void ClickOption(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Button b in buttons)
            {
                if (b == sender as Button)
                {
                    HandleQuestion(displayedQs[i]);
                }
                i++;
            }
        }

        private void HandleQuestion(Question question)
        {
            if (question == null)
            {
                return;
            }
            else
            {
                lbxDialogue.Items.Add($"You: {question.GetText(playerDialogueDir)}");
                if (question.responses.Count == 1)
                {
                    ShowResponse(question.responses[0]);
                }
                else
                {
                    int selectedResponseIndex = (delegDict[question.responseCond] as intFuncs)();
                    ShowResponse(question.responses[selectedResponseIndex]);
                }
            }
        }

        private void StartDialogue(Character character)
        {
            ShowResponse(character.initialResponse);
        }

        private void ShowResponse(Response response)
        {
            lbxDialogue.Items.Add($"{response.speaker.displayName}, \"{response.speaker.title}\": {response.GetText()}");
            if (response.action != "")
            {
                (delegDict[response.action] as procedures)();
            }
            if (response.end == true)
            {
                lbxDialogue.Items.Add("-END OF DIALOGUE-");
                return;
            }
            if (response.playerResponses.Count == 0)
            {
                ShowResponse(response.next);
                return;
            }

            int i = 0;
            foreach (Question q in response.playerResponses)
            {
                if (q.isAvailableFunc == "" || (delegDict[q.isAvailableFunc] as boolFuncs)() == true)
                {
                    buttons[i].Text = q.GetText(playerDialogueDir);
                    displayedQs[i] = q;
                }
                else
                {
                    displayedQs[i] = null;
                    buttons[i].Text = "";
                }
                i++;
            }
        }

        public bool GetSecretOption()
        {
            return true;
        }

        public int ChooseResponse1()
        {
            return 1;
        }

        public void MakeBackRed()
        {
            this.BackColor = Color.Firebrick;
        }
    }
}
