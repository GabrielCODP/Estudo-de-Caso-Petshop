using ApiDomain.Dtos.Telefone;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Telefone
{
    public interface ITelefoneService
    {
        Task<TelefoneDto> Get(Guid id);

        Task<IEnumerable<TelefoneDto>> GetAll();
        Task<TelefoneDtoCreateResult> Post(TelefoneDtoCreate telefone);
        Task<TelefoneDtpUpdateResult> Put(TelefoneDtoUpdate telefone);
        Task<bool> Delete(Guid id);
    }
}
