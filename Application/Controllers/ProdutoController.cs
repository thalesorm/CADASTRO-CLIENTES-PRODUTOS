using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Interface;
using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers
{
    public class ProdutoController1 : Controller
    {
        private IProdutoService _ProdutoService;
        private IClienteService _ClienteService;

        public ProdutoController1(IProdutoService produtoService, IClienteService clienteService)
        {
            _ProdutoService = produtoService;
            _ClienteService = clienteService;
        }

        public ActionResult Index()
        {
            var produto = _ProdutoService.GetAll();
            return View(produto);
        }
        public ActionResult Details(int id)
        {
            var viewModel = _ProdutoService.Get(id);
            return View(viewModel);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            FillClienteSelect();
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel viewModel)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _ProdutoService.Insert(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                FillClienteSelect();
                return View(viewModel);
            }
            catch
            {
                FillClienteSelect();
                return View(viewModel);
            }
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = _ProdutoService.Get(id);
            FillClienteSelect(viewModel.ClienteId);
            return View(viewModel);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProdutoViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _ProdutoService.Update(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                FillClienteSelect(viewModel.ClienteId);
                return View(viewModel);
            }
            catch
            {
                FillClienteSelect(viewModel.ClienteId);
                return View(viewModel);
            }
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            var viewModel = _ProdutoService.Get(id);
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
                    _ProdutoService.Delete(id);

                    return RedirectToAction(nameof(Index));
                }

                var viewModel = _ProdutoService.Get(id);
                return View(viewModel);
            }
            catch
            {
                var viewModel = _ProdutoService.Get(id);
                return View(viewModel);
            }
        }
        private void FillClienteSelect()
        {
            FillClienteSelect(-1);
        }

        private void FillClienteSelect(int id)
        {
            ViewBag.ClienteId = new SelectList
              (
                  _ClienteService.GetAll(),
                  "IdCliente",
                  "Name",
                  id
              );
        }
    }
}
