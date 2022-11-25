using ApiDomain.Dtos.Produto;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Produto;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
   public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProdutoDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ProdutoDto>(entity);
        }


        public async Task<IEnumerable<ProdutoDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ProdutoDto>>(listEntity);
        }

        public async Task<ProdutoDtoCreateResult> Post(ProdutoDtoCreate produto)
        {
            var model = _mapper.Map<ProdutoModel>(produto);
            var entity = _mapper.Map<ProdutoEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ProdutoDtoCreateResult>(result);
        }

        public async Task<ProdutoDtoUpdateResult> Put(ProdutoDtoUpdate categoria)
        {
            var model = _mapper.Map<ProdutoModel>(categoria);
            var entity = _mapper.Map<ProdutoEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ProdutoDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
