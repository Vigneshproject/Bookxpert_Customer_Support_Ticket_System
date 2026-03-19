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
    public partial class TicketListForm : Form
    {
        User _user;

        public TicketListForm(User user)
        {
            InitializeComponent();

            _user = user;

            LoadTickets();
        }

        void LoadTickets()
        {
            var list = ApiHelper.Get<List<Ticket>>(
                "Ticket/list/" +
                _user.userId +
                "/" +
                _user.role
            );

            dgv.DataSource = list;
        }

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            LoadTickets();
        }

        private void btnCreate_Click(
            object sender,
            EventArgs e)
        {
            CreateTicketForm f =
                new CreateTicketForm(_user);

            f.ShowDialog();

            LoadTickets();
        }
    }
}
