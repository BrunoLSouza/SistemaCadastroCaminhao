using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BPLS.CadastroVeiculo.Dominio.Entities
{ 
    public class TipoVeiculo
    {
        public long IdTipoVeiculo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }

    }
}
