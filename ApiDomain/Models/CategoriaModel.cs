using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class CategoriaModel : BaseModel
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

    }
}
