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
            Cursor.Current = Cursors.WaitCursor;
            /*
             * Test Code
             * 
             * using (FakeBookV2DataSetTableAdapters.UserProfilesTableAdapter profilesTableAdapter = new FakeBookV2DataSetTableAdapters.UserProfilesTableAdapter())
            {
                FakeBookV2DataSet db = new FakeBookV2DataSet();              
                profilesTableAdapter.Fill(db.UserProfiles);
                List<> list = db.UserProfiles.ToList();
                foreach(use)

            }
            */


            {
                /*Test Code
                 * 
                 * public int getCount() {
                    if (mList != null) {
                        return
                             Math.min(mList.size()), YOU_MAX_VALUE);
                                       } else
                                              {
                                          return 0;
                                                         }
                                                }
                                                */
                using (FakeBookV3DataSetTableAdapters.UserProfilesTableAdapter profilesTableAdapter = new FakeBookV3DataSetTableAdapters.UserProfilesTableAdapter())
                {
                    FakeBookV3DataSet fakebookDB = new FakeBookV3DataSet();
                    profilesTableAdapter.Fill(fakebookDB.UserProfiles);






                    foreach (DataRow row in fakebookDB.UserProfiles.Rows)
                    {


                        /* Test Code
                         * foreach (DataRow row in dt.Rows)
                {
                    //Add Item to ListView.
                    ListViewItem item = new ListViewItem(row["Name"].ToString());
                    item.SubItems.Add(row["CustomerId"].ToString());
                    TestView.Items.Add(item);
                } */


                        ListViewItem item = new ListViewItem(row["First Name"].ToString());
                        item.SubItems.Add(row["Last Name"].ToString());
                        item.SubItems.Add(row["Company"].ToString());
                        //Test Code
                        //
                        //TestView.Items.Add(row["First Name"].ToString);
                        //TestView.Items(TestView.Items.Count-1).SubItems.Add(row["Last Name"].ToString());
                        //TestView.Items(TestView.Items.Count - 1).SubItems.Add(row["Last Name"].ToString());
                        //TestView.Items(TestView.Items.Count - 1).SubItems.Add(row["Last Name"].ToString());
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
        }

       



        private void LvFriends_SelectedIndexChanged(object sender, EventArgs e)
         {

             if (lvFriends.SelectedItems.Count > 0)
             {
                 string message = "First Name: " + lvFriends.SelectedItems[0].Text + Environment.NewLine;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvFriends_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvFriends.SelectedItems.Count > 0)
            {
                string message = "First Name: " + lvFriends.SelectedItems[0].Text + Environment.NewLine;
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

        /*private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //Code to open Friends(Profiles) Form - AJ
            Fakebook.Form1 Friends = new Fakebook.Form1();
            Friends.ShowDialog(this);
        }

 

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //Code to open Feed Form - AJ
           // Fakebook.Feed Feed  = new Fakebook.Feed();
          //  Feed.ShowDialog(this);
        }*/




    }
}
