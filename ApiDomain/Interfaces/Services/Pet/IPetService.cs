using ApiDomain.Dtos.Pet;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Pet
{
    public interface IPetService
    {
        Task<PetDto> Get(Guid id);
        Task<IEnumerable<PetDto>> GetAll();
        Task<PetDtoCreateResult> Post(PetDtoCreate Pet);
        Task<PetDtoUpdateResult> Put(PetDtoUpdate Pet);
        Task<bool> Delete(Guid id);
    }
}
