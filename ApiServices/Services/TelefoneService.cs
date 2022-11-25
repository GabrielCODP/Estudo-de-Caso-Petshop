using ApiDomain.Dtos.Telefone;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Telefone;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class TelefoneService : ITelefoneService
    {
        private ITelefoneRepository _repository;
        private readonly IMapper _mapper;

        public TelefoneService(ITelefoneRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TelefoneDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<TelefoneDto>(entity);
        }

        public async Task<IEnumerable<TelefoneDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<TelefoneDto>>(listEntity);
        }

        public async Task<TelefoneDtoCreateResult> Post(TelefoneDtoCreate telefone)
        {
            var model = _mapper.Map<TelefoneModel>(telefone);
            var entity = _mapper.Map<TelefoneEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<TelefoneDtoCreateResult>(result);
        }

        public async Task<TelefoneDtpUpdateResult> Put(TelefoneDtoUpdate telefone)
        {
            var model = _mapper.Map<TelefoneModel>(telefone);
            var entity = _mapper.Map<TelefoneEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<TelefoneDtpUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
