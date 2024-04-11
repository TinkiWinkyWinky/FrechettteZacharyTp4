using FrechettteZacharyTp4.Data;
using FrechettteZacharyTp4.Services;
using FrechettteZacharyTp4.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;

namespace FrechettteZacharyTp4.Controllers
{
    public class ClientsController(ApplicationDbContext context, ClientsService clientsService) : Controller
    {
        private readonly ApplicationDbContext _context = context;
        private readonly ClientsService _clientsService = clientsService;

        public IActionResult Index()
        {
            var viewModel = new IndexVM
            {
                clientsInfoVMList = _clientsService.GetAll(),
                clientsCreateVM = _clientsService.CreateForm()
            };
            
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var isDeleted = _clientsService.Remove(id);

            if (!isDeleted)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClientsCreateVM vm)
        {
            if (ModelState.IsValid)
            {
                _clientsService.Add(vm);

                return RedirectToAction(nameof(Index));
            }
            /*string messages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
            Console.WriteLine(messages);*/
            return null;
        }
    }
}
