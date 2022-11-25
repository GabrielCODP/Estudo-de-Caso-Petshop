using ApiDomain.Dtos.Servico;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Servico
{
    public interface IServicoService
    {

        Task<ServicoDto> Get(Guid id);
        Task<IEnumerable<ServicoDto>> GetAll();
        Task<ServicoDtoCreateResult> Post(ServicoDtoCreate servico);
        Task<ServicoDtoUpdateResult> Put(ServicoDtoUpdate servico);
        Task<bool> Delete(Guid id);
    }
}
