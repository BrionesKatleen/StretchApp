using System;

namespace Pomodoro
{
    public enum SessionType
    {
        Focus,
        Break
    }

    public class Session
    {
        public int Id { get; set; }
        public SessionType Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int DurationMinutes { get; set; }
        public bool IsCompleted { get; set; }

        public Session(int id, SessionType type, int durationMinutes)
        {
            Id = id;
            Type = type;
            DurationMinutes = durationMinutes;
            StartTime = DateTime.Now;
            IsCompleted = false;
        }

        public void Complete()
        {
            EndTime = DateTime.Now;
            IsCompleted = true;
        }

        public override string ToString()
        {
            string status = IsCompleted ? "Completed" : "In Progress";
            return $"Session #{Id} | {Type} | {DurationMinutes} min | {status} | Started: {StartTime:HH:mm}";
        }
    }
}
