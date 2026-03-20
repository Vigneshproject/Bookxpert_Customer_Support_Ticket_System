using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TicketSystemAPI.DbContext;
using TicketSystemAPI.Models;

[ApiController]
[Route("api/[controller]")]
public class TicketController : ControllerBase
{
    private readonly TicketDbContext _context;

    public TicketController(TicketDbContext context)
    {
        _context = context;
    }
    
    [HttpPost("create")]
    public IActionResult CreateTicket(CreateTicketModel model)
    {
        var last = _context.Tickets
            .OrderByDescending(x => x.TicketId)
            .FirstOrDefault();

        int num = last == null ? 1 : last.TicketId + 1;

        string ticketNo = "TCK-" + num.ToString("0000");

        var ticket = new Ticket
        {
            TicketNumber = ticketNo,
            Subject = model.Subject,
            Description = model.Description,
            Priority = model.Priority,
            Status = "Open",
            CreatedBy = model.UserId,
            CreatedDate = DateTime.Now
        };

        _context.Tickets.Add(ticket);
        _context.SaveChanges();

        return Ok(ticket);
    }
   
    [HttpGet("list/{userId}/{role}")]
    public IActionResult GetTickets(int userId, string role)
    {
        if (role == "Admin")
        {
            return Ok(_context.Tickets.ToList());
        }
        else
        {
            return Ok(
                _context.Tickets
                .Where(x => x.CreatedBy == userId)
                .ToList()
            );
        }
    }
  
    [HttpPost("assign")]
    public IActionResult Assign(AssignModel model)
    {
        var ticket = _context.Tickets.Find(model.TicketId);

        ticket.AssignedTo = model.AdminId;
        ticket.Status = "In Progress";

        _context.SaveChanges();

        return Ok();
    }
   
    [HttpPost("status")]
    public IActionResult ChangeStatus(StatusModel model)
    {
        var ticket = _context.Tickets.Find(model.TicketId);

        var old = ticket.Status;

        ticket.Status = model.Status;

        _context.SaveChanges();

        var history = new TicketStatusHistory
        {
            TicketId = model.TicketId,
            OldStatus = old,
            NewStatus = model.Status,
            UpdatedBy = model.UserId,
            UpdatedDate = DateTime.Now
        };

        _context.TicketStatusHistory.Add(history);
        _context.SaveChanges();

        return Ok();
    }
  
    [HttpPost("comment")]
    public IActionResult Comment(CommentModel model)
    {
        var c = new TicketComment
        {
            TicketId = model.TicketId,
            CommentText = model.Text,
            CommentBy = model.UserId,
            CommentDate = DateTime.Now
        };

        _context.TicketComments.Add(c);
        _context.SaveChanges();

        return Ok();
    }
}