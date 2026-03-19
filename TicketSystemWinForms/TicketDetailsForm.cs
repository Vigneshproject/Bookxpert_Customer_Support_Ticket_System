using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TicketSystemWinForms.Model;

namespace TicketSystemWinForms
{
    public partial class TicketDetailsForm : Form
    {
        User _user;
        Ticket _ticket;

        public TicketDetailsForm(
            User user,
            Ticket ticket)
        {
            InitializeComponent();

            _user = user;
            _ticket = ticket;

            lblNo.Text = ticket.ticketNumber;
            lblStatus.Text = ticket.status;
        }

        private void btnAssign_Click(
            object sender,
            EventArgs e)
        {
            var data = new
            {
                TicketId = _ticket.ticketId,
                AdminId = _user.userId
            };

            ApiHelper.Post<object>(
                "Ticket/assign",
                data
            );
        }

        private void btnStatus_Click(
            object sender,
            EventArgs e)
        {
            var data = new
            {
                TicketId = _ticket.ticketId,
                Status = cmbStatus.Text,
                UserId = _user.userId
            };

            ApiHelper.Post<object>(
                "Ticket/status",
                data
            );
        }

        private void btnComment_Click(
            object sender,
            EventArgs e)
        {
            var data = new
            {
                TicketId = _ticket.ticketId,
                Text = txtComment.Text,
                UserId = _user.userId
            };

            ApiHelper.Post<object>(
                "Ticket/comment",
                data
            );
        }
       
    }
}
