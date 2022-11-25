using ApiDomain.Dtos.Raca;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Raca
{
    public interface IRacaService
    {
        Task<RacaDto> Get(Guid id);
        Task<IEnumerable<RacaDto>> GetAll();
        Task<RacaDtoCreateResult> Post(RacaDtoCreate especie);
        Task<RacaDtoUpdateResult> Put(RacaDtoUpdate especie);
        Task<bool> Delete(Guid id);
    }
}
