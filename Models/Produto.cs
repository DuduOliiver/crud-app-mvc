using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]

        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]

        public string Imagem { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}
