using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class PagamentoModel : BaseModel
    {
        private bool _situacaoDoPagamento;

        public bool SituacaoDoPagamento
        {
            get { return _situacaoDoPagamento; }
            set { _situacaoDoPagamento = value; }
        }

        private Guid _servicoId;
        public Guid ServicoId
        {
            get { return _servicoId; }
            set { _servicoId = value; }
        }
    }
}
