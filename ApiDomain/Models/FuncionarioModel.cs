using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class FuncionarioModel : BaseModel
    {
        private string _funcao;

        public string Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }

        private Guid _pessoaId;
        public Guid pessoaId
        {
            get { return _pessoaId; }
            set { _pessoaId = value; }
        }

    }
}
