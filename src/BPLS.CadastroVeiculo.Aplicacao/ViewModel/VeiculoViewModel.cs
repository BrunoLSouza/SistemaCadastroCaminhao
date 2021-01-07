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
        [Required(ErrorMessage = "Preencha o campo Modelo")]
        public long IdModelo { get; set; }
        public ModeloViewModel Modelo { get; set; }

        [DisplayName("Ano Fabricação")]
        [Required(ErrorMessage = "Preencha o campo Ano Fabricação")]
        public int AnoFabricacao { get; set; }

        [DisplayName("Ano Modelo")]
        [Required(ErrorMessage = "Preencha o campo Ano Modelo")]
        public int AnoModelo { get; set; }

        //[DisplayName("Tipo Veiculo")]
        // public long IdTipoVeiculo { get; set; }

        //public TipoVeiculoViewModel TipoVeiculo { get; set; }

    }
}
