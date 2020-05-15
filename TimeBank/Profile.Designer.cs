namespace TimeBank
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.consumedListBox = new System.Windows.Forms.ListBox();
            this.profileButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publishedListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doneListBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consumedListBox
            // 
            this.consumedListBox.FormattingEnabled = true;
            this.consumedListBox.ItemHeight = 16;
            this.consumedListBox.Location = new System.Drawing.Point(24, 80);
            this.consumedListBox.Name = "consumedListBox";
            this.consumedListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.consumedListBox.Size = new System.Drawing.Size(352, 420);
            this.consumedListBox.TabIndex = 12;
            // 
            // profileButton
            // 
            this.profileButton.Enabled = false;
            this.profileButton.Location = new System.Drawing.Point(198, 11);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(75, 33);
            this.profileButton.TabIndex = 11;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(117, 11);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 33);
            this.homeButton.TabIndex = 10;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "I have CONSUMED these activities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "I have PUBLISHED these activities";
            // 
            // publishedListBox
            // 
            this.publishedListBox.FormattingEnabled = true;
            this.publishedListBox.ItemHeight = 16;
            this.publishedListBox.Location = new System.Drawing.Point(397, 80);
            this.publishedListBox.Name = "publishedListBox";
            this.publishedListBox.Size = new System.Drawing.Size(352, 420);
            this.publishedListBox.TabIndex = 15;
            this.publishedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.publishedListBox_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(767, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "I  have DONE these activities";
            // 
            // doneListBox
            // 
            this.doneListBox.FormattingEnabled = true;
            this.doneListBox.ItemHeight = 16;
            this.doneListBox.Location = new System.Drawing.Point(770, 80);
            this.doneListBox.Name = "doneListBox";
            this.doneListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.doneListBox.Size = new System.Drawing.Size(352, 420);
            this.doneListBox.TabIndex = 17;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(987, 506);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(135, 44);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(289, 19);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(114, 17);
            this.hoursLabel.TabIndex = 20;
            this.hoursLabel.Text = "Total Hours: 100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "*Click on an item to remove it.";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(33, 11);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 33);
            this.logOutButton.TabIndex = 23;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 608);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doneListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publishedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consumedListBox);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.homeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox consumedListBox;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox publishedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox doneListBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logOutButton;
    }
}