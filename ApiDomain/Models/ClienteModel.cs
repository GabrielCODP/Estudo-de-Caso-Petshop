using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class ClienteModel : BaseModel
    {
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private Guid _pessoaId;
        public Guid pessoaId
        {
            get { return _pessoaId; }
            set { _pessoaId = value; }
        }

    }
}
