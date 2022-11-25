using ApiDomain.Dtos.Servico;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Servico;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class ServicoService : IServicoService
    {
        private IServicoRepository _repository;
        private readonly IMapper _mapper;

        public ServicoService(IServicoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ServicoDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ServicoDto>(entity);
        }

       
        public async Task<IEnumerable<ServicoDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ServicoDto>>(listEntity);
        }

        public async Task<ServicoDtoCreateResult> Post(ServicoDtoCreate servico)
        {
            var model = _mapper.Map<ServicoModel>(servico);

            var entity = _mapper.Map<ServicoEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ServicoDtoCreateResult>(result);
        }

        public async Task<ServicoDtoUpdateResult> Put(ServicoDtoUpdate municipio)
        {
            var model = _mapper.Map<ServicoModel>(municipio);
            var entity = _mapper.Map<ServicoEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ServicoDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
