using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Dominio.Entities
{
    public class Modelo
    {
        public long IdModelo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}
