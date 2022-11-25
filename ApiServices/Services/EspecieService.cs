using ApiDomain.Dtos.Especie;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Especie;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class EspecieService : IEspecieService
    {
        private IEspecieRepository _repository;
        private readonly IMapper _mapper;

        public EspecieService(IEspecieRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EspecieDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<EspecieDto>(entity);
        }


        public async Task<IEnumerable<EspecieDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<EspecieDto>>(listEntity);
        }

        public async Task<EspecieDtoCreateResult> Post(EspecieDtoCreate especie)
        {
            var model = _mapper.Map<EspecieModel>(especie);
            var entity = _mapper.Map<EspecieEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<EspecieDtoCreateResult>(result);
        }

        public async Task<EspecieDtoUpdateResult> Put(EspecieDtoUpdate categoria)
        {
            var model = _mapper.Map<EspecieModel>(categoria);
            var entity = _mapper.Map<EspecieEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<EspecieDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
