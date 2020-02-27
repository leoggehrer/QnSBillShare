using CommonBase.Extensions;
using QnSBillShare.Contracts.Business.App;
using QnSBillShare.Contracts.Modules.App;
using QnSBillShare.Contracts.Persistence.App;
using QnSBillShare.Logic.Entities.Modules.App;
using QnSBillShare.Logic.Entities.Persistence.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QnSBillShare.Logic.Entities.Business.App
{
    partial class BillExpense
    {
        partial void OnIdReading()
        {
            _id = BillEntity.Id;
        }
        public Bill BillEntity { get; set; } = new Bill();
        partial void OnBillReading()
        {
            _bill = BillEntity;
        }

        public List<Expense> ExpenseEntities { get; set; } = new List<Expense>();
        partial void OnExpensesReading()
        {
            _expenses = ExpenseEntities;
        }
        partial void OnTotalExpenseReading()
        {
            _totalExpense = ExpenseEntities.Sum(i => i.Amount);
        }

        partial void OnFriendAmountsReading()
        {
            _friendAmounts = Friends.Select(f => ExpenseEntities.Where(e => e.Friend.Equals(f)).Sum(j => j.Amount)).ToArray();
        }

        partial void OnNumberOfFriendsReading()
        {
            _numberOfFriends = BillEntity.Friends != null ? BillEntity.Friends.Split(",").Length : 0;
        }
        partial void OnFriendsReading()
        {
            _friends = BillEntity.Friends != null ? BillEntity.Friends.Split(",") : new string[0];
        }
        partial void OnFriendPortionReading()
        {
            _friendPortion = NumberOfFriends != 0 ? TotalExpense / NumberOfFriends : 0;
        }

        partial void OnBalancesReading()
        {
            _balances = CreateBalance(); 
        }
        private IEnumerable<IBalance> CreateBalance()
        {
            List<Balance> result = new List<Balance>();
            var friendPart = FriendPortion;
            var friendAmounts = FriendAmounts;
            var friendsAndAmounts = Friends.Select((f, i) => new { Friend = f, Amount = FriendAmounts[i] });
            var gives = friendsAndAmounts.Where(i => i.Amount < friendPart);
            var gets = friendsAndAmounts.Where(i => i.Amount > friendPart);

            foreach (var give in gives)
            {
                double giveDif = friendPart - give.Amount;

                if (Math.Abs(giveDif) > 0.001)
                {
                    foreach (var get in gets)
                    {
                        var dif = get.Amount - friendPart - result.Where(i => i.To.Equals(get.Friend)).Sum(i => i.Amount);

                        if (giveDif > 0.01 && dif > 0.01)
                        {
                            var minDif = Math.Min(dif, giveDif);

                            result.Add(new Balance { From = give.Friend, To = get.Friend, Amount = minDif });
                            giveDif = giveDif - minDif;
                        }
                    }
                }
            }
            return result;
        }
        public IExpense CreateExpense()
        {
            return new Expense();
        }
        public void Add(IExpense expense)
        {
            expense.CheckArgument(nameof(expense));

            var entity = new Expense();

            entity.CopyProperties(expense);
            ExpenseEntities.Add(entity);
        }

        public void Remove(IExpense expense)
        {
            expense.CheckArgument(nameof(expense));

            var entity = ExpenseEntities.FirstOrDefault(i => (i.Id != 0 && i.Id == expense.Id)
                                                          || (i.Id == 0 && i.Designation != null && i.Designation.Equals(expense.Designation)));
            if (entity != null)
            {
                ExpenseEntities.Remove(entity);
            }
        }
        partial void BeforeCopyProperties(IBillExpense other, ref bool handled)
        {
            other.CheckArgument(nameof(other));
            other.Bill.CheckArgument(nameof(other.Bill));
            other.Expenses.CheckArgument(nameof(other.Expenses));

            handled = true;
            BillEntity.CopyProperties(other.Bill);
            ExpenseEntities.Clear();
            foreach (var item in other.Expenses)
            {
                var expense = new Expense();

                expense.CopyProperties(item);
                ExpenseEntities.Add(expense);
            }
        }
    }
}
