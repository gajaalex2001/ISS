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
    public partial class TesterWindow : Form
    {
        Services srv;
        Employee em;

        public TesterWindow(Services srv, Employee em)
        {
            this.srv = srv;
            this.em = em;
            InitializeComponent();
            loadForm();
        }

        private void TesterWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void loadForm()
        {
            var bindingList = new BindingList<Bug>(srv.getBugs());
            var source = new BindingSource(bindingList, null);
            dgvBugs.DataSource = source;
        }

        private void TesterWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBugsPanel.Hide();
            viewBugsPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewBugsPanel.Hide();
            addBugsPanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String description = textDescription.Text;
            String severity = textSeverity.Text;
            String priority = textPriority.Text;

            String errMsg = "";

            if (description == "")
                errMsg += "No description input \n";
            if (priority == "")
                errMsg += "No priority selected \n";
            if (severity == "")
                errMsg += "No severity selected \n";

            if (errMsg != "")
                MessageBox.Show(errMsg, "ERROR");
            else
            {
                Priority prio = (Priority)Enum.Parse(typeof(Priority), priority);
                Severity seve = (Severity)Enum.Parse(typeof(Severity), severity);

                srv.addBug(description, prio, seve);
                MessageBox.Show("Bug added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                textDescription.Text = "";

                textSeverity.SelectedItem = null;
                textPriority.SelectedItem = null;

                loadForm();
            }

        }
    }
}
