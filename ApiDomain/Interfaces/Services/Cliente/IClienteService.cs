using ApiDomain.Dtos.Cliente;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Cliente
{
    public interface IClienteService
    {
        Task<ClienteDto> Get(Guid id);
        Task<IEnumerable<ClienteDto>> GetAll();
        Task<ClienteDtoCreateResult> Post(ClienteDtoCreate especie);
        Task<ClienteDtoUpdateResult> Put(ClienteDtoUpdate especie);
        Task<bool> Delete(Guid id);
    }
}
