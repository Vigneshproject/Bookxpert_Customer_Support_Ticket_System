namespace TicketSystemAPI.Models
{
    public class TicketComment
    {
        public int CommentId { get; set; }

        public int TicketId { get; set; }

        public string? CommentText { get; set; }

        public int CommentBy { get; set; }

        public DateTime CommentDate { get; set; }
    }
}
