namespace TicketSystemAPI.Models
{
    public class CreateTicketModel
    {
        public int UserId { get; set; }

        public string? Subject { get; set; }

        public string? Description { get; set; }

        public string? Priority { get; set; }
    }

    public class AssignModel
    {
        public int TicketId { get; set; }

        public int AdminId { get; set; }
    }

    public class StatusModel
    {
        public int TicketId { get; set; }

        public string? Status { get; set; }

        public int UserId { get; set; }
    }

    public class CommentModel
    {
        public int TicketId { get; set; }

        public string? Text { get; set; }

        public int UserId { get; set; }
    }
}
