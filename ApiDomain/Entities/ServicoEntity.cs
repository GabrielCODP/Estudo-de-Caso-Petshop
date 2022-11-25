using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class ServicoEntity : BaseEntity
    {
        [Required]
        public DateTime DataEntrada { get; set; }
        [Required]
        public DateTime DataSaida { get; set; }

        [Required]
        [MaxLength(60)]
        public string Descricao { get; set; }

        public Guid ProdutoId { get; set; }
        public ProdutoEntity Produto { get; set; }


        public Guid ClienteId { get; set; }

        public ClienteEntity Cliente { get; set; }

        public Guid FuncionarioId { get; set; }
        public FuncionarioEntity Funcionario { get; set; }
    }
}
