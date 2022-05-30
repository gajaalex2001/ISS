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
using ProiectISS.Repository;

namespace ProiectISS
{
    public partial class ManageAccountsWindow : Form
    {
        Services srv;
        Employee em;

        public ManageAccountsWindow(Services srv, Employee em)
        {
            this.srv = srv;
            this.em = em;
            InitializeComponent();
            LoadForm();
        }

        private void LoadList()
        {
            var bindingList = new BindingList<Employee>(srv.getAccounts());
            var source = new BindingSource(bindingList, null);
            dgvAccounts.DataSource = source;
            dgvDelete.DataSource = source;
        }

        private void LoadForm()
        {
            TypeLabel.Text = em.type.ToString();
            LoadList();
        }

        private void ManageAccountsWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addPanel.Visible == true) addPanel.Visible = false;
            else addPanel.Visible = true;
            updatePanel.Visible = false;
            deletePanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (deletePanel.Visible == true) deletePanel.Visible = false;
            else deletePanel.Visible = true;
            addPanel.Visible = false;
            updatePanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (updatePanel.Visible == true) updatePanel.Visible = false;
            else updatePanel.Visible = true;
            addPanel.Visible = false;
            deletePanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAccountsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String username = addUsernameBox.Text;
            String password = addPasswordBox.Text;
            String firstName = addFirstnameBox.Text;
            String lastName = addLastnameBox.Text;
            String Type = addTypebox.Text;

            String errMsg = "";

            if (username == "")
                errMsg += "No username input \n";
            if (password == "")
                errMsg += "No password input \n";
            if (firstName == "")
                errMsg += "No first name input \n";
            if (lastName == "")
                errMsg += "No last name input \n";
            if (Type == "")
                errMsg += "No type selected";

            if (errMsg != "")
                MessageBox.Show(errMsg, "ERROR");
            else
            {
                try
                {
                    EmployeeType employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), Type);
                    srv.addAccount(username, password, firstName, lastName, employeeType);
                    MessageBox.Show("Employee added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadList();

                    addUsernameBox.Text = "";
                    addPasswordBox.Text = "";
                    addFirstnameBox.Text = "";
                    addLastnameBox.Text = "";
                    addTypebox.SelectedItem = null;
                }
                catch (RepositoryException)
                {
                    MessageBox.Show("Username already exists", "ERROR");
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String username = dgvDelete.SelectedRows[0].Cells[0].Value.ToString();
            srv.deleteAccount(username);
            MessageBox.Show("Employee deleted successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String username = updateUsernameBox.Text;
            String password = updatePasswordBox.Text;
            String firstName = updateFirstnameBox.Text;
            String lastName = updateLastnameBox.Text;
            String Type = updateTypeBox.Text;

            String errMsg = "";

            if (username == "")
                errMsg += "No username input \n";
            if (password == "")
                errMsg += "No password input \n";
            if (firstName == "")
                errMsg += "No first name input \n";
            if (lastName == "")
                errMsg += "No last name input \n";
            if (Type == "")
                errMsg += "No type selected";

            if (errMsg != "")
                MessageBox.Show(errMsg, "ERROR");
            else
            {
                try { 
                EmployeeType employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), Type);
                srv.updateAccount(username, password, firstName, lastName, employeeType);
                MessageBox.Show("Employee updated successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadList();

                updateUsernameBox.Text = "";
                updatePasswordBox.Text = "";
                updateFirstnameBox.Text = "";
                updateLastnameBox.Text = "";
                updateTypeBox.SelectedItem = null;
                }
                catch (RepositoryException)
                {
                    MessageBox.Show("Account doesn't exist", "ERROR");
                }
            }
        }
    }
}
