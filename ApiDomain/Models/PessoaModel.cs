using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class PessoaModel : BaseModel
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private DateTime _nasicmento;

        public DateTime Nascimento
        {
            get { return _nasicmento; }
            set
            {
                _nasicmento = value == null ? DateTime.UtcNow : value;
            }
        }

    }
}
