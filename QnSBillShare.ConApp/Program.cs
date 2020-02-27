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
            //using var ctrlBill = Adapters.Factory.Create<Contracts.Persistence.App.IBill>();
            //using var ctrlExpense = Adapters.Factory.Create<Contracts.Persistence.App.IExpense>();
            //var bill = await ctrlBill.CreateAsync();
            //bill.Date = DateTime.Now;
            //bill.Title = $"Manchester 2020-REST-{DateTime.Now}";
            //bill.Description = "Demo";
            //bill.Friends = "Gerhard,Robert";
            //bill.Currency = "EUR";
            //bill = await ctrlBill.InsertAsync(bill);
            //for (int i = 0; i < 5; i++)
            //{
            //    var expense = await ctrlExpense.CreateAsync();

            //    expense.BillId = bill.Id;
            //    expense.Designation = $"Kosten: {DateTime.Now}";
            //    expense.Amount = 10 * (i + 1);
            //    expense.Friend = "Robert";
            //    expense = await ctrlExpense.InsertAsync(expense);
            //}

            Adapters.Factory.Adapter = Adapters.Factory.AdapterType.Service;
            using var ctrlBillExpense = Adapters.Factory.Create<Contracts.Business.App.IBillExpense>();
            var boBill = await ctrlBillExpense.CreateAsync();
            boBill.Bill.Date = DateTime.Now;
            boBill.Bill.Title = $"Marokko 2020-REST-{DateTime.Now}";
            boBill.Bill.Description = "Demo";
            boBill.Bill.Friends = "Gerhard,Robert";
            boBill.Bill.Currency = "EUR";
            for (int i = 0; i < 5; i++)
            {
                var expense = boBill.CreateExpense();

                expense.Designation = $"Kosten: {DateTime.Now}";
                expense.Amount = 10 * (i + 1);
                expense.Friend = i % 2 == 0 ? "Robert" : "Gerhard";
                boBill.Add(expense);
            }
            await ctrlBillExpense.InsertAsync(boBill);
        }
    }
}
