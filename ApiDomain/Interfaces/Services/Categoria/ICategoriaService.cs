using ApiDomain.Dtos.Categoria;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Categoria
{
    public interface ICategoriaService
    {
        Task<CategoriaDto> Get(Guid id);
        Task<IEnumerable<CategoriaDto>> GetAll();
        Task<CategoriaDtoCreateResult> Post(CategoriaDtoCreate categoria);

        Task<CategoriaDtoUpdateResult> Put(CategoriaDtoUpdate cep);
      
        Task<bool> Delete(Guid id);
    }
}
