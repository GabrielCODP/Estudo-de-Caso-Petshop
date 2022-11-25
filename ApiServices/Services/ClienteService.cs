using ApiDomain.Dtos.Cliente;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Cliente;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ClienteDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ClienteDto>>(listEntity);
        }
        public async Task<ClienteDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ClienteDto>(entity);
        }

        public async Task<ClienteDtoCreateResult> Post(ClienteDtoCreate cep)
        {
            var model = _mapper.Map<ClienteModel>(cep);
            var entity = _mapper.Map<ClienteEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ClienteDtoCreateResult>(result);
        }

        public async Task<ClienteDtoUpdateResult> Put(ClienteDtoUpdate cep)
        {
            var model = _mapper.Map<ClienteModel>(cep);
            var entity = _mapper.Map<ClienteEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<ClienteDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}