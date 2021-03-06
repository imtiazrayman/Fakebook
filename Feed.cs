﻿using System;
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
    public partial class Feed : Form
    {
        public Feed()
        {
            InitializeComponent();

        }

        private void btn_like_Click(object sender, EventArgs e)

            menuStrip1.ForeColor = Color.White;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)

        {

        }


        private void btn_share_Click(object sender, EventArgs e)

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)

        {

        }


        private void btn_comment_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnGoAmazon_Click(object sender, EventArgs e)
        {
           // https://www.amazon.com/s?k=iphonef&ref=nb_sb_noss_2

            if (txtAddressbar.Text.ToString().Contains("http://www."))
            {
                webBrowser1.Navigate(new Uri(txtAddressbar.Text));
            }
            else if (string.IsNullOrEmpty(txtAddressbar.Text))
            {
                MessageBox.Show("Must put a search query", "Empty Url", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!(txtAddressbar.Text.ToString().Contains("http://www.") && txtAddressbar.Text.ToString().Contains(".com")))
            {
                string searchQuery = txtAddressbar.Text.ToString();
                string appendedSearchQuery = "http://www.amazon.com/s?k=" + searchQuery;
                
                webBrowser1.Navigate(new Uri(appendedSearchQuery));
                webBrowser1.ScriptErrorsSuppressed = true; // this is here because the windows form web browser cant cut the java script times.

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchGoogle_Click(object sender, EventArgs e)
        {
            //https://www.google.com/search?q=xy   https://www.ebay.com/sch/i.html?_from=R40&_trksid=m570.l1313&_nkw=bose&_sacat=0

            if (txtAddressbar.Text.ToString().Contains("http://www."))
            {
                webBrowser1.Navigate(new Uri(txtAddressbar.Text));
            }
            else if (string.IsNullOrEmpty(txtAddressbar.Text))
            {
                MessageBox.Show("Must put a search query", "Empty Url", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!(txtAddressbar.Text.ToString().Contains("http://www.") && txtAddressbar.Text.ToString().Contains(".com")))
            {
                string searchQuery = txtAddressbar.Text.ToString();
                string appendedSearchQuery = "https://www.google.com/search?q=" + searchQuery;

                webBrowser1.Navigate(new Uri(appendedSearchQuery));
                webBrowser1.ScriptErrorsSuppressed = true; // this is here because the windows form web browser cant cut the java script times.

            }
        }

        private void btnSearchEbay_Click(object sender, EventArgs e)
        {
            if (txtAddressbar.Text.ToString().Contains("http://www.")) 
            {
                webBrowser1.Navigate(new Uri(txtAddressbar.Text));
            }
            else if (string.IsNullOrEmpty(txtAddressbar.Text))
            {
                MessageBox.Show("Must put a search query", "Empty Url", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!(txtAddressbar.Text.ToString().Contains("http://www.") && txtAddressbar.Text.ToString().Contains(".com")))
            {
                string searchQuery = txtAddressbar.Text.ToString();
                string appendedSearchQuery = " https://www.ebay.com/sch/i.html?_from=R40&_trksid=m570.l1313&_nkw=" + searchQuery; //&_sacat=0

                webBrowser1.Navigate(new Uri(appendedSearchQuery));
                webBrowser1.ScriptErrorsSuppressed = true; // this is here because the windows form web browser cant cut the java script times.

            }
        }

    }
}
