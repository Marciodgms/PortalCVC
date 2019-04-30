using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalCVC.Models;

namespace PortalCVC.Controllers
{
    public class EmpreendimentoController : Controller
    {
        private readonly Contexto _db;

        public EmpreendimentoController(Contexto Db)
        {
            _db = Db;
        }

        public IActionResult Index()
        {
            ViewBag.Empreendimentos = _db.tb_empreendimento
                    .Join(_db.tb_empresa,
                    empd => empd.EmpresaFK,
                    empre => empre.Id,
                    (empd, empre) => new { empd, empre }).Select(x => x.empd);
            return View();
        }
        public IActionResult Editar(int id)
        {
            var empreendimento = _db.tb_empreendimento
                    .Join(_db.tb_empresa,
                    empd => empd.EmpresaFK,
                    empre => empre.Id,
                    (empd, empre) => new { empd, empre }).Select(x => x.empd)
                    .Where(x => x.Id == id);
            return View(empreendimento);
        }
        public IActionResult Cadastrar()
        {
            ViewBag.lstEmpresa = _db.tb_empresa.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(tb_empreendimento empreendimento)
        {
            _db.tb_empreendimento.Add(empreendimento);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}