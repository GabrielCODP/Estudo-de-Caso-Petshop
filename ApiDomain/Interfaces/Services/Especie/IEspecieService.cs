using ApiDomain.Dtos.Especie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Especie
{
    public interface IEspecieService
    {
        Task<EspecieDto> Get(Guid id);
        Task<IEnumerable<EspecieDto>> GetAll();
        Task<EspecieDtoCreateResult> Post(EspecieDtoCreate especie);
        Task<EspecieDtoUpdateResult> Put(EspecieDtoUpdate especie);
        Task<bool> Delete(Guid id);
    }
}
