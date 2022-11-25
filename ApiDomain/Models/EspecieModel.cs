using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class EspecieModel : BaseModel
    {
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

    }
}