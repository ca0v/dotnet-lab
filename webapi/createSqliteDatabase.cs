using Microsoft.Data.Sqlite;

class CreateSqliteDatabase
{
    public static void CreateDatabase()
    {
        var conn = new Microsoft.Data.Sqlite.SqliteConnection("Data Source=database.sqlite");
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, name TEXT, email TEXT)";
        cmd.ExecuteNonQuery();
    }
}