using System;
using System.Collections.Generic;
using System.Linq;

namespace StretchApp
{
    public class SessionService
    {
        private List<Session> _sessions = new List<Session>();
        private int _nextId = 1;

        public int TotalSessionsToday =>
            _sessions.Count(s => s.StartTime.Date == DateTime.Today && s.IsCompleted);

        public int FocusMinutesToday =>
            _sessions.Where(s => s.Type == SessionType.Focus && s.IsCompleted && s.StartTime.Date == DateTime.Today)
                     .Sum(s => s.DurationMinutes);

        public int BreakMinutesToday =>
            _sessions.Where(s => s.Type == SessionType.Break && s.IsCompleted && s.StartTime.Date == DateTime.Today)
                     .Sum(s => s.DurationMinutes);

        public int TotalFocusSessions =>
            _sessions.Count(s => s.Type == SessionType.Focus && s.IsCompleted);

        public int TotalBreakSessions =>
            _sessions.Count(s => s.Type == SessionType.Break && s.IsCompleted);

        public IReadOnlyList<Session> AllSessions => _sessions.AsReadOnly();

        public Session CreateSession(SessionType type, int durationMinutes)
        {
            var session = new Session(_nextId++, type, durationMinutes);
            _sessions.Add(session);
            return session;
        }

        public void CompleteSession(Session session)
        {
            if (session != null && !session.IsCompleted)
            {
                session.Complete();
            }
        }

        public void RemoveIncompleteSession(Session session)
        {
            if (session != null && !session.IsCompleted)
            {
                _sessions.Remove(session);
                _nextId = _sessions.Count > 0 ? _sessions.Max(s => s.Id) + 1 : 1;
            }
        }

        public List<Session> GetSessionsToday()
        {
            return _sessions.Where(s => s.StartTime.Date == DateTime.Today).ToList();
        }

        public void ClearAll()
        {
            _sessions.Clear();
            _nextId = 1;
        }
    }
}