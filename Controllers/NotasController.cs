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
            return View(listaNotas);
        }

        public IActionResult Inserir()
        {
            MongoDbContext dbContext = new MongoDbContext();
            Nota entity = new Nota();
            entity.Name = "teste";
            Teste t = new Teste();
            t.Name = "bla";
            entity.Valor = t;
            dbContext.Notas.InsertOne(entity);
            return Content("OK");
        }
    }
}