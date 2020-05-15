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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string mail = mailTextBox.Text;
            string password = passwordTextBox.Text;
            string message = "";
            bool showMessage = true;

            try
            {
                switch( ManageDB.checkLogin(mail, password))
                {
                    case loginOptions.CORRECT:
                        showMessage = false;
                        break;
                    case loginOptions.PASSWORD_ERROR:
                        message = "WRONG PASSWORD";
                        break;
                    case loginOptions.EMAIL_ERROR:
                        message = "WRONG EMAIL";
                        break;
                    default:
                        message = "SOMETHING IS WRONG";
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception: ", exception.Message);
            }
            if(showMessage)
                MessageBox.Show(message);
            else
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
                
                this.Close();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
