using ApiDomain.Dtos.Funcionario;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.Interfaces.Services.Funcao
{
    public interface IFuncionarioService
    {
        Task<FuncionarioDto> Get(Guid id);
        Task<IEnumerable<FuncionarioDto>> GetAll();
        Task<FuncionarioDtoCreateResult> Post(FuncionarioDtoCreate especie);
        Task<FuncionarioDtoUpdateResult> Put(FuncionarioDtoUpdate especie);
        Task<bool> Delete(Guid id);
    }
}
