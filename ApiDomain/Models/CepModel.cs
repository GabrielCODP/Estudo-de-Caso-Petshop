using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class CepModel : BaseModel
    {
        private string _cep;
        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _logradouro;
        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        private string _numero;
        public string Numero
        {
            get { return _numero; }
            set
            {
                _numero = string.IsNullOrEmpty(value) ? "S/N" : value;
            }
        }

        private string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private string _complemento;
        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }


        private Guid _pessoaId;
        public Guid pessoaId
        {
            get { return _pessoaId; }
            set { _pessoaId = value; }
        }

        private Guid _municipioId;
        public Guid MunicipioId
        {
            get { return _municipioId; }
            set { _municipioId = value; }
        }


    }
}
