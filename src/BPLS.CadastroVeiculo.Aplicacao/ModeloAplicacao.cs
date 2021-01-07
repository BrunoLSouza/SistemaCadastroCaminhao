using BPLS.CadastroVeiculo.Aplicacao.ViewModel;
using BPLS.CadastroVeiculo.Data.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Aplicacao
{
    public class ModeloAplicacao
    {
        private readonly ModeloRepository _modeloRepository;

        public ModeloAplicacao()
        {
            _modeloRepository = new ModeloRepository();
        }

        public List<ModeloViewModel> ObterTodos()
        {
            var listaModelos = _modeloRepository.ObterTodos();
            var data = JsonConvert.SerializeObject(listaModelos);
            var listaModelosVM = JsonConvert.DeserializeObject<List<ModeloViewModel>>(data);

            return listaModelosVM;
        }

    }
}
