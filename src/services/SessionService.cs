using StretchApp.src.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StretchApp.src.services
{
    public class SessionService
    {
        private readonly List<Session> _sessions = new();
        private int _nextId = 1;

        public int TotalSessionsToday =>
            _sessions.Count(s =>
                s != null &&
                s.IsCompleted &&
                s.StartTime.Date == DateTime.Today);

        public int FocusMinutesToday =>
            _sessions
                .Where(s =>
                    s != null &&
                    s.IsCompleted &&
                    s.Type == SessionType.Focus &&
                    s.StartTime.Date == DateTime.Today)
                .Sum(s => s.DurationMinutes);

        public int BreakMinutesToday =>
            _sessions
                .Where(s =>
                    s != null &&
                    s.IsCompleted &&
                    s.Type == SessionType.Break &&
                    s.StartTime.Date == DateTime.Today)
                .Sum(s => s.DurationMinutes);

        public IReadOnlyList<Session> AllSessions => _sessions.AsReadOnly();

        public Session CreateSession(SessionType type, int durationMinutes)
        {
            var session = new Session(_nextId++, type, durationMinutes);
            _sessions.Add(session);
            return session;
        }

        public void RemoveIncompleteSession(Session session)
        {
            if (session == null) return;
            if (!session.IsCompleted)
            {
                _sessions.Remove(session);

                _nextId = _sessions.Count > 0
                    ? _sessions.Max(s => s.Id) + 1
                    : 1;
            }
        }

        public void CompleteSession(Session session)
        {
            if (session == null) return;
            if (!session.IsCompleted)
                session.Complete();
        }

        public List<Session> GetSessionsToday()
        {
            return _sessions
                .Where(s =>
                    s != null &&
                    s.StartTime.Date == DateTime.Today)
                .ToList();
        }

        public void ClearAll()
        {
            _sessions.Clear();
            _nextId = 1;
        }
    }
}