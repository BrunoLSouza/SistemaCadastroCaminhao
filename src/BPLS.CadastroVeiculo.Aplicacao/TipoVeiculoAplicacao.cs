using BPLS.CadastroVeiculo.Aplicacao.ViewModel;
using BPLS.CadastroVeiculo.Data.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Aplicacao
{
    public class TipoVeiculoAplicacao
    {
        private readonly TipoVeiculoRepository _tipoVeiculoRepository;

        public TipoVeiculoAplicacao()
        {
            _tipoVeiculoRepository = new TipoVeiculoRepository();
        }

        public List<TipoVeiculoViewModel> ObterTodos()
        {
            var listaTiposVeiculo = _tipoVeiculoRepository.ObterTodos();
            var data = JsonConvert.SerializeObject(listaTiposVeiculo);
            var listaTiposVeiculoVM = JsonConvert.DeserializeObject<List<TipoVeiculoViewModel>>(data);

            return listaTiposVeiculoVM;
        }

    }
}
