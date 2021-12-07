﻿using ProvaModel.Context;
using ProvaModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProvaModel.Controllers
{
    public class ProdutoController : Controller
    {
        private EFContext context = new EFContext();
        public ActionResult Index()
        {
            return View();
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produtos = context.Produtos.Find(id);
            if (produtos == null)
            {
                return HttpNotFound();
            }
            return View(produtos);
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Produto produto = context.Produtos.Find(id);
                context.Produtos.Remove(produto);
                context.SaveChanges();
                TempData["Message"] = "Produto" + produto.Nome.ToUpper() + "foi removida";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}


