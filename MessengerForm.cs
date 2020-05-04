using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = Microsoft.VisualBasic.Interaction.InputBox("Please enter filename :", "File Name", "", 60, 90);
            label1.Text = label1.Text + fileName;

            if (fileName.Equals(""))
            {

            }
            StreamReader myFile;

            try
            {
                myFile = File.OpenText(fileName);
                string line = "";
                do
                {
                    line = myFile.ReadLine();
                    if (line != null)
                    {
                        rtxt_response.AppendText(Environment.NewLine + line);
                    }
                } while (line != null);
            }
            catch (IOException)
            {
                MessageBox.Show("File Not Found", "File Location Error",
               MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSaveConvo_Click(object sender, EventArgs e)
        {
            StreamWriter myFile;
            string fileName = Microsoft.VisualBasic.Interaction.InputBox("Please Name Your File:", "Enter File Name", "", 60, 90);
            myFile = File.CreateText(fileName);
            try
            {
                for (int i = 0; i < rtxt_response.Lines.Length; i++)
                {
                    myFile.WriteLine(rtxt_response.Lines[i]);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error Writing to File", "File Write Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            myFile.Close();
            MessageBox.Show("File Creation " + fileName + " was successful!", "File Creation Success", MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form1 marketplace = new Form1();
            marketplace.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            feedPage feed = new feedPage();
            feed.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form2 profiles = new Form2();
            profiles.Show();
        }
    }
}
