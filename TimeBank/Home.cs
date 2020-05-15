using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeBank
{
    public partial class Home : Form
    {
        List<Activity> offeredActivities;

        public Home()
        {
            InitializeComponent();
            fillActivitiesListBox();
        }
        private void fillActivitiesListBox()
        {
            hoursLabel.Text = "Total hours: " + ManageDB.myPerson.hours;
            activitiesListBox.Items.Clear();
            offeredActivities = ManageDB.getPublishedActivities();
            foreach (Activity a in offeredActivities)
            {
                String professional = ManageDB.findPerson(a.userProducer).userName;
                String item = "Professional: " + professional + "; Description: " + a.activityName;

                activitiesListBox.Items.Add(item);
            }
        }
        private void addActivityButton_Click(object sender, EventArgs e)
        {
            String description = descriptionTextBox.Text;
            Activity myActivity = new Activity();
            myActivity.activityName = description;
            myActivity.hours = 1;
            myActivity.userProducer = ManageDB.myPerson.userId;
            myActivity.userConsumer = ManageDB.myPerson.userId;
            myActivity.activityDate = DateTime.Now;
            String message;

            if(String.IsNullOrEmpty(description))
            {
                message = "You must write something in the description.";
            }
            else
            {
                ManageDB.addActivity(myActivity);
                message = "The activity has been published. Check your profile to see it.";
            }
            MessageBox.Show(message, "", MessageBoxButtons.OK);

        }

        private void activitiesListBox_MouseClick(object sender, MouseEventArgs e)
        {
            Activity currentActivity = offeredActivities[activitiesListBox.SelectedIndex];
            DialogResult result;
            result = MessageBox.Show(activitiesListBox.SelectedItem.ToString(), 
                "Do you want to contract "+ ManageDB.findPerson(currentActivity.userProducer).userName + "?",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               if(!ManageDB.transferHours(currentActivity))
                {
                    MessageBox.Show("Currently you don't have enough hours, please work a little bit harder...", "You don't have enough hours.", MessageBoxButtons.OK);
                }
            }
            fillActivitiesListBox();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillActivitiesListBox();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.ShowDialog();

            this.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();

            this.Close();
        }
    }
}
