using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalCVC.Models;

namespace PortalCVC.Controllers
{
    public class TipoArquivoController : Controller
    {
        public readonly Contexto _db;

        public TipoArquivoController(Contexto contexto)
        {
            _db = contexto;
        }

        public IActionResult Index()
        {
            var tipoArquivo = _db.tb_tipoarquivo.ToList();
            return View(tipoArquivo);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(tb_tipoarquivo tipoarquivo)
        {
            _db.tb_tipoarquivo.Add(tipoarquivo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int id)
        {
            var tipo = _db.tb_tipoarquivo.FirstOrDefault(x => x.Id == id);
            return View(tipo);
        }
        [HttpPost]
        public IActionResult Editar(tb_tipoarquivo tipoarquivo)
        {
            var tipo = _db.tb_tipoarquivo.FirstOrDefault(x => x.Id == tipoarquivo.Id);
            tipo.Tipo = tipoarquivo.Tipo;
            _db.tb_tipoarquivo.Update(tipo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Remover(int id)
        {
            var tipo = _db.tb_tipoarquivo.FirstOrDefault(x => x.Id == id);
            _db.tb_tipoarquivo.Remove(tipo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}