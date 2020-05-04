using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakebook
{
    public partial class MessengerForm : Form
    {
        public MessengerForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] response = new string[12];
            response[0] = "Hello!";
            response[1] = "I'm fantastic, thanks for asking!";
            response[2] = "Nothing much, just responding to many Fakebook users";
            response[3] = "It's nice to meet you too!";
            response[4] = "I'm a bot that responds to users";
            response[5] = "Why yes I agree, it's a wonderful day today";
            response[6] = "Why thank you! I like yours too! :)";
            response[7] = "I'm from this program made by users";
            response[8] = "See ya";
            response[9] = "Was nice talking to you too";
            response[10] = "I'm sorry, I do not understand what you're saying";

            DateTime now = DateTime.Now;

            if (txt_userInput.Text == "Hello!" || txt_userInput.Text == "Hello" || txt_userInput.Text == "hello" || txt_userInput.Text == "hi")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[0] +  "\t" + now.ToString() + "\n");
                 
            }
            if (txt_userInput.Text == "How are you?" || txt_userInput.Text == "how is everything")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[1] + "\t" + now.ToString() + "\n");
            }
            if (txt_userInput.Text == "What's new?" || txt_userInput.Text == "whats up")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[2] + "\t" + now.ToString() + "\n");
            }
            if (txt_userInput.Text == "It's nice to meet you!")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[3] + "\t" + now.ToString() + "\n");
            }
            if (txt_userInput.Text == "What do you do for a living?")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[4] + "\t" + now.ToString() + "\n");
            }
            if (txt_userInput.Text == "Man, what a good day isn't it?")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[5] + "\t" + now.ToString() + "\n");
            }
            if (txt_userInput.Text == "I like your personality")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[6] + "\t" + now.ToString() + "\n");
            }
            if (txt_userInput.Text == "Where are you from?")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[7] + "\t" + now.ToString() + "\n");
            }
            if (txt_userInput.Text == "See you later" || txt_userInput.Text == "bye")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[8] + "\t" + now.ToString() + "\n");
            }
            if (txt_userInput.Text == "Was nice talking to you" || txt_userInput.Text == "see u later")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[9] + "\t" + now.ToString() + "\n");
            }
            if (txt_userInput.Text == "")
            {
                rtxt_response.AppendText(txt_userInput.Text + "\n\t\t\t" + response[10] + "\t" + now.ToString() + "\n");
            }
        }
    }
}
