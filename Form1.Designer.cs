namespace Fakebook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComparison = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtGoogle = new System.Windows.Forms.TextBox();
            this.txtEbay = new System.Windows.Forms.TextBox();
            this.txtAmazon = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGoAmazon = new System.Windows.Forms.Button();
            this.btnSearchEbay = new System.Windows.Forms.Button();
            this.btnSearchGoogle = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtAddressbar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 63);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(582, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "fakebook";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Location = new System.Drawing.Point(2, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(863, 39);
            this.panel4.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(78, 27);
            this.toolStripMenuItem5.Text = "Home";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(124, 27);
            this.toolStripMenuItem6.Text = "Messenger";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click_1);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(67, 27);
            this.toolStripMenuItem7.Text = "Feed";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(182, 27);
            this.toolStripMenuItem8.Text = "Friends(Profiles)";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnSaveLog);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnComparison);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.txtGoogle);
            this.panel1.Controls.Add(this.txtEbay);
            this.panel1.Controls.Add(this.txtAmazon);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.txtAddressbar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 538);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Amazon Prices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ebay Prices";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Google Prices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter in an Item to search for :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnComparison
            // 
            this.btnComparison.BackColor = System.Drawing.Color.Turquoise;
            this.btnComparison.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComparison.FlatAppearance.BorderSize = 4;
            this.btnComparison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComparison.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComparison.Location = new System.Drawing.Point(448, 485);
            this.btnComparison.Name = "btnComparison";
            this.btnComparison.Size = new System.Drawing.Size(173, 34);
            this.btnComparison.TabIndex = 13;
            this.btnComparison.Text = "Compare";
            this.btnComparison.UseVisualStyleBackColor = false;
            this.btnComparison.Click += new System.EventHandler(this.btnComparison_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(25, 520);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(806, 372);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // txtGoogle
            // 
            this.txtGoogle.Location = new System.Drawing.Point(342, 492);
            this.txtGoogle.Name = "txtGoogle";
            this.txtGoogle.Size = new System.Drawing.Size(100, 22);
            this.txtGoogle.TabIndex = 10;
            // 
            // txtEbay
            // 
            this.txtEbay.Location = new System.Drawing.Point(182, 492);
            this.txtEbay.Name = "txtEbay";
            this.txtEbay.Size = new System.Drawing.Size(100, 22);
            this.txtEbay.TabIndex = 9;
            // 
            // txtAmazon
            // 
            this.txtAmazon.Location = new System.Drawing.Point(25, 492);
            this.txtAmazon.Name = "txtAmazon";
            this.txtAmazon.Size = new System.Drawing.Size(100, 22);
            this.txtAmazon.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel3.Controls.Add(this.btnGoAmazon);
            this.panel3.Controls.Add(this.btnSearchEbay);
            this.panel3.Controls.Add(this.btnSearchGoogle);
            this.panel3.Location = new System.Drawing.Point(11, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 50);
            this.panel3.TabIndex = 7;
            // 
            // btnGoAmazon
            // 
            this.btnGoAmazon.BackColor = System.Drawing.Color.Transparent;
            this.btnGoAmazon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGoAmazon.FlatAppearance.BorderSize = 4;
            this.btnGoAmazon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoAmazon.ForeColor = System.Drawing.Color.White;
            this.btnGoAmazon.Location = new System.Drawing.Point(29, 7);
            this.btnGoAmazon.Name = "btnGoAmazon";
            this.btnGoAmazon.Size = new System.Drawing.Size(167, 34);
            this.btnGoAmazon.TabIndex = 3;
            this.btnGoAmazon.Text = "Search Amazon";
            this.btnGoAmazon.UseVisualStyleBackColor = false;
            this.btnGoAmazon.Click += new System.EventHandler(this.btnGoAmazon_Click);
            // 
            // btnSearchEbay
            // 
            this.btnSearchEbay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchEbay.FlatAppearance.BorderSize = 4;
            this.btnSearchEbay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEbay.ForeColor = System.Drawing.Color.White;
            this.btnSearchEbay.Location = new System.Drawing.Point(331, 7);
            this.btnSearchEbay.Name = "btnSearchEbay";
            this.btnSearchEbay.Size = new System.Drawing.Size(164, 34);
            this.btnSearchEbay.TabIndex = 4;
            this.btnSearchEbay.Text = "Search Ebay";
            this.btnSearchEbay.UseVisualStyleBackColor = true;
            this.btnSearchEbay.Click += new System.EventHandler(this.btnSearchEbay_Click);
            // 
            // btnSearchGoogle
            // 
            this.btnSearchGoogle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchGoogle.FlatAppearance.BorderSize = 4;
            this.btnSearchGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchGoogle.ForeColor = System.Drawing.Color.White;
            this.btnSearchGoogle.Location = new System.Drawing.Point(613, 7);
            this.btnSearchGoogle.Name = "btnSearchGoogle";
            this.btnSearchGoogle.Size = new System.Drawing.Size(178, 34);
            this.btnSearchGoogle.TabIndex = 1;
            this.btnSearchGoogle.Text = "Search Google";
            this.btnSearchGoogle.UseVisualStyleBackColor = true;
            this.btnSearchGoogle.Click += new System.EventHandler(this.btnSearchGoogle_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(11, 125);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(821, 324);
            this.webBrowser1.TabIndex = 6;
            // 
            // txtAddressbar
            // 
            this.txtAddressbar.Location = new System.Drawing.Point(278, 31);
            this.txtAddressbar.Name = "txtAddressbar";
            this.txtAddressbar.Size = new System.Drawing.Size(293, 22);
            this.txtAddressbar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter in the best prices of each Site";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Retrieve Previous Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(637, 486);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(181, 32);
            this.btnSaveLog.TabIndex = 19;
            this.btnSaveLog.Text = "Save Log";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchGoogle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddressbar;
        private System.Windows.Forms.Button btnGoAmazon;
        private System.Windows.Forms.Button btnSearchEbay;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGoogle;
        private System.Windows.Forms.TextBox txtEbay;
        private System.Windows.Forms.TextBox txtAmazon;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnComparison;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveLog;
    }
}

