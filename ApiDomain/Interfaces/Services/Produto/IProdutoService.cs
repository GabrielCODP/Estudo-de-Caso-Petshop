using ApiDomain.Dtos.Produto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Produto
{
    public interface IProdutoService
    {
        Task<ProdutoDto> Get(Guid id);
        Task<IEnumerable<ProdutoDto>> GetAll();
        Task<ProdutoDtoCreateResult> Post(ProdutoDtoCreate produto);
        Task<ProdutoDtoUpdateResult> Put(ProdutoDtoUpdate produto);
        Task<bool> Delete(Guid id);
    }
}
