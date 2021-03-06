﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Aplicacao.Interfaces;

namespace WeDeliver.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteServicoAplicacao _clienteServicoAplicacao;

        public ClienteController(IClienteServicoAplicacao clienteServicoAplicacao)
        {
            _clienteServicoAplicacao = clienteServicoAplicacao;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            return View(_clienteServicoAplicacao.Listar());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_clienteServicoAplicacao.DetalharId(id));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteDTO clienteDTO)
        {
            try
            {
                try
                {
                    _clienteServicoAplicacao.Adicionar(clienteDTO);
                }
                catch(Exception e)
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

        // GET: Cliente/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteDTO clienteDTO)
        {
            try
            {
                try
                {
                    _clienteServicoAplicacao.Atualizar(clienteDTO);
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClienteDTO clienteDTO)
        {
            try
            {
                try
                {
                    _clienteServicoAplicacao.Excluir(clienteDTO);
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