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

            var anoFabricacao = DateTime.Now.Year;

            var listaAnoModelo = new[]
                        {
                            new SelectListItem { Value = anoFabricacao.ToString(), Text = anoFabricacao.ToString() },
                            new SelectListItem { Value = Convert.ToString(anoFabricacao + 1), Text = Convert.ToString(anoFabricacao + 1) },
                        };
            ViewBag.AnoModelo = listaAnoModelo;

            var veiculoVM = new VeiculoViewModel() {
                AnoFabricacao = anoFabricacao,
            };

            return View(veiculoVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Novo(VeiculoViewModel veiculoVM)
        {

            if (ModelState.IsValid)
            {
                if (veiculoVM.AnoFabricacao != DateTime.Now.Year)
                {
                    ModelState.AddModelError("AnoFabricacao", "Ano de Fabricação Inválido.");
                }
                else if (veiculoVM.AnoModelo < DateTime.Now.Year || veiculoVM.AnoModelo > (DateTime.Now.Year + 1))
                {
                    ModelState.AddModelError("AnoModelo", "Ano de Modelo Inválido.");
                }
                else if (veiculoVM.IdModelo == 0 || veiculoVM.IdModelo > 2)
                {
                    ModelState.AddModelError("IdModelo", "Modelo Inválido.");
                }
                else
                {
                    var retorno = _veiculoAplicacao.Salvar(veiculoVM);
                    return RedirectToAction("Index");
                }

            }

            var tipoVeiculoData = _tipoVeiculoAplicacao.ObterTodos().ToList();
            var tiposVeiculos = from TipoVeiculoViewModel d in tipoVeiculoData
                                select new SelectListItem { Value = d.IdTipoVeiculo.ToString(), Text = d.Descricao };
            ViewBag.TipoVeiculo = tiposVeiculos;

            var modeloData = _modeloAplicacao.ObterTodos().ToList();
            var modelos = from ModeloViewModel d in modeloData
                          select new SelectListItem { Value = d.IdModelo.ToString(), Text = d.Descricao };
            ViewBag.Modelo = modelos;

            var anoFabricacao = DateTime.Now.Year;

            var listaAnoModelo = new[]
                        {
                            new SelectListItem { Value = anoFabricacao.ToString(), Text = anoFabricacao.ToString() },
                            new SelectListItem { Value = Convert.ToString(anoFabricacao + 1), Text = Convert.ToString(anoFabricacao + 1) },
                        };
            ViewBag.AnoModelo = listaAnoModelo;

            return View(veiculoVM);
        }

        public ActionResult Editar(long? id)
        {

            var tipoVeiculoData = _tipoVeiculoAplicacao.ObterTodos().ToList();
            var tiposVeiculos = from TipoVeiculoViewModel d in tipoVeiculoData
                                select new SelectListItem { Value = d.IdTipoVeiculo.ToString(), Text = d.Descricao };
            ViewBag.TipoVeiculo = tiposVeiculos;

            var modeloData = _modeloAplicacao.ObterTodos().ToList();
            var modelos = from ModeloViewModel d in modeloData
                          select new SelectListItem { Value = d.IdModelo.ToString(), Text = d.Descricao };
            ViewBag.Modelo = modelos;

            var anoFabricacao = DateTime.Now.Year;

            var listaAnoModelo = new[]
                        {
                            new SelectListItem { Value = anoFabricacao.ToString(), Text = anoFabricacao.ToString() },
                            new SelectListItem { Value = Convert.ToString(anoFabricacao + 1), Text = Convert.ToString(anoFabricacao + 1) },
                        };
            ViewBag.AnoModelo = listaAnoModelo;

            if (id != null)
            {
                var veiculoViewModel = _veiculoAplicacao.ObterPorId(id.Value);
                return View(veiculoViewModel);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(VeiculoViewModel veiculoVM)
        {

            if (ModelState.IsValid)
            {
                var veiculoAtual = _veiculoAplicacao.ObterPorIdNoTrack(veiculoVM.IdVeiculo);

                if (veiculoVM.AnoFabricacao != DateTime.Now.Year && veiculoVM.AnoFabricacao != veiculoAtual.AnoFabricacao)
                {
                    ModelState.AddModelError("AnoFabricacao", "Ano de Fabricação Inválido.");
                }
                else if ((veiculoVM.AnoModelo < DateTime.Now.Year || veiculoVM.AnoModelo > (DateTime.Now.Year + 1)) && veiculoVM.AnoModelo != veiculoAtual.AnoModelo)
                {
                    ModelState.AddModelError("AnoModelo", "Ano de Modelo Inválido.");
                }
                else if ((veiculoVM.IdModelo == 0 || veiculoVM.IdModelo > 2) && veiculoVM.IdModelo != veiculoAtual.IdModelo)
                {
                    ModelState.AddModelError("IdModelo", "Modelo Inválido.");
                }
                else
                {
                    var retorno = _veiculoAplicacao.Atualizar(veiculoVM);
                    return RedirectToAction("Index");
                }

            }

            var tipoVeiculoData = _tipoVeiculoAplicacao.ObterTodos().ToList();
            var tiposVeiculos = from TipoVeiculoViewModel d in tipoVeiculoData
                                select new SelectListItem { Value = d.IdTipoVeiculo.ToString(), Text = d.Descricao };
            ViewBag.TipoVeiculo = tiposVeiculos;

            var modeloData = _modeloAplicacao.ObterTodos().ToList();
            var modelos = from ModeloViewModel d in modeloData
                          select new SelectListItem { Value = d.IdModelo.ToString(), Text = d.Descricao };
            ViewBag.Modelo = modelos;

            var anoFabricacao = DateTime.Now.Year;

            var listaAnoModelo = new[]
                        {
                            new SelectListItem { Value = anoFabricacao.ToString(), Text = anoFabricacao.ToString() },
                            new SelectListItem { Value = Convert.ToString(anoFabricacao + 1), Text = Convert.ToString(anoFabricacao + 1) },
                        };
            ViewBag.AnoModelo = listaAnoModelo;

            return View(veiculoVM);
        }

        public ActionResult Deletar(long? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var veiculoViewModel = _veiculoAplicacao.ObterPorIdNoTrack(id.Value);

            if (veiculoViewModel == null)
            {
                return RedirectToAction("Index");
            }
            return View(veiculoViewModel);
        }

        // POST: Imovel/Delete/5
        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarConfirma(long id)
        {
            _veiculoAplicacao.Remover(id);
            return RedirectToAction("Index");
        }
    }
}
