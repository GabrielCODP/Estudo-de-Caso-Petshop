using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class ProdutoModel : BaseModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private double _preco;
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        private Guid _categoriaId;
        public Guid CategoriaId
        {
            get { return _categoriaId; }
            set { _categoriaId = value; }
        }
    }
}
