using CommonBase.Extensions;
using QnSBillShare.Contracts.Business.App;
using QnSBillShare.Contracts.Modules.App;
using QnSBillShare.Contracts.Persistence.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QnSBillShare.AspMvc.Models.App
{
    public class BillExpense : ModelObject, Contracts.Business.App.IBillExpense
    {
        public Bill BilllEntity { get; set; } = new Bill();
        public List<Expense> ExpenseEntities { get; set; } = new List<Expense>();
        public List<Balance> BalanceEntities { get; set; } = new List<Balance>();
        public IEnumerable<IExpense> Expenses => ExpenseEntities;

        public new int Id 
        {
            get => BilllEntity.Id;
            set => BilllEntity.Id = value;
        }
        public new byte[] Timestamp
        {
            get => BilllEntity.Timestamp;
            set => BilllEntity.Timestamp = value;
        }
        public IBill Bill => BilllEntity;
        public double TotalExpense { get; set; }
        public double FriendPortion { get; set; }
        public int NumberOfFriends { get; set; }
        public string[] Friends { get; set; }
        public double[] FriendAmounts { get; set; }
        public IEnumerable<IBalance> Balances => BalanceEntities;
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
        public void CopyProperties(IBillExpense other)
        {
            other.CheckArgument(nameof(other));
            other.Bill.CheckArgument(nameof(other.Bill));
            other.Expenses.CheckArgument(nameof(other.Expenses));
            other.Balances.CheckArgument(nameof(other.Balances));

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
