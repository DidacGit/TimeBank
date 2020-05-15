namespace TimeBank
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.HomeButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.activitiesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddActivityGBox = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.AddActivityGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Enabled = false;
            this.HomeButton.Location = new System.Drawing.Point(125, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 33);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(206, 12);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(75, 33);
            this.profileButton.TabIndex = 1;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 48);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(746, 131);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // addActivityButton
            // 
            this.addActivityButton.Location = new System.Drawing.Point(296, 198);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(142, 33);
            this.addActivityButton.TabIndex = 3;
            this.addActivityButton.Text = "Add Activity";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // activitiesListBox
            // 
            this.activitiesListBox.FormattingEnabled = true;
            this.activitiesListBox.ItemHeight = 16;
            this.activitiesListBox.Location = new System.Drawing.Point(24, 52);
            this.activitiesListBox.Name = "activitiesListBox";
            this.activitiesListBox.Size = new System.Drawing.Size(765, 228);
            this.activitiesListBox.TabIndex = 4;
            this.activitiesListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.activitiesListBox_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // AddActivityGBox
            // 
            this.AddActivityGBox.Controls.Add(this.descriptionTextBox);
            this.AddActivityGBox.Controls.Add(this.label2);
            this.AddActivityGBox.Controls.Add(this.addActivityButton);
            this.AddActivityGBox.Location = new System.Drawing.Point(24, 331);
            this.AddActivityGBox.Name = "AddActivityGBox";
            this.AddActivityGBox.Size = new System.Drawing.Size(765, 263);
            this.AddActivityGBox.TabIndex = 8;
            this.AddActivityGBox.TabStop = false;
            this.AddActivityGBox.Text = "Add Activity";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(647, 286);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(142, 33);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(287, 20);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(114, 17);
            this.hoursLabel.TabIndex = 21;
            this.hoursLabel.Text = "Total Hours: 100";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(44, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 33);
            this.logOutButton.TabIndex = 22;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 608);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.AddActivityGBox);
            this.Controls.Add(this.activitiesListBox);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.HomeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.AddActivityGBox.ResumeLayout(false);
            this.AddActivityGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addActivityButton;
        private System.Windows.Forms.ListBox activitiesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox AddActivityGBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Button logOutButton;
    }
}