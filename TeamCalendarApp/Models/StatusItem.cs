using System;

namespace TeamCalendarApp.Models
{
    public class StatusItem
    {
        public int StatusItemId { get; set; }
        public int StatusTypeId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
