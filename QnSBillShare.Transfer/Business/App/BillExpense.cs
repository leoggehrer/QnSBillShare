using CommonBase.Extensions;
using QnSBillShare.Contracts.Business.App;
using QnSBillShare.Contracts.Persistence.App;
using QnSBillShare.Transfer.Modules.App;
using QnSBillShare.Transfer.Persistence.App;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace QnSBillShare.Transfer.Business.App
{
    partial class BillExpense
    {
        [JsonPropertyName(nameof(Bill))]
        public Bill BilllEntity { get; set; } = new Bill();
        [JsonPropertyName(nameof(Expenses))]
        public List<Expense> ExpenseEntities { get; set; } = new List<Expense>();
        [JsonPropertyName(nameof(Balances))]
        public List<Balance> BalanceEntities { get; set; } = new List<Balance>();

        partial void OnIdReading()
        {
            _id = BilllEntity.Id;
        }
        partial void OnBillReading()
        {
            _bill = BilllEntity;
        }
        partial void OnExpensesReading()
        {
            _expenses = ExpenseEntities;
        }
        partial void OnBalancesReading()
        {
            _balances = BalanceEntities;
        }

        public IExpense CreateExpense()
        {
            return new Expense();
        }
        public void Add(IExpense expense)
        {
            expense.CheckArgument(nameof(expense));

            var newItem = new Expense();

            newItem.CopyProperties(expense);
            ExpenseEntities.Add(newItem);
        }
        public void Remove(IExpense expense)
        {
            expense.CheckArgument(nameof(expense));

            foreach (var item in ExpenseEntities)
            {
                if (item.Id != 0 && item.Id == expense.Id)
                {
                    ExpenseEntities.Remove(item);
                }
                else if (item.Designation != null && item.Designation.Equals(expense.Designation))
                {
                    ExpenseEntities.Remove(item);
                }
            }
        }

        partial void BeforeCopyProperties(IBillExpense other, ref bool handled)
        {
            other.CheckArgument(nameof(other));
            other.Bill.CheckArgument(nameof(other.Bill));
            other.Expenses.CheckArgument(nameof(other.Expenses));
            other.Balances.CheckArgument(nameof(other.Balances));

            handled = true;
            TotalExpense = other.TotalExpense;
            FriendPortion = other.FriendPortion;
            NumberOfFriends = other.NumberOfFriends;
            Friends = other.Friends;
            FriendAmounts = other.FriendAmounts;
            BilllEntity.CopyProperties(other.Bill);
            ExpenseEntities.Clear();
            foreach (var item in other.Expenses)
            {
                var expense = new Expense();

                expense.CopyProperties(item);
                ExpenseEntities.Add(expense);
            }
            BalanceEntities.Clear();
            foreach (var item in other.Balances)
            {
                var balance = new Balance();

                balance.CopyProperties(item);
                BalanceEntities.Add(balance);
            }
        }
    }
}
