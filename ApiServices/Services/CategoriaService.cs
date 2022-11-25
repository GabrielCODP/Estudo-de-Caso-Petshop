using ApiDomain.Dtos.Categoria;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Categoria;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
   public class CategoriaService : ICategoriaService
    {
        private ICategoriaRepository _repository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoriaDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<CategoriaDto>(entity);
        }


        public async Task<IEnumerable<CategoriaDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<CategoriaDto>>(listEntity);
        }

        public async Task<CategoriaDtoCreateResult> Post(CategoriaDtoCreate categoria)
        {
            var model = _mapper.Map<CategoriaModel>(categoria);
            var entity = _mapper.Map<CategoriaEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<CategoriaDtoCreateResult>(result);
        }

        public async Task<CategoriaDtoUpdateResult> Put(CategoriaDtoUpdate categoria)
        {
            var model = _mapper.Map<CategoriaModel>(categoria);
            var entity = _mapper.Map<CategoriaEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<CategoriaDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
