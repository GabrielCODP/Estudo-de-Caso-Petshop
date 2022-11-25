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
using ApiDomain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User
            CreateMap<UserModel, UserDto>()
                .ReverseMap();
            CreateMap<UserModel, UserDtoCreate>()
                .ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>()
                .ReverseMap();
            #endregion

            #region UF
            CreateMap<UfModel, UfDto>()
                .ReverseMap();
            #endregion

            #region Municipio
            CreateMap<MunicipioModel, MunicipioDto>()
                .ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoCreate>()
                .ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoUpdate>()
                .ReverseMap();
            #endregion

            #region CEP
            CreateMap<CepModel, CepDto>()
                .ReverseMap();
            CreateMap<CepModel, CepDtoCreate>()
                .ReverseMap();
            CreateMap<CepModel, CepDtoUpdate>()
                .ReverseMap();
            #endregion


            #region Pessoa
            CreateMap<PessoaModel, PessoaDto>()
                .ReverseMap();
            CreateMap<PessoaModel, PessoaDtoCreate>()
                .ReverseMap();
            CreateMap<PessoaModel, PessoaDtoUpdate>()
                .ReverseMap();
            #endregion


            #region Telefone
            CreateMap<TelefoneModel, TelefoneDto>()
                .ReverseMap();
            CreateMap<TelefoneModel, TelefoneDtoCreate>()
                .ReverseMap();
            CreateMap<TelefoneModel, TelefoneDtoUpdate>()
                .ReverseMap();
            #endregion


            #region Categoria
            CreateMap<CategoriaModel, CategoriaDto>()
                .ReverseMap();
            CreateMap<CategoriaModel, CategoriaDtoCreate>()
                .ReverseMap();
            CreateMap<CategoriaModel, CategoriaDtoUpdate>()
                .ReverseMap();
            #endregion

            #region Produto
            CreateMap<ProdutoModel, ProdutoDto>()
                .ReverseMap();
            CreateMap<ProdutoModel, ProdutoDtoCreate>()
                .ReverseMap();
            CreateMap<ProdutoModel, ProdutoDtoUpdate>()
                .ReverseMap();
            #endregion

            #region Raca
            CreateMap<RacaModel, RacaDto>()
                .ReverseMap();
            CreateMap<RacaModel, RacaDtoCreate>()
                .ReverseMap();
            CreateMap<RacaModel, RacaDtoUpdate>()
                .ReverseMap();
            #endregion


            #region Especie
            CreateMap<EspecieModel, EspecieDto>()
                .ReverseMap();
            CreateMap<EspecieModel, EspecieDtoCreate>()
                .ReverseMap();
            CreateMap<EspecieModel, EspecieDtoUpdate>()
                .ReverseMap();
            #endregion



            #region Pet
            CreateMap<PetModel,PetDto>()
                .ReverseMap();
            CreateMap<PetModel, PetDtoCreate>()
                .ReverseMap();
            CreateMap<PetModel, PetDtoUpdate>()
                .ReverseMap();
            #endregion


            #region Servico
            CreateMap<ServicoModel, ServicoDto>()
                .ReverseMap();
            CreateMap<ServicoModel, ServicoDtoCreate>()
                .ReverseMap();
            CreateMap<ServicoModel, ServicoDtoUpdate>()
                .ReverseMap();
            #endregion


            #region Pagamento
            CreateMap<PagamentoModel, PagamentoDto>()
                .ReverseMap();
            CreateMap<PagamentoModel, PagamentoDtoCreate>()
                .ReverseMap();
            CreateMap<PagamentoModel, PagamentoDtoUpdate>()
                .ReverseMap();
            #endregion



            #region Cliente
            CreateMap<ClienteModel, ClienteDto>()
                .ReverseMap();
            CreateMap<ClienteModel, ClienteDtoCreate>()
                .ReverseMap();
            CreateMap<ClienteModel, ClienteDtoUpdate>()
                .ReverseMap();
            #endregion


            #region Funcionario
            CreateMap<FuncionarioModel, FuncionarioDto>()
                .ReverseMap();
            CreateMap<FuncionarioModel, FuncionarioDtoCreate>()
                .ReverseMap();
            CreateMap<FuncionarioModel, FuncionarioDtoUpdate>()
                .ReverseMap();
            #endregion



        }
    }
}
