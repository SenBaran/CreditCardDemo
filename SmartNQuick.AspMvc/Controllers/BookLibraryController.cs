using Microsoft.AspNetCore.Mvc;
using SmartNQuick.AspMvc.Models.Entity;
using SmartNQuick.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartNQuick.AspMvc.Controllers
{
    public class BookLibraryController : GenericModelController<IBookLibrary, BookLibrary>
    {
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            using var ctrl = Logic.Factory.Create<IBookLibrary>();

            var entity = await ctrl.CreateAsync().ConfigureAwait(false);

            return View(ToModel(entity));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(BookLibrary book)
        {
            using var ctrl = Logic.Factory.Create<IBookLibrary>();

            await ctrl.InsertAsync(book).ConfigureAwait(false);

            await ctrl.SaveChangesAsync().ConfigureAwait(false);


            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            using var ctrl = Logic.Factory.Create<IBookLibrary>();
            var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

            return View(ToModel(entity));
        }

        public async Task<IActionResult> DeleteEntity(int id)
        {
            using var ctrl = Logic.Factory.Create<IBookLibrary>();

            await ctrl.DeleteAsync(id).ConfigureAwait(false);
            await ctrl.SaveChangesAsync().ConfigureAwait(false);

            return RedirectToAction("Index");
        }
    }
}
