namespace LumixApp.Models
{
    public class RSVP
    {
        public string Id { get; set; }
        public string EventId { get; set; }
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public string Timestamp { get; set; }
        public bool IsAttended { get; set; }
    }
}
