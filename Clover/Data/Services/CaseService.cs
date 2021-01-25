using Clover.Data.DAL;
using Clover.Data.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clover.Data.Services
{
	public class CaseService
	{
		public static bool IsCaseNameValid(string caseNumber)
		{
			var caseNumbers = CaseDataAccessOperation.GetCaseNumbers();

			if (caseNumbers.Result.Any((s) => s == caseNumber)) return false;

			return true;
		}



		public async Task<List<Case>> GetCases(CaseOrderEnum caseOrder = CaseOrderEnum.CaseNumberAscending,string searchText = "")
		{
			//get data
			var cases = await CaseDataAccessOperation.GetCases(caseOrder);

			if (caseOrder == CaseOrderEnum.NumberOfItemsAscending)
			{
				cases = cases.OrderBy((s) => s.NumberOfItems).ToList();
			}
			else if (caseOrder == CaseOrderEnum.NumberOfItemsDescending)
			{
				cases = cases.OrderByDescending((s) => s.NumberOfItems).ToList();
			}
			else if (caseOrder == CaseOrderEnum.SumAscending)
			{
				cases = cases.OrderBy((s) => s.Sum).ToList();
			}
			else if (caseOrder == CaseOrderEnum.SumDescending)
			{
				cases = cases.OrderByDescending((s) => s.Sum).ToList();
			}

			//filter data
			if (!string.IsNullOrWhiteSpace(searchText))
			{
				cases = (
				 from
					_case in cases
				 where
					_case.CaseNumber.Contains(searchText) ||
					_case.Comment.Contains(searchText) ||
					_case.NumberOfItems.ToString().Contains(searchText) ||
					_case.Sum.ToString().Contains(searchText)
				 select
					_case).ToList();
			}
			return cases;
		}
		public async Task CreateCase(Case _case)
		{
			if (IsCaseNameValid(_case.CaseNumber))
			{
				await CaseDataAccessOperation.InsertCase(_case);
			}
		}

		public async Task DeleteCase(string caseNumber)
		{
			await CaseDataAccessOperation.DeleteCase(caseNumber);
		}

		public async Task DeleteAllCases()
		{
			await CaseDataAccessOperation.DeleteAllCases();
		}

		public async Task<Case> GetCase(string caseNumber)
		{
			return await CaseDataAccessOperation.GetCase(caseNumber);
		}

		public async Task ModifyCase(string oldCaseNumber,string newCaseNumber,string comment)
		{
			if(IsCaseNameValid(newCaseNumber))
			{
				await CaseDataAccessOperation.UpdateCase(oldCaseNumber, newCaseNumber, comment);
			}
		}
	}
}
