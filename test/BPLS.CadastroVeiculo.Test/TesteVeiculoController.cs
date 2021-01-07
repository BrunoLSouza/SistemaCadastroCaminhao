using BPLS.CadastroVeiculo.Aplicacao.ViewModel;
using BPLS.CadastroVeiculo.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace BPLS.CadastroVeiculo.Test
{
    public class TesteVeiculoController
    {
        [Fact]
        public void TesteIndex()
        {
            var controller = new VeiculoController();
            var result = controller.Index() as ViewResult;

            Assert.NotNull(result);

        }

        [Fact]
        public void TesteNovo()
        {
            var controller = new VeiculoController();
            var result = controller.Novo() as ViewResult;

            Assert.NotNull(result);

        }

        [Fact]
        public void TesteEditar()
        {
            long? id = null;
            var controller = new VeiculoController();
            var result = controller.Editar(id) as ViewResult;

            Assert.Null(result);

        }

        [Fact]
        public void TesteDeletar()
        {
            var controller = new VeiculoController();
            var result = controller.Deletar(null) as ViewResult;

            Assert.Null(result);

        }
    }
}
