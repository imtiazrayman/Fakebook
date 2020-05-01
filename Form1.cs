﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fakebook
{
    public partial class Form1: Form
    {
        public double amazonprice, ebayprice, googleprice, averageprice; 

        public Form1()
        {
            InitializeComponent();
            menuStrip1.ForeColor = Color.White;
            richTextBox1.Text = "Item\tAmazon\tEbay\tGoogle\tTime";
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

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MessengerForm fr = new MessengerForm();
            fr.ShowDialog();
            //  fr.ShowDialog(); // this keeps the child in forcus
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            feedPage feed = new feedPage();
            feed.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form2 profilepage = new Form2();
            profilepage.Show();
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            MessengerForm fr = new MessengerForm();
            fr.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnComparison_Click(object sender, EventArgs e)
        {

            priceChecker();
            DateTime now = DateTime.Now;
            richTextBox1.AppendText("\n"+ txtAddressbar.Text + "\t" + amazonprice.ToString() +"\t" + ebayprice.ToString() + "\t" + googleprice.ToString() + "\t" + now.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void priceChecker()
        {
            if (txtAmazon.Text.ToString() == "")
            {
                amazonprice = 0.0;
            }
            else
            {
                amazonprice = Convert.ToDouble(txtAmazon.Text);
            }

            if (txtEbay.Text.ToString() == "")
            {
                ebayprice = 0.0;
            }
            else
            {
                ebayprice = Convert.ToDouble(txtEbay.Text);
            }

            if (txtGoogle.Text.ToString() == "")
            {
                googleprice = 0.0;
            }
            else
            {
                googleprice = Convert.ToDouble(txtAmazon.Text);
            }
            if(txtAddressbar.Text == "")
            {

            }
        }
    }
}
