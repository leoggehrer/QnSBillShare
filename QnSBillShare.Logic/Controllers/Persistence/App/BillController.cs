using QnSBillShare.Contracts.Persistence.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QnSBillShare.Logic.Controllers.Persistence.App
{
    partial class BillController
    {
        public override async Task<IBill> CreateAsync()
        {
            var result =  await base.CreateAsync().ConfigureAwait(false);

            result.Date = DateTime.Now;
            result.Currency = "EUR";
            return result;
        }
    }
}
