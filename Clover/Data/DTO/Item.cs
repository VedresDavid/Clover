namespace Clover.Data
{
	public sealed class Item
	{
		public long Id { get; set; }
		public string CaseNumber { get; set; }
		public string Sender { get; set; }
		public string Reciever { get; set; }
		public long Amount { get; set; }
		public string TransactionDate { get; set; }
		public bool IsIn { get; set; }
	}
}
