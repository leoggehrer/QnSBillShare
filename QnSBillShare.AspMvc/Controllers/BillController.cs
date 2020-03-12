using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QnSBillShare.AspMvc.Controllers
{
    public class BillController : Controller
    {
        private Models.App.Bill ConvertToModel(Contracts.Persistence.App.IBill entity)
        {
            var model = new Models.App.Bill();

            model.CopyProperties(entity);
            return model;
        }
        private Models.App.BillExpense ConvertToModel(Contracts.Business.App.IBillExpense entity)
        {
            var model = new Models.App.BillExpense();

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
    
        // GET: Bill
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync()
        {
            using var ctrl = CreatePersistenceCtrl();
            var models = (await ctrl.GetAllAsync()).Select(e => ConvertToModel(e));
            return View(models);
        }

        // GET: Bill/Details/5
        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(int id)
        {
            using var ctrl = CreateBusinessCtrl();
            var entity = await ctrl.GetByIdAsync(id);

            return View(ConvertToModel(entity));
        }

        // GET: Bill/Create
        [ActionName("Create")]
        public async Task<ActionResult> CreateAsync()
        {
            using var ctrl = CreatePersistenceCtrl();
            var model = ConvertToModel(await ctrl.CreateAsync());
            return View("Create", model);
        }

        // POST: Bill/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<ActionResult> CreateAsync(Models.App.Bill model)
        {
            try
            {
                // TODO: Add insert logic here
                using var ctrl = CreatePersistenceCtrl();

                await ctrl.InsertAsync(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Bill/Edit/5
        [ActionName("Edit")]
        public ActionResult EditAsync(int id)
        {
            return View();
        }

        // POST: Bill/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public ActionResult EditAsync(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Bill/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bill/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateExpense(int id)
        {
            return RedirectToAction("Create", "Expense", new { billId = id });
        }
    }
}