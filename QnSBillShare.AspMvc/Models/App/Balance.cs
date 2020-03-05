
using CommonBase.Extensions;

namespace QnSBillShare.AspMvc.Models.App
{
    public class Balance : Contracts.Modules.App.IBalance
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }

        public void CopyProperties(Contracts.Modules.App.IBalance other)
        {
            other.CheckArgument(nameof(other));

            From = other.From;
            To = other.To;
            Amount = other.Amount;
        }
    }
}
