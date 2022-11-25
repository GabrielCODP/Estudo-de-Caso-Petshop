using ApiDomain.Dtos.Pagamento;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Pagamento;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class PagamentoService : IPagamentoService
    {
        private IPagamentoRepository _repository;
        private readonly IMapper _mapper;

        public PagamentoService(IPagamentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PagamentoDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<PagamentoDto>(entity);
        }


        public async Task<IEnumerable<PagamentoDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<PagamentoDto>>(listEntity);
        }

        public async Task<PagamentoDtoCreateResult> Post(PagamentoDtoCreate especie)
        {
            var model = _mapper.Map<PagamentoModel>(especie);
            var entity = _mapper.Map<PagamentoEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<PagamentoDtoCreateResult>(result);
        }

        public async Task<PagamentoDtoUpdateResult> Put(PagamentoDtoUpdate categoria)
        {
            var model = _mapper.Map<PagamentoModel>(categoria);
            var entity = _mapper.Map<PagamentoEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<PagamentoDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
