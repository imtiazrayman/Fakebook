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
    public partial class feedPage : Form
    {
        public feedPage()
        {
            InitializeComponent();
            webBrowser1.Navigate(new Uri("https://www.cnn.com/"));
            webBrowser1.ScriptErrorsSuppressed = true; // this is here because the windows form web browser cant cut the java script times.
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            feedPage profilepage = new feedPage();
            profilepage.Show();
        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
  
        }
    }
}
