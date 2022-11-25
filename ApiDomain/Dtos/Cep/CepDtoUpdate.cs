using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Cep
{
    public class CepDtoUpdate
    {

        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "CEP é campo obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Logradouro é campo obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Numero é campo obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Bairro é campo obrigatório")]

        public string Bairro { get; set; }

        [Required(ErrorMessage = "Complemento é campo obrigatório")]
        public string Complemento { get; set; }

        public Guid PessoaId { get; set; }

        [Required(ErrorMessage = "Municipio é campo obrigatório")]
        public Guid MunicipioId { get; set; }

    }
}