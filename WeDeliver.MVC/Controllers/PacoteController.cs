using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Aplicacao.Interfaces;

namespace WeDeliver.MVC.Controllers
{
    public class PacoteController : Controller
    {
        private readonly IPacoteServicoAplicacao _pacoteServicoAplicacao;

        public PacoteController(IPacoteServicoAplicacao pacoteServicoAplicacao)
        {
            _pacoteServicoAplicacao = pacoteServicoAplicacao;
        }

        // GET: Pacote
        public ActionResult Index()
        {
            return View(_pacoteServicoAplicacao.Listar());
        }

        // GET: Pacote/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_pacoteServicoAplicacao.DetalharId(id));
        }

        // GET: Pacote/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacote/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PacoteDTO pacoteDTO)
        {
            try
            {
                try
                {
                    _pacoteServicoAplicacao.Adicionar(pacoteDTO);
                }
                catch (Exception e)
                {
                    throw e;
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pacote/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: Pacote/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PacoteDTO pacoteDTO)
        {
            try
            {
                try
                {
                    _pacoteServicoAplicacao.Atualizar(pacoteDTO);
                }
                catch (Exception e)
                {
                    throw e;
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pacote/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: Pacote/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PacoteDTO pacoteDTO)
        {
            try
            {
                try
                {
                    _pacoteServicoAplicacao.Excluir(pacoteDTO);
                }
                catch (Exception e)
                {
                    throw e;
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}