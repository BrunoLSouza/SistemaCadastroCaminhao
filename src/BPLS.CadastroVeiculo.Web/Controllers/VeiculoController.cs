using BPLS.CadastroVeiculo.Aplicacao;
using BPLS.CadastroVeiculo.Aplicacao.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPLS.CadastroVeiculo.Web.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly VeiculoAplicacao _veiculoAplicacao;
        private readonly TipoVeiculoAplicacao _tipoVeiculoAplicacao;
        private readonly ModeloAplicacao _modeloAplicacao;

        public VeiculoController()
        {
            _veiculoAplicacao = new VeiculoAplicacao();
            _modeloAplicacao = new ModeloAplicacao();
            _tipoVeiculoAplicacao = new TipoVeiculoAplicacao();
        }

        public IActionResult Index()
        {
            return View(_veiculoAplicacao.ObterTodos());
        }
        
        public IActionResult Novo()
        {
            var tipoVeiculoData = _tipoVeiculoAplicacao.ObterTodos().ToList();
            var tiposVeiculos = from TipoVeiculoViewModel d in tipoVeiculoData
                          select new SelectListItem { Value = d.IdTipoVeiculo.ToString(), Text = d.Descricao };
            ViewBag.TipoVeiculo = tiposVeiculos;

            var modeloData = _modeloAplicacao.ObterTodos().ToList();
            var modelos = from ModeloViewModel d in modeloData
                          select new SelectListItem { Value = d.IdModelo.ToString(), Text = d. Descricao };
            ViewBag.Modelo = modelos;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Novo(VeiculoViewModel veiculoVM)
        {
            return View();
        }
    }
}
