using ApiDomain.Dtos.Pessoa;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.Pessoa;
using ApiDomain.Models;
using ApiDomain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class PessoaService : IPessoaService
    {
        private IPessoaRepository _repository;
        private readonly IMapper _mapper;

        public PessoaService(IPessoaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<PessoaDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<PessoaDto>>(listEntity);
        }

        public async Task<PessoaDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<PessoaDto>(entity);
        } 
        public async Task<PessoaDtoCreateResult> Post(PessoaDtoCreate pessoa)
        {
            var model = _mapper.Map<PessoaModel>(pessoa);
            var entity = _mapper.Map<PessoaEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<PessoaDtoCreateResult>(result);
        }

        public async Task<PessoaDtoUpdateResult> Put(PessoaDtoUpdate pessoa)
        {
            var model = _mapper.Map<PessoaModel>(pessoa);
            var entity = _mapper.Map<PessoaEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PessoaDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

    }
}
