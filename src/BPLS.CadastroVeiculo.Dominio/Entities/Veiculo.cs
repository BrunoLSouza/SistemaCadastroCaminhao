using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPLS.CadastroVeiculo.Dominio.Entities
{
    public class Veiculo
    {
        public long IdVeiculo { get; set; }
        public long IdModelo { get; set; }
        public virtual Modelo Modelo { get; set; }

        public int AnoFabricacao { get; set; }        
        public int AnoModelo { get; set; }

        //public long IdTipoVeiculo { get; set; }
        //public virtual TipoVeiculo TipoVeiculo { get; set; }
    }
}
