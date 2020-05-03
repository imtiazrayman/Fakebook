using Fakebook;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            menuStrip1.ForeColor = Color.White;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {

            //changes mouse curser style
            Cursor.Current = Cursors.WaitCursor;



            using (FakeBookV3DataSetTableAdapters.UserProfilesTableAdapter profilesTableAdapter = new FakeBookV3DataSetTableAdapters.UserProfilesTableAdapter())
            {

                // Connects database to project and then Fill() to TableAdapter
                FakeBookV3DataSet fakebookDB = new FakeBookV3DataSet();
                profilesTableAdapter.Fill(fakebookDB.UserProfiles);





                // appends datarows from Table Adapter into List view 
                foreach (DataRow row in fakebookDB.UserProfiles.Rows)
                {


                    // adds Labeled Rows/ Columns to list 

                    ListViewItem item = new ListViewItem(row["First Name"].ToString());
                    item.SubItems.Add(row["Last Name"].ToString());
                    item.SubItems.Add(row["Company"].ToString());
                    item.SubItems.Add(row["Address"].ToString());
                    item.SubItems.Add(row["State/District"].ToString());
                    item.SubItems.Add(row["County/Province"].ToString());
                    item.SubItems.Add(row["Country"].ToString());
                    item.SubItems.Add(row["Zip/Postal"].ToString());
                    item.SubItems.Add(row["Phone1"].ToString());
                    item.SubItems.Add(row["Email"].ToString());
                    item.SubItems.Add(row["Website"].ToString());
                    lvFriends.Items.Add(item);
                }


                lvFriends.View = View.List;


            }



        }





        private void lvFriends_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            if (lvFriends.SelectedItems.Count > 0) //indictates if items are selected

            {
                //SubItems indicates for rows from listview; lvFriends.SelectedItems makes each row selectable 
                string message = "First Name: " + lvFriends.SelectedItems[0].Text + Environment.NewLine; // adds NewLine to current Environment; in this case messagebox
                message += "Last Name: " + lvFriends.SelectedItems[0].SubItems[1].Text + Environment.NewLine;
                message += "Company: " + lvFriends.SelectedItems[0].SubItems[2].Text + Environment.NewLine;
                message += "Address: " + lvFriends.SelectedItems[0].SubItems[3].Text + Environment.NewLine;
                message += "State/District: " + lvFriends.SelectedItems[0].SubItems[4].Text + Environment.NewLine;
                message += "County/Province: " + lvFriends.SelectedItems[0].SubItems[5].Text + Environment.NewLine;
                message += "Country: " + lvFriends.SelectedItems[0].SubItems[6].Text + Environment.NewLine;
                message += "Zip/Postal: " + lvFriends.SelectedItems[0].SubItems[7].Text + Environment.NewLine;
                message += "Phone1: " + lvFriends.SelectedItems[0].SubItems[8].Text + Environment.NewLine;
                message += "Email: " + lvFriends.SelectedItems[0].SubItems[9].Text + Environment.NewLine;
                message += "Website: " + lvFriends.SelectedItems[0].SubItems[10].Text + Environment.NewLine;
                MessageBox.Show(message);

                Cursor.Current = Cursors.Default;


            }
        }
    

        private void Panel1_Paint(object sender, PaintEventArgs e) { 

               // message += "Website: " + lvFriends.SelectedItems[0].SubItems[10].Text + Environment.NewLine; 
               // MessageBox.Show(message, "Friends Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                //adjust mouse curser style
              // Cursor.Current = Cursors.Default; 
                

            } 
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)

        {
            Form1 homemarketplace = new Form1();
            homemarketplace.ShowDialog(this);
        }

                  
 
private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MessengerForm fr = new MessengerForm();
            fr.ShowDialog();
        }


        private void ToolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            //Code to open Friends(Profiles) Form - AJ
           
            Form2 Friends = new Form2();
            Friends.Show(); // child to showdialog()
        }


        private void ToolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            feedPage feed = new feedPage();
            feed.Show();
        }

    }

