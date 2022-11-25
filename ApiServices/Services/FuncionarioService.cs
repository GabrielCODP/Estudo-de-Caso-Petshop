using ApiDomain.Dtos.Funcionario;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Funcao;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private IFuncionarioRepository _repository;
        private readonly IMapper _mapper;

        public FuncionarioService(IFuncionarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<FuncionarioDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<FuncionarioDto>>(listEntity);
        }
        public async Task<FuncionarioDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<FuncionarioDto>(entity);
        }

        public async Task<FuncionarioDtoCreateResult> Post(FuncionarioDtoCreate cep)
        {
            var model = _mapper.Map<FuncionarioModel>(cep);
            var entity = _mapper.Map<FuncionarioEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<FuncionarioDtoCreateResult>(result);
        }

        public async Task<FuncionarioDtoUpdateResult> Put(FuncionarioDtoUpdate cep)
        {
            var model = _mapper.Map<FuncionarioModel>(cep);
            var entity = _mapper.Map<FuncionarioEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<FuncionarioDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}