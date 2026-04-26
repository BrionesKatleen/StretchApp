using StretchApp.src.models;
using StretchApp.src.repositories;

namespace StretchApp.src.services
{
    public class SessionService
    {
        private readonly SessionRepository _repository;
        private Session _currentSession;

        public SessionService()
        {
            _repository = new SessionRepository();
        }

        public void StartSession(SessionType type, int duration)
        {
            _currentSession = new Session(0, type, duration);

            _repository.InsertSession(_currentSession);
        }

        public void CompleteCurrentSession()
        {
            if (_currentSession == null) return;

            _currentSession.Complete();

            _repository.UpdateSession(_currentSession);
        }
    }
}