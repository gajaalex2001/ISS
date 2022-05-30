using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectISS.Service;
using ProiectISS.Model;

namespace ProiectISS
{
    public partial class LoginWindow : Form
    {
        private Services srv;

        public LoginWindow(Services srv)
        {
            this.srv = srv;
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = userBox.Text;
            String password = passBox.Text;

            String errorText = "";

            if (username.Length < 1)
                errorText += "Username introdus incorect.";
            if (password.Length < 1)
                if (errorText.Length > 0)
                    errorText += "\nParola introdusa incorect.";
                else
                    errorText += "Parola introdusa incorect.";

            if (errorText.Length > 0)
                MessageBox.Show(errorText, "ERROR");
            else
            {
                try
                {
                    Employee em = srv.getAccount(username, password);

                    if (em == null)
                        MessageBox.Show("Cont inexistent.", "ERROR");
                    else
                    {
                        if (em.type == EmployeeType.Admin)
                        {
                            ManageAccountsWindow admin = new ManageAccountsWindow(srv, em);
                            admin.Show();
                        }
                        else if (em.type == EmployeeType.Programmer)
                        {
                            (new ProgrammerWindow(srv, em)).Show();
                        }
                        else
                        {
                            TesterWindow tester = new TesterWindow(srv, em);
                            tester.Show();
                        }

                        userBox.Text = "";
                        passBox.Text = "";
                    }
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginWindow_VisibleChanged(object sender, EventArgs e)
        {
            userBox.Text = "";
            passBox.Text = "";
        }
    }
}
