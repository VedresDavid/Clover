using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;

namespace Clover.Data.DAL
{
	public class DatabaseManagement
	{
		public static async Task SetupDatabase()
		{
			if (!File.Exists("./appdata.sqlite"))
			{
				using var dbConnection = new SQLiteConnection(@"Data Source=appdata.sqlite;Version=3;");
				await dbConnection.OpenAsync();

				using var createTables = new SQLiteCommand(
					@"CREATE TABLE CASES (
						id INTEGER PRIMARY KEY AUTOINCREMENT,
						caseNumber TEXT NOT NULL,
						comment TEXT
					);
					  CREATE TABLE ITEMS (
						id INTEGER PRIMARY KEY AUTOINCREMENT,
						reciever TEXT,
						sender TEXT,
						transactionDate TEXT,
						amount INTEGER,
						isIn BOOLEAN,
						caseNumber TEXT,
						FOREIGN KEY (caseNumber) REFERENCES CASES(caseNumber)
					)"
					, dbConnection);
				await createTables.ExecuteNonQueryAsync();

				dbConnection.Close();
			}
		}
	}
}
