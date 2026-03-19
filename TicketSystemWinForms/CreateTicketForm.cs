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
    public partial class CreateTicketForm : Form
    {
        User _user;

        public CreateTicketForm(User user)
        {
            InitializeComponent();

            _user = user;
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            var data = new
            {
                UserId = _user.userId,
                Subject = txtSubject.Text,
                Description = txtDesc.Text,
                Priority = cmbPriority.Text
            };

            ApiHelper.Post<object>(
                "Ticket/create",
                data
            );

            MessageBox.Show("Created");

            this.Close();
        }
    }
}
