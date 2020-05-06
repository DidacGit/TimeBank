using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeBank
{
    public partial class AddPersonForm : Form
    {
        TimeBankEntities entities = new TimeBankEntities();
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
            entities.People.Add(person);
            entities.SaveChanges();
        }

    }
}
