namespace Clover.Data
{
	public sealed class Case
	{
		public long Id { get; set; }
		public string CaseNumber { get; set; }
		public string Comment { get; set; }
		public long NumberOfItems { get; set; }
		public long Sum { get; set; }
	}
}
