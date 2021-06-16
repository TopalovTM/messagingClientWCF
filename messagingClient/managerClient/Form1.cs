using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using managerClient.servRef;

namespace managerClient
{
    public partial class Form1 : Form
    {
        AdminClient proxy;
        public Form1()
        {
            InitializeComponent();
            proxy = new AdminClient();

        }

        private void btGetUsers_Click(object sender, EventArgs e)
        {
            lbUsers.Items.Clear();
            User[] users = proxy.GetAllUsers();
            foreach (User u in users)
            {
                lbUsers.Items.Add(u);
            }
        }

        private void btBlockUser_Click(object sender, EventArgs e)
        {
            User u = (User)lbUsers.SelectedItem;
            if (u != null)
            {
                proxy.BlockUser(u.Name);
            }
            else
            {
                MessageBox.Show("Please, select a user first.");
            }
        }
    }
}
