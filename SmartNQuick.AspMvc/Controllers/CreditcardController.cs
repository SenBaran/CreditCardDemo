using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartNQuick.AspMvc.Models.Creditcard;
using SmartNQuick.Contracts.Persistence.Creditcard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartNQuick.AspMvc.Controllers
{
    public class CreditcardController : GenericModelController<ICreditcard, AspMvc.Models.Creditcard.Creditcard>
    {
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			using var ctrl = Logic.Factory.Create<Contracts.Persistence.Creditcard.ICreditcard>();
			var entity = await ctrl.CreateAsync().ConfigureAwait(false);

			return View(ToModel(entity));
		}

		[HttpPost]
		public async Task<IActionResult> Insert(Creditcard model)
		{
			using var ctrl = Logic.Factory.Create<ICreditcard>();

			await ctrl.InsertAsync(model).ConfigureAwait(false);
			await ctrl.SaveChangesAsync().ConfigureAwait(false);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			using var ctrl = Logic.Factory.Create<ICreditcard>();
			var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

			return View(ToModel(entity));
		}

		[HttpPost]
		public async Task<IActionResult> Update(Creditcard model)
		{
			using var ctrl = Logic.Factory.Create<ICreditcard>();
			var entity = await ctrl.GetByIdAsync(model.Id).ConfigureAwait(false);

			if (entity != null)
			{
				entity.CreditcardNumber = model.CreditcardNumber;
				await ctrl.UpdateAsync(entity).ConfigureAwait(false);
				await ctrl.SaveChangesAsync().ConfigureAwait(false);
			}
			return RedirectToAction("Index");
		}
		[HttpGet]
		public async Task<IActionResult> Delete(int id)
		{
			using var ctrl = Logic.Factory.Create<ICreditcard>();
			var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

			return View(ToModel(entity));
		}

		public async Task<IActionResult> DeleteEntity(int id)
		{
			using var ctrl = Logic.Factory.Create<ICreditcard>();

			await ctrl.DeleteAsync(id).ConfigureAwait(false);
			await ctrl.SaveChangesAsync().ConfigureAwait(false);

			return RedirectToAction("Index");
		}
	}
}
