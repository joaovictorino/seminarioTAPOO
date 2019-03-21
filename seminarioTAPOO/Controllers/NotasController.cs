using Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class NotasController : Controller
    {
        public IActionResult Index()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Nota> listaNotas = dbContext.Notas.Find(m => true).ToList();
            var model = new NotaModel();
            model.Notas = listaNotas;
            return View(model);
        }
    }
}