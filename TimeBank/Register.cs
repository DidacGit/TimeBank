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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void addPersonButtonClick(object sender, EventArgs e)
        {
            Person person = new Person();
            person.userName = nameTextBox.Text;
            person.password = passwordTextBox.Text;
            person.email = emailTextBox.Text;
            person.phone = phoneTextBox.Text;
            person.hours = 5;
            ManageDB.addPerson(person);
        }

        private void transactionButtonClick(object sender, EventArgs e)
        {
            // Helena le pasa dos horas a Marcos (por ejemplo)
            Person helena = ManageDB.findPerson(2);
            Person marcos = ManageDB.findPerson(1);
            ManageDB.transferHours(helena, marcos, 2);
        }

        private void deletePersonButtonClick(object sender, EventArgs e)
        {
            // Eliminamos a Marta (por ejemplo)
            Person marta = ManageDB.findPerson(3);
            ManageDB.removePerson(marta);
        }
    }
}
