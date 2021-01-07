using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BPLS.CadastroVeiculo.Aplicacao.ViewModel
{
    public class VeiculoViewModel
    {
        [Key]
        [DisplayName("Id")]
        public long IdVeiculo { get; set; }

        [DisplayName("Modelo")]
        public long IdModelo { get; set; }

        [DisplayName("Ano Fabricação")]
        public int AnoFabricacao { get; set; }

        [DisplayName("Ano Modelo")]
        public int AnoModelo { get; set; }

        [DisplayName("Tipo Veiculo")]
        public long IdTipoVeiculo { get; set; }

        public TipoVeiculoViewModel TipoVeiculo { get; set; }

        public ModeloViewModel Modelo { get; set; }
    }
}
