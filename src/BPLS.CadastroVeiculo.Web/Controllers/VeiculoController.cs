using BPLS.CadastroVeiculo.Aplicacao;
using BPLS.CadastroVeiculo.Aplicacao.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPLS.CadastroVeiculo.Web.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly VeiculoAplicacao _veiculoAplicacao;

        public VeiculoController()
        {
            _veiculoAplicacao = new VeiculoAplicacao();
        }

        public IActionResult Index()
        {
            return View(_veiculoAplicacao.ObterTodos());
        }
        
        public IActionResult Novo()
        {
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
