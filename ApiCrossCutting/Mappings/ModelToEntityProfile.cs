using ApiDomain.Entities;
using ApiDomain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserModel, UserEntity>()
               .ReverseMap();

            CreateMap<UfModel, UfEntity>()
               .ReverseMap();

            CreateMap<MunicipioModel, MunicipioEntity>()
               .ReverseMap();

            CreateMap<CepModel, CepEntity>()
               .ReverseMap();

            CreateMap<PessoaModel, PessoaEntity>()
            .ReverseMap();

            CreateMap<TelefoneModel, TelefoneEntity>()
          .ReverseMap();



            CreateMap<CategoriaModel, CategoriaEntity>()
        .ReverseMap();


            CreateMap<ProdutoModel, ProdutoEntity>().ReverseMap();


            CreateMap<RacaModel, RacaEntity>()
     .ReverseMap();

            CreateMap<EspecieModel, EspecieEntity>()
     .ReverseMap();


            CreateMap<PetModel, PetEntity>()
  .ReverseMap();

            CreateMap<ServicoModel, ServicoEntity>()
.ReverseMap();

            CreateMap<PagamentoModel, PagamentoEntity>()
.ReverseMap();

            CreateMap<ClienteModel, ClienteEntity>()
.ReverseMap();

            CreateMap<FuncionarioModel, FuncionarioEntity>()
.ReverseMap();
        }
    }
}
