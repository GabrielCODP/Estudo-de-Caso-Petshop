using ApiDomain.Dtos.Pet;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Pet;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class PetService : IPetService
    {
        private IPetRepository _repository;
        private readonly IMapper _mapper;

        public PetService(IPetRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PetDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<PetDto>(entity);
        }


        public async Task<IEnumerable<PetDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<PetDto>>(listEntity);
        }

        public async Task<PetDtoCreateResult> Post(PetDtoCreate categoria)
        {
            var model = _mapper.Map<PetModel>(categoria);
            var entity = _mapper.Map<PetEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<PetDtoCreateResult>(result);
        }

        public async Task<PetDtoUpdateResult> Put(PetDtoUpdate categoria)
        {
            var model = _mapper.Map<PetModel>(categoria);
            var entity = _mapper.Map<PetEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<PetDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
