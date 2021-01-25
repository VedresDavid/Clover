using Clover.Data.DTO;
using Clover.Data.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace Clover.Data.DAL
{
	public class CaseDataAccessOperation
	{
		public static async Task<List<string>> GetCaseNumbers()
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"SELECT caseNumber FROM CASES", dbConnection);

			var response = await sql.ExecuteReaderAsync();

			var caseNames = new List<string>();

			while (await response.ReadAsync())
			{
				caseNames.Add(response["caseNumber"].ToString());
			}

			response.Close();

			dbConnection.Close();

			return caseNames;
		}

		public static async Task InsertCase(Case _case)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"INSERT INTO 
													CASES (
														caseNumber,
														Comment) 
													VALUES (
														@caseNumber,
														@comment)"
												, dbConnection);

			sql.Parameters.AddWithValue("@caseNumber", _case.CaseNumber);
			sql.Parameters.AddWithValue("@comment", _case.Comment);
			await sql.ExecuteNonQueryAsync();

			dbConnection.Close();
		}

		public static async Task DeleteCase(string caseNumber)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"DELETE FROM CASES WHERE caseNumber = @caseNumber;DELETE FROM ITEMS WHERE caseNumber = @caseNumber", dbConnection);

			sql.Parameters.AddWithValue("@caseNumber", caseNumber);

			await sql.ExecuteNonQueryAsync();

			dbConnection.Close();
		}

		public static async Task DeleteAllCases()
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"DELETE FROM CASES;
												DELETE FROM ITEMS", dbConnection);
			await sql.ExecuteNonQueryAsync();

			dbConnection.Close();
		}

		public static async Task<Case> GetCase(string caseNumber)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"SELECT * FROM CASES WHERE caseNumber = @caseNumber", dbConnection);
			sql.Parameters.AddWithValue("@caseNumber", caseNumber);
			var response = await sql.ExecuteReaderAsync();

			Case _case;

			await response.ReadAsync();

			_case = new Case()
			{
				CaseNumber = response["caseNumber"].ToString(),
				Comment = response["comment"].ToString(),
				Id = (Int64)response["id"],
			};

			response.Close();

			dbConnection.Close();

			return _case;
		}

		public static async Task UpdateCase(string oldCaseNumber, string newCaseNumber, string comment)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"UPDATE ITEMS SET
												caseNumber = @newCaseNumber
										   WHERE
												caseNumber = @oldCaseNumber;
										   UPDATE CASES SET
												caseNumber = @newCaseNumber,
												comment = @comment
										   WHERE 
												caseNumber = @oldCaseNumber", dbConnection);

			sql.Parameters.AddWithValue("@newCaseNumber", newCaseNumber);
			sql.Parameters.AddWithValue("@oldCaseNumber", oldCaseNumber);
			sql.Parameters.AddWithValue("@comment", comment);
			await sql.ExecuteNonQueryAsync();

			dbConnection.Close();
		}

		public static async Task<List<Case>> GetCases(CaseOrderEnum caseOrder)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = caseOrder switch
			{
				CaseOrderEnum.CaseNumberAscending => new SQLiteCommand(@"SELECT * FROM CASES ORDER BY caseNumber ASC", dbConnection),
				CaseOrderEnum.CommentAscending => new SQLiteCommand(@"SELECT * FROM CASES ORDER BY comment ASC", dbConnection),
				CaseOrderEnum.CaseNumberDescending => new SQLiteCommand(@"SELECT * FROM CASES ORDER BY caseNumber DESC", dbConnection),
				CaseOrderEnum.CommentDescending => new SQLiteCommand(@"SELECT * FROM CASES ORDER BY comment DESC", dbConnection),
				_ => new SQLiteCommand(@"SELECT * FROM CASES ORDER BY caseNumber ASC", dbConnection),
			};

			var response = await sql.ExecuteReaderAsync();

			var cases = new List<Case>();

			var itemService = new ItemService();

			while (await response.ReadAsync())
			{
				cases.Add(new Case
				{
					Id = (Int64)response["id"],
					CaseNumber = response["caseNumber"].ToString(),
					Comment = response["comment"].ToString(),
					NumberOfItems = (await itemService.GetItems(response["caseNumber"].ToString())).Count,
					Sum = itemService.GetSum(await itemService.GetItems(response["caseNumber"].ToString()))
				});
			}

			response.Close();

			dbConnection.Close();
			return cases;
		}
	}
}
