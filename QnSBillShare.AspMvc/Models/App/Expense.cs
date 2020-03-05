
namespace QnSBillShare.AspMvc.Models.App
{
    public class Expense : ModelObject, Contracts.Persistence.App.IExpense
    {
        public int BillId { get; set; }
        public string Designation { get; set; }
        public double Amount { get; set; }
        public string Friend { get; set; }

        public void CopyProperties(QnSBillShare.Contracts.Persistence.App.IExpense other)
        {
            base.CopyProperties(other);

            BillId = other.BillId;
            Designation = other.Designation;
            Amount = other.Amount;
            Friend = other.Friend;
        }
    }
}
