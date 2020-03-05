
using CommonBase.Extensions;
using System.ComponentModel;

namespace QnSBillShare.AspMvc.Models.App
{
    public class Balance : Contracts.Modules.App.IBalance
    {
        [DisplayName("Schuldner")]
        public string From { get; set; }
        [DisplayName("Gläubiger")]
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
