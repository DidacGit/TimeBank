using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeBank
{
    public partial class AddPersonForm : Form
    {
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Person person = new Person();
            person.userName = nameTextBox.Text;
            person.password = passwordTextBox.Text;
            person.email = emailTextBox.Text;
            person.phone = phoneTextBox.Text;
            person.hours = 5;
            ManageDB.addPerson(person);
            //Person helena = ManageDB.findPerson(2);
            //ManageDB.removePerson(helena);
            //Debug.WriteLine(helena);
        }

    }
}
