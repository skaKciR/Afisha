using Afisha.Areas.Admin.Controllers;
using Afisha.Domain;
using Afisha.Domain.Entities;
using Afisha.Service;
using Microsoft.AspNetCore.Mvc;


namespace Afisha.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public EventItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Event() : dataManager.Events.GetEventItemById(id);
            return View(entity);
        }
		[HttpPost]
		public IActionResult Edit(Event model, IFormFile titleImageFile)
		{
			if (ModelState.IsValid)
			{
				if (titleImageFile != null)
				{
					byte[] imageData;
					using (var binaryReader = new BinaryReader(titleImageFile.OpenReadStream()))
					{
						imageData = binaryReader.ReadBytes((int)titleImageFile.Length);
					}
					if (model.Image == null || !model.Image.SequenceEqual(imageData))
					{
						model.Image = imageData;
					}
				}
				dataManager.Events.SaveEventItem(model);
				return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
			}
			return View(model);
		}

		[HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Events.DeleteEventItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

    }
}