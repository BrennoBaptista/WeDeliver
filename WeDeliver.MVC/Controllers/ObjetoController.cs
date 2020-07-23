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
    public class ObjetoController : Controller
    {
        private readonly IObjetoServicoAplicacao _objetoServicoAplicacao;

        public ObjetoController(IObjetoServicoAplicacao objetoServicoAplicacao)
        {
            _objetoServicoAplicacao = objetoServicoAplicacao;
        }

        // GET: Objeto
        public ActionResult Index()
        {
            return View(_objetoServicoAplicacao.Listar());
        }

        // GET: Objeto/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_objetoServicoAplicacao.DetalharId(id));
        }

        // GET: Objeto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Objeto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ObjetoDTO objetoDTO)
        {
            try
            {
                try
                {
                    _objetoServicoAplicacao.Adicionar(objetoDTO);
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

        // GET: Objeto/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: Objeto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ObjetoDTO objetoDTO)
        {
            try
            {
                try
                {
                    _objetoServicoAplicacao.Atualizar(objetoDTO);
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

        // GET: Objeto/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: Objeto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ObjetoDTO objetoDTO)
        {
            try
            {
                try
                {
                    _objetoServicoAplicacao.Excluir(objetoDTO);
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