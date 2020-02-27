using System;
using System.Linq;
using System.Threading.Tasks;

namespace QnSBillShare.ConApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Run(() => Console.WriteLine("QnSBillShare"));

            Adapters.Factory.BaseUri = "https://localhost:44380/api";
            Adapters.Factory.Adapter = Adapters.Factory.AdapterType.Controller;
            using var ctrlBill = Adapters.Factory.Create<Contracts.Persistence.App.IBill>();
            using var ctrlExpense = Adapters.Factory.Create<Contracts.Persistence.App.IExpense>();
            var bill = await ctrlBill.CreateAsync();
            bill.Date = DateTime.Now;
            bill.Title = $"Manchester 2020-REST-{DateTime.Now}";
            bill.Description = "Demo";
            bill.Friends = "Gerhard,Robert";
            bill.Currency = "EUR";
            bill = await ctrlBill.InsertAsync(bill);
            for (int i = 0; i < 5; i++)
            {
                var expense = await ctrlExpense.CreateAsync();

                expense.BillId = bill.Id;
                expense.Designation = $"Kosten: {DateTime.Now}";
                expense.Amount = 10 * (i + 1);
                expense.Friend = "Robert";
                expense = await ctrlExpense.InsertAsync(expense);
            }
        }
    }
}
