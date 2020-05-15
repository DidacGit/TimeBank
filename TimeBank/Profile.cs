using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeBank
{
    public partial class Profile : Form
    {
        List<Activity> consumedActivities;
        List<Activity> publishedActivities;
        List<Activity> doneActivities;
        public Profile()
        {
            InitializeComponent();
            getAllLists();
        }

        private void getAllLists()
        {
            hoursLabel.Text = "Total hours: " + ManageDB.myPerson.hours;
            consumedActivities = ManageDB.getMyConsumedActivities();
            publishedActivities = ManageDB.getMyPublishedActivities();
            doneActivities = ManageDB.getMyDoneActivities();
            fillListBoxWithActivities(consumedListBox, consumedActivities);
            fillListBoxWithActivities(publishedListBox, publishedActivities);
            fillListBoxWithActivities(doneListBox, doneActivities);
        }
        private void fillListBoxWithActivities(ListBox listBox, List<Activity> activityList)
        {
            listBox.Items.Clear();
            foreach (Activity a in activityList)
            {
                Person producer = ManageDB.findPerson(a.userProducer);
                Person consumer = ManageDB.findPerson(a.userConsumer);

                String item = "";
                if (producer.userId != ManageDB.myPerson.userId)
                    item = item + "Producer: " + producer.userName;
                if (consumer.userId != ManageDB.myPerson.userId)
                    item = item + " Consumer: " + consumer.userName;

                item = item + " Description: " + a.activityName;

                listBox.Items.Add(item);
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();

            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            getAllLists();
        }

        private void publishedListBox_MouseClick(object sender, MouseEventArgs e)
        {
            Activity currentActivity = publishedActivities[publishedListBox.SelectedIndex];
            DialogResult result;
            result = MessageBox.Show(publishedListBox.SelectedItem.ToString(),
                "Do you want to delete " + ManageDB.findPerson(currentActivity.userProducer).userName + "?",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                ManageDB.removeActivity(currentActivity);

            getAllLists();
        }
        private void goToLogin()
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();

            this.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            goToLogin();
        }
    }
}
