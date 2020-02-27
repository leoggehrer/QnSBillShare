using System;
using System.Collections.Generic;
using System.Text;

namespace QnSBillShare.Contracts.Persistence.App
{
    public partial interface IExpense : IIdentifiable, ICopyable<IExpense>
    {
        int BillId { get; set; }
        string Designation { get; set; }
        double Amount { get; set; }
        string Friend { get; set; }
    }
}
