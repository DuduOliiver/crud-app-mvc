using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string  Logradouro { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string  Numero { get; set; }

        public string  Complemento { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "Campo {0} precisa ter entre {1}", MinimumLength = 8)]
        public string  Cep { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string  Bairro { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string  Cidade { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string  Estado { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}
