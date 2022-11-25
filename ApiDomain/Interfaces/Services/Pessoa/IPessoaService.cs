using ApiDomain.Dtos.Pessoa;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Pessoa
{
    public interface IPessoaService
    {
        Task<PessoaDto> Get(Guid id);

        Task<IEnumerable<PessoaDto>> GetAll();

        Task<PessoaDtoCreateResult> Post(PessoaDtoCreate pessoas);
        Task<PessoaDtoUpdateResult> Put(PessoaDtoUpdate Pessoa);
        Task<bool> Delete(Guid id);
    }
}
