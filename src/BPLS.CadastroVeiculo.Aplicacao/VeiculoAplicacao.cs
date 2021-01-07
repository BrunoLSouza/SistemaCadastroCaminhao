using BPLS.CadastroVeiculo.Aplicacao.ViewModel;
using BPLS.CadastroVeiculo.Data.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BPLS.CadastroVeiculo.Aplicacao
{
    public class VeiculoAplicacao
    {
        private readonly VeiculoRepository _veiculoRepository;

        public VeiculoAplicacao()
        {
            _veiculoRepository = new VeiculoRepository();
        }

        public List<VeiculoViewModel> ObterTodos()
        {
            var listaVeiculos = _veiculoRepository.ObterTodos();
            var data = JsonConvert.SerializeObject(listaVeiculos);
            var listaVeiculosVM = JsonConvert.DeserializeObject<List<VeiculoViewModel>>(data);

            return listaVeiculosVM;
        }

    }
}
