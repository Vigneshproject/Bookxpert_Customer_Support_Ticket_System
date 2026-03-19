using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystemWinForms.Model;

namespace TicketSystemWinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var data = new
            {
                Username = txtUser.Text,
                Password = txtPass.Text
            };

            var user = ApiHelper.Post<User>(
                "Auth/login",
                data
            );

            if (user == null)
            {
                MessageBox.Show("Invalid login");
                return;
            }

            TicketListForm f = new TicketListForm(user);
            f.Show();

            this.Hide();
        }        
    }
}
