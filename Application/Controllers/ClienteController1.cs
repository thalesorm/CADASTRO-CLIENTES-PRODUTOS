using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers
{
    public class ClienteController1 : Controller
    {
        private IClienteService _ClienteService;

        public ClienteController1(IClienteService clienteService)
        {
            _ClienteService = clienteService;
        }

        public ActionResult Index()
        {
            var clientes = _ClienteService.GetAll();
            return View(clientes);
        }
        public ActionResult Details(int id)
        {
            var viewModel = _ClienteService.Get(id);
            return View(viewModel);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel viewModel)
        {
            viewModel.DataCadastro = DateTime.Now;
            try
            {

                if (ModelState.IsValid)
                {
                    _ClienteService.Insert(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = _ClienteService.Get(id);
            return View(viewModel);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClienteViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _ClienteService.Update(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            var viewModel = _ClienteService.Get(id);
            return View(viewModel);
        }

        // POST: Clients/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _ClienteService.Delete(id);

                    return RedirectToAction(nameof(Index));
                }

                var viewModel = _ClienteService.Get(id);
                return View(viewModel);
            }
            catch
            {
                var viewModel = _ClienteService.Get(id);
                return View(viewModel);
            }
        }
    }
}
