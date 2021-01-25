using Clover.Data.DAL;
using Clover.Data.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clover.Data.Services
{
	public class ItemService
	{
		public async Task CreateItem(Item item)
		{
			await ItemDataAccessOperation.InsertItem(item);
		}

		public async Task<List<Item>> GetItems(string caseNumber, ItemOrderEnum itemOrder = ItemOrderEnum.TransactionDateAscending,string searchText = "")
		{
			//get data
			var items = await ItemDataAccessOperation.GetItemsOfACase(itemOrder, caseNumber);

			if (itemOrder == ItemOrderEnum.InOutAscending)
			{
				items = items.OrderBy((s) => s.IsIn).ToList();
			}
			else if (itemOrder == ItemOrderEnum.InOutDescending)
			{
				items = items.OrderByDescending((s) => s.IsIn).ToList();
			}

			//filter data
			if (!string.IsNullOrWhiteSpace(searchText))
			{
				items = (from 
							item in items
						where
							item.Sender.Contains(searchText) ||
							item.Reciever.Contains(searchText) ||
							item.TransactionDate.Contains(searchText) ||
							item.CaseNumber.Contains(searchText) ||
							item.Amount.ToString().Contains(searchText)
						select item).ToList();
			}

			return items;
		}

		public async Task ModifyItem(Item item)
		{
			await ItemDataAccessOperation.UpdateItem(item);
		}

		public async Task DeleteAllItems(string caseNumber)
		{
			await ItemDataAccessOperation.DeleteAllItemsOfACase(caseNumber);
		}

		public async Task DeleteItem(long id)
		{
			await ItemDataAccessOperation.DeleteItem(id);
		}

		public long GetSum(List<Item> items)
		{
			var inAmounts = items.Where((s) => s.IsIn == true)
								 .Select((s) => s.Amount)
								 .ToList();

			long inSum = 0;

			foreach (var amount in inAmounts)
			{
				inSum += amount;
			}

			var outAmounts = items.Where((s) => s.IsIn == false)
								  .Select((s) => s.Amount)
								  .ToList();

			long outSum = 0;

			foreach (var amount in outAmounts)
			{
				outSum += amount;
			}

			return inSum - outSum;
		}
	}
}
