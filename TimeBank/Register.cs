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
            if (String.IsNullOrEmpty(nameTextBox.Text) ||
                    String.IsNullOrEmpty(passwordTextBox.Text) ||
                    String.IsNullOrEmpty(emailTextBox.Text) ||
                    String.IsNullOrEmpty(phoneTextBox.Text))
                MessageBox.Show("All the parameters must be filled");
            else
            {
                if (ManageDB.checkIfMailExist(emailTextBox.Text))
                {
                    MessageBox.Show("The mail is already registered.");
                }
                else
                {
                    Person person = new Person();
                    person.userName = nameTextBox.Text;
                    person.password = passwordTextBox.Text;
                    person.email = emailTextBox.Text;
                    person.phone = phoneTextBox.Text;
                    person.hours = 5;
                    ManageDB.addPerson(person);

                    this.Close();
                }
            }
        }
    }
}
