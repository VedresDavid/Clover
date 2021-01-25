using Clover.Data.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace Clover.Data.DAL
{
	public class ItemDataAccessOperation
	{
		public static async Task InsertItem(Item item)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"INSERT INTO ITEMS (
												caseNumber,
												sender,
												reciever,
												amount,
												isIn,
												transactionDate) 
											VALUES (
												@caseNumber,
												@sender,
												@reciever,
												@amount,
												@isIn,
												@transactionDate)"
											, dbConnection);

			sql.Parameters.AddWithValue("@caseNumber", item.CaseNumber);
			sql.Parameters.AddWithValue("@sender", item.Sender);
			sql.Parameters.AddWithValue("@reciever", item.Reciever);
			sql.Parameters.AddWithValue("@amount", item.Amount);
			sql.Parameters.AddWithValue("@isIn", item.IsIn);
			sql.Parameters.AddWithValue("@transactionDate", item.TransactionDate);
			await sql.ExecuteNonQueryAsync();

			dbConnection.Close();
		}

		public static async Task UpdateItem(Item item)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"UPDATE ITEMS SET
												sender = @sender,
												reciever = @reciever,
												amount = @amount,
												transactionDate = @transactionDate,
												isIn = @isIn
										   WHERE
												id = @id", dbConnection);

			sql.Parameters.AddWithValue("@sender", item.Sender);
			sql.Parameters.AddWithValue("@reciever", item.Reciever);
			sql.Parameters.AddWithValue("@amount", item.Amount);
			sql.Parameters.AddWithValue("@transactionDate", item.TransactionDate);
			sql.Parameters.AddWithValue("@isIn", item.IsIn);
			sql.Parameters.AddWithValue("@id", item.Id);
			await sql.ExecuteNonQueryAsync();

			dbConnection.Close();
		}

		public static async Task DeleteAllItemsOfACase(string caseNumber)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"DELETE FROM ITEMS WHERE caseNumber = @caseNumber", dbConnection);
			sql.Parameters.AddWithValue("@caseNumber", caseNumber);
			await sql.ExecuteNonQueryAsync();

			dbConnection.Close();
		}

		public static async Task DeleteItem(long id)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = new SQLiteCommand(@"DELETE FROM ITEMS WHERE id = @id", dbConnection);
			sql.Parameters.AddWithValue("@id", id);
			await sql.ExecuteNonQueryAsync();

			dbConnection.Close();
		}

		public static async Task<List<Item>> GetItemsOfACase(ItemOrderEnum itemOrder,string caseNumber)
		{
			using var dbConnection = new SQLiteConnection("Data Source=appdata.sqlite");
			await dbConnection.OpenAsync();

			using var sql = itemOrder switch
			{
				ItemOrderEnum.SenderAscending => new SQLiteCommand(@"SELECT * FROM ITEMS WHERE caseNumber = @caseNumber ORDER BY sender ASC", dbConnection),
				ItemOrderEnum.RecieverAscending => new SQLiteCommand(@"SELECT * FROM ITEMS WHERE caseNumber = @caseNumber ORDER BY reciever ASC", dbConnection),
				ItemOrderEnum.AmountAscending => new SQLiteCommand(@"SELECT * FROM ITEMS WHERE caseNumber = @caseNumber ORDER BY amount ASC", dbConnection),
				ItemOrderEnum.TransactionDateAscending => new SQLiteCommand(@"SELECT * FROM ITEMS WHERE caseNumber = @caseNumber ORDER BY transactionDate ASC", dbConnection),
				ItemOrderEnum.SenderDescending => new SQLiteCommand(@"SELECT * FROM ITEMS WHERE caseNumber = @caseNumber ORDER BY sender DESC", dbConnection),
				ItemOrderEnum.RecieverDescending => new SQLiteCommand(@"SELECT * FROM ITEMS WHERE caseNumber = @caseNumber ORDER BY reciever DESC", dbConnection),
				ItemOrderEnum.AmountDescending => new SQLiteCommand(@"SELECT * FROM ITEMS WHERE caseNumber = @caseNumber ORDER BY amount DESC", dbConnection),
				ItemOrderEnum.TransactionDateDescending => new SQLiteCommand(@"SELECT * FROM ITEMS WHERE caseNumber = @caseNumber ORDER BY transactionDate DESC", dbConnection),
				_ => new SQLiteCommand(@"SELECT * FROM ITEMS WHERE caseNumber = @caseNumber ORDER BY transactionDate DESC", dbConnection)
			};

			sql.Parameters.AddWithValue("@caseNumber", caseNumber);

			await sql.ExecuteNonQueryAsync();

			var response = await sql.ExecuteReaderAsync();

			var items = new List<Item>();

			while (await response.ReadAsync())
			{
				items.Add(new Item()
				{
					Id = (long)response["id"],
					CaseNumber = response["caseNumber"].ToString(),
					Sender = response["sender"].ToString(),
					Reciever = response["reciever"].ToString(),
					Amount = (Int64)response["amount"],
					TransactionDate = response["transactionDate"].ToString(),
					IsIn = (bool)response["isIn"]
				});
			}

			response.Close();

			dbConnection.Close();

			return items;
		}
	}
}
