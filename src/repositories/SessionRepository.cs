using MySql.Data.MySqlClient;
using StretchApp.src.models;

namespace StretchApp.src.repositories
{
    public class SessionRepository
    {
        private readonly ConnectionSQL _db;

        public SessionRepository()
        {
            _db = new ConnectionSQL();
        }

        public void InsertSession(Session session)
        {
            using MySqlConnection conn = _db.GetConnection();

            string query = @"
                INSERT INTO Session
                (Type, StartTime, DurationMinutes, IsCompleted)
                VALUES
                (@Type, @StartTime, @DurationMinutes, @IsCompleted)";

            using MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Type", session.Type.ToString());
            cmd.Parameters.AddWithValue("@StartTime", session.StartTime);
            cmd.Parameters.AddWithValue("@DurationMinutes", session.DurationMinutes);
            cmd.Parameters.AddWithValue("@IsCompleted", session.IsCompleted);

            cmd.ExecuteNonQuery();
        }

        public void UpdateSession(Session session)
        {
            using MySqlConnection conn = _db.GetConnection();

            string query = @"
                UPDATE Session
                SET EndTime = @EndTime,
                    IsCompleted = @IsCompleted
                WHERE StartTime = @StartTime";

            using MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@EndTime", session.EndTime);
            cmd.Parameters.AddWithValue("@IsCompleted", session.IsCompleted);
            cmd.Parameters.AddWithValue("@StartTime", session.StartTime);

            cmd.ExecuteNonQuery();
        }
    }
}
