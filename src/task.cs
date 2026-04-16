using System;
using System.Collections.Generic;
using System.Text;



namespace StretchApp.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        public string? Title { get; set; }
        public string? Priority { get; set; }
        public string? Status { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime Created_At { get; set; }
        public string? Notes { get; set; }
    }
}