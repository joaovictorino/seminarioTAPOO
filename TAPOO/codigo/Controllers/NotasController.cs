using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using MongoDB.Driver;

namespace Controllers
{
    public class NotasController : Controller
    {
        private string connectionString = "mongodb://mongoteste:27017";
        public IActionResult Index()
        {
            var client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("Teste");
            var collection = db.GetCollection<Nota>("Notas");
            var listaNotas = collection.FindSync(FilterDefinition<Nota>.Empty).ToList();
            return Json(listaNotas);
        }

        public IActionResult Inserir(string name)
        {
            var client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("Teste");
            var collection = db.GetCollection<Nota>("Notas");
            var nota = new Nota(){ Name = name };
            collection.InsertOne(nota);
            return Json("Inserido");
        }
    }
}