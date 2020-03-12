using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QnSBillShare.AspMvc.Controllers
{
    public class ExpenseController : Controller
    {
        private Models.App.Bill ConvertToModel(Contracts.Persistence.App.IBill entity)
        {
            var model = new Models.App.Bill();

            model.CopyProperties(entity);
            return model;
        }
        private Models.App.Expense ConvertToModel(Contracts.Persistence.App.IExpense entity)
        {
            var model = new Models.App.Expense();

            model.CopyProperties(entity);
            return model;
        }
        private Contracts.Client.IAdapterAccess<Contracts.Persistence.App.IBill> CreatePersistenceCtrl()
        {
            return Adapters.Factory.Create<Contracts.Persistence.App.IBill>();
        }
        private Contracts.Client.IAdapterAccess<Contracts.Business.App.IBillExpense> CreateBusinessCtrl()
        {
            return Adapters.Factory.Create<Contracts.Business.App.IBillExpense>();
        }

        public IActionResult Index()
        {
            return View();
        }
        [ActionName("Create")]
        public async Task<IActionResult> CreateAsync(int billId)
        {
            using var ctrl = CreateBusinessCtrl();
            var bill = await ctrl.GetByIdAsync(billId);
            var entity = bill.CreateExpense();

            entity.BillId = billId;
            var model = ConvertToModel(entity);

            model.Bill = ConvertToModel(bill.Bill);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<ActionResult> CreateAsync(Models.App.Expense model)
        {
            try
            {
                // TODO: Add insert logic here
                using var ctrl = CreateBusinessCtrl();
                var bill = await ctrl.GetByIdAsync(model.BillId);

                model.Bill = ConvertToModel(bill.Bill);
                bill.Add(model);
                await ctrl.UpdateAsync(bill);
                return RedirectToAction("Details", "Bill", new { id = model.BillId });
            }
            catch
            {
                return View(model);
            }
        }

    }
}