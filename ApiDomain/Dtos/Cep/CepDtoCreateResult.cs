using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Cep
{
    public class CepDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public Guid PessoaId { get; set; }
        public Guid MunicipioId { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
