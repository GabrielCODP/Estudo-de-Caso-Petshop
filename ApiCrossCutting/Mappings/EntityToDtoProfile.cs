using ApiDomain.Dtos.Categoria;
using ApiDomain.Dtos.Cep;
using ApiDomain.Dtos.Cliente;
using ApiDomain.Dtos.Especie;
using ApiDomain.Dtos.Funcionario;
using ApiDomain.Dtos.Municipio;
using ApiDomain.Dtos.Pagamento;
using ApiDomain.Dtos.Pessoa;
using ApiDomain.Dtos.Pet;
using ApiDomain.Dtos.Produto;
using ApiDomain.Dtos.Raca;
using ApiDomain.Dtos.Servico;
using ApiDomain.Dtos.Telefone;
using ApiDomain.Dtos.Uf;
using ApiDomain.Dtos.User;
using ApiDomain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>()
               .ReverseMap();

            CreateMap<UserDtoCreateResult, UserEntity>()
               .ReverseMap();

            CreateMap<UserDtoUpdateResult, UserEntity>()
               .ReverseMap();

            #region UF

            CreateMap<UfDto, UfEntity>()
               .ReverseMap();
            #endregion


            #region Municipio
            CreateMap<MunicipioDto, MunicipioEntity>()
               .ReverseMap();


            CreateMap<MunicipioDtoCompleto, MunicipioEntity>()
               .ReverseMap();

            CreateMap<MunicipioDtoCreateResult, MunicipioEntity>()
               .ReverseMap();

            CreateMap<MunicipioDtoUpdateResult, MunicipioEntity>()
               .ReverseMap();

            #endregion



            #region Cep
            CreateMap<CepDto, CepEntity>()
               .ReverseMap();

            CreateMap<CepDtoCreateResult, CepEntity>()
               .ReverseMap();

            CreateMap<CepDtoUpdateResult, CepEntity>()
               .ReverseMap();

            #endregion


            #region Pessoa
            CreateMap<PessoaDto, PessoaEntity>()
               .ReverseMap();

            CreateMap<PessoaDtoCreateResult, PessoaEntity>()
               .ReverseMap();

            CreateMap<PessoaDtoUpdateResult, PessoaEntity>()
               .ReverseMap();

            #endregion


            #region Telefone
            CreateMap<TelefoneDto, TelefoneEntity>()
               .ReverseMap();

            CreateMap<TelefoneDtoCreateResult, TelefoneEntity>()
               .ReverseMap();

            CreateMap<TelefoneDtpUpdateResult, TelefoneEntity>()
               .ReverseMap();

            #endregion

            #region Categoria
            CreateMap<CategoriaDto, CategoriaEntity>()
               .ReverseMap();

            CreateMap<CategoriaDtoCreateResult, CategoriaEntity>()
               .ReverseMap();

            CreateMap<CategoriaDtoUpdateResult, CategoriaEntity>()
               .ReverseMap();

            #endregion


            #region Produto
            CreateMap<ProdutoDto, ProdutoEntity>()
               .ReverseMap();

            CreateMap<ProdutoDtoCreateResult, ProdutoEntity>()
               .ReverseMap();

            CreateMap<ProdutoDtoUpdateResult, ProdutoEntity>()
               .ReverseMap();

            #endregion


            #region Raca
            CreateMap<RacaDto, RacaEntity>()
               .ReverseMap();

            CreateMap<RacaDtoCreateResult, RacaEntity>()
               .ReverseMap();

            CreateMap<RacaDtoUpdateResult, RacaEntity>()
               .ReverseMap();

            #endregion

            #region Especie
            CreateMap<EspecieDto, EspecieEntity>()
               .ReverseMap();

            CreateMap<EspecieDtoCreateResult, EspecieEntity>()
               .ReverseMap();

            CreateMap<EspecieDtoUpdateResult, EspecieEntity>()
               .ReverseMap();

            #endregion



            #region Pet
            CreateMap<PetDto, PetEntity>()
               .ReverseMap();

            CreateMap<PetDtoCreateResult, PetEntity>()
               .ReverseMap();

            CreateMap<PetDtoUpdateResult, PetEntity>()
               .ReverseMap();
            #endregion



            #region Servico
            CreateMap<ServicoDto, ServicoEntity>()
               .ReverseMap();

            CreateMap<ServicoDtoCreateResult, ServicoEntity>()
               .ReverseMap();

            CreateMap<ServicoDtoUpdateResult, ServicoEntity>()
               .ReverseMap();
            #endregion


            #region Pagamento
            CreateMap<PagamentoDto, PagamentoEntity>()
               .ReverseMap();

            CreateMap<PagamentoDtoCreateResult, PagamentoEntity>()
               .ReverseMap();

            CreateMap<PagamentoDtoUpdateResult, PagamentoEntity>()
               .ReverseMap();
            #endregion



            #region Cliente
            CreateMap<ClienteDto, ClienteEntity>()
               .ReverseMap();

            CreateMap<ClienteDtoCreateResult, ClienteEntity>()
               .ReverseMap();

            CreateMap<ClienteDtoUpdateResult, ClienteEntity>()
               .ReverseMap();
            #endregion


            #region Funcionario
            CreateMap<FuncionarioDto, FuncionarioEntity>()
               .ReverseMap();

            CreateMap<FuncionarioDtoCreateResult, FuncionarioEntity>()
               .ReverseMap();

            CreateMap<FuncionarioDtoUpdateResult, FuncionarioEntity>()
               .ReverseMap();
            #endregion
        }
    }
}