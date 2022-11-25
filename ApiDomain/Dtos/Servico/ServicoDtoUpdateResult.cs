using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Servico
{
    public class ServicoDtoUpdateResult
    {
        public Guid Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string Descricao { get; set; }
        public Guid ProdutoId { get; set; }
        public Guid ClienteId { get; set; }
        public Guid FuncionarioId { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
