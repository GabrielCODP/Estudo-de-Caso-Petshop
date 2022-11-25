using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class TelefoneModel : BaseModel
    {
        private string _telefone;
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        private Guid _pessoaId;
        public Guid PessoaId
        {
            get { return _pessoaId; }
            set { _pessoaId = value; }
        }
    }
}
