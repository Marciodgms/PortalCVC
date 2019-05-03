using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalCVC.Models;
using PortalCVC.ViewModel;

namespace PortalCVC.Controllers
{
    public class ArquivoController : Controller
    {
        private readonly Contexto _contexto;
        public ArquivoController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            var arquivosJoin = from arquivo in _contexto.tb_arquivo
                               join empreendimento in _contexto.tb_empreendimento
                               on arquivo.EmpreendimentoFK equals empreendimento.Id
                               join tipo in _contexto.tb_tipoarquivo
                               on arquivo.TipoArquivoFK equals tipo.Id
                               select new ArquivoViewModel
                               {
                                   Id = arquivo.Id,
                                   Empreendimento = empreendimento.Nome,
                                   Nome = arquivo.Nome,
                                   SRC = arquivo.SRC,
                                   FileName = arquivo.FileName,
                                   TipoDoArquivo = tipo.Tipo
                               };
            return View(arquivosJoin);
        }
        public IActionResult Cadastrar()
        {
            ViewBag.lstEmpreendimentos = _contexto.tb_empreendimento.ToList();
            ViewBag.lstTipos = _contexto.tb_tipoarquivo.ToList();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cadastrar(tb_arquivo arquivo)
        {
            if (arquivo.files != null && arquivo.files.Count != 0)
            {
                foreach (var file in arquivo.files)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "arquivos", file.FileName);
                    using (var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    var ARQUIVO = new tb_arquivo()
                    {
                        FileName = file.FileName,
                        SRC = path,
                        EmpreendimentoFK = arquivo.EmpreendimentoFK,
                        Nome = arquivo.Nome,
                        TipoArquivoFK = arquivo.TipoArquivoFK
                    };
                    _contexto.tb_arquivo.Add(ARQUIVO);
                    _contexto.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult Remover()
        {
            return View();
        }
    }
}