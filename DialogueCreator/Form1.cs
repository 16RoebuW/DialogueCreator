using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueCreator
{
    public partial class Form1 : Form
    {
        /* TO DO: 
            Branching - done!
            Multiple characters - done!
            Display name - done!
            Title - done!
            Picture - will have to be done in godot
            Audio - will have to be done in godot
            Conditional options - done!
            Conditional responses - done!
            Responses can call procedures - done!
            Text stored separately - done!
            Program to aid in creation - not yet implemented
            Characters can speak more than once before the player asks something - done!
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Tester testerForm = new Tester();
            testerForm.Show();
        }
    }
}
