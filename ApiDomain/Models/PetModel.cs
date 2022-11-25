using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class PetModel
    {

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _idade;

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }


        private Guid _especieId;
        public Guid EspecieId
        {
            get { return _especieId; }
            set { _especieId = value; }
        }

        private Guid _racaId;
        public Guid RacaId
        {
            get { return _racaId; }
            set { _racaId = value; }
        }




    }
}
