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
    public partial class ProgrammerWindow : Form, IObserver
    {
        Services srv;
        Employee em;

        public ProgrammerWindow(Services srv, Employee em)
        {
            this.srv = srv;
            this.em = em;
            InitializeComponent();
            srv.login(em.username, this);
            LoadList();
        }

        public void updateReceived()
        {
            LoadList();
        }

        private void ProgrammerWindow_Load(object sender, EventArgs e)
        {

        }

        private void LoadList()
        {
            var bindingList = new BindingList<Bug>(srv.getBugs());
            var source = new BindingSource(bindingList, null);
            dgvBugs.DataSource = source;
        }

        private void ProgrammerWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            srv.logout(em.username);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvBugs.SelectedRows[0].Cells[0].Value.ToString());
            srv.fixBug(id);
        }

        private void ProgrammerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            srv.logout(em.username);
        }
    }
}
