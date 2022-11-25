using ApiDomain.Dtos.Raca;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Raca;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class RacaService : IRacaService
    {
        private IRacaRepository _repository;
        private readonly IMapper _mapper;

        public RacaService(IRacaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<RacaDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<RacaDto>(entity);
        }


        public async Task<IEnumerable<RacaDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<RacaDto>>(listEntity);
        }

        public async Task<RacaDtoCreateResult> Post(RacaDtoCreate especie)
        {
            var model = _mapper.Map<RacaModel>(especie);

            var entity = _mapper.Map<RacaEntity>(model);

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<RacaDtoCreateResult>(result);
        }

        public async Task<RacaDtoUpdateResult> Put(RacaDtoUpdate categoria)
        {
            var model = _mapper.Map<RacaModel>(categoria);
            var entity = _mapper.Map<RacaEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<RacaDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
