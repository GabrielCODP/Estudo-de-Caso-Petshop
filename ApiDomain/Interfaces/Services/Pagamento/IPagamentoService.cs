using ApiDomain.Dtos.Pagamento;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Pagamento
{
    public interface IPagamentoService
    {
        Task<PagamentoDto> Get(Guid id);

        Task<IEnumerable<PagamentoDto>> GetAll();

        Task<PagamentoDtoCreateResult> Post(PagamentoDtoCreate pessoas);
        Task<PagamentoDtoUpdateResult> Put(PagamentoDtoUpdate Pessoa);
        Task<bool> Delete(Guid id);
    }
}
