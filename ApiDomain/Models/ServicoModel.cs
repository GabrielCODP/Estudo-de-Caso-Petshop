using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class ServicoModel : BaseModel
    {
        private DateTime _dataEntrada;

        public DateTime DataEntrada
        {
            get { return _dataEntrada; }
            set
            {
                _dataEntrada = value == null ? DateTime.UtcNow : value;
            }
        }



        private DateTime _dataSaida;

        public DateTime DataSaida
        {
            get { return _dataSaida; }
            set
            {
                _dataSaida = value == null ? DateTime.UtcNow : value;
            }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }


        private Guid _produtoId;

        public Guid ProdutoId
        {
            get { return _produtoId; }
            set { _produtoId = value; }
        }

        private Guid _clienteId;

        public Guid ClienteId
        {
            get { return _clienteId; }
            set { _clienteId = value; }
        }

        private Guid _funcionarioId;

        public Guid FuncionarioId
        {
            get { return _funcionarioId; }
            set { _funcionarioId = value; }
        }



    }
}
