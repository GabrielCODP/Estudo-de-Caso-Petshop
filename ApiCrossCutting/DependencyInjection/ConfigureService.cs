using ApiDomain.Interfaces.Services;
using ApiDomain.Interfaces.Services.Categoria;
using ApiDomain.Interfaces.Services.Cep;
using ApiDomain.Interfaces.Services.Cliente;
using ApiDomain.Interfaces.Services.Especie;
using ApiDomain.Interfaces.Services.Funcao;
using ApiDomain.Interfaces.Services.Municipio;
using ApiDomain.Interfaces.Services.Pagamento;
using ApiDomain.Interfaces.Services.Pessoa;
using ApiDomain.Interfaces.Services.Pet;
using ApiDomain.Interfaces.Services.Produto;
using ApiDomain.Interfaces.Services.Raca;
using ApiDomain.Interfaces.Services.Servico;
using ApiDomain.Interfaces.Services.Telefone;
using ApiDomain.Interfaces.Services.User;
using ApiServices.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();

            serviceCollection.AddTransient<IUfService, UfService>();
            serviceCollection.AddTransient<IMunicipioService, MunicipioService>();
            serviceCollection.AddTransient<ICepService, CepService>();

            serviceCollection.AddTransient<IPessoaService, PessoaService>();
            serviceCollection.AddTransient<ITelefoneService, TelefoneService>();

            serviceCollection.AddTransient<ICategoriaService, CategoriaService>();
            serviceCollection.AddTransient<IProdutoService, ProdutoService>();

            serviceCollection.AddTransient<IRacaService, RacaService>();

            serviceCollection.AddTransient<IEspecieService, EspecieService>();

            serviceCollection.AddTransient<IPetService, PetService>();

            serviceCollection.AddTransient<IServicoService, ServicoService>();

            serviceCollection.AddTransient<IPagamentoService, PagamentoService>();


            serviceCollection.AddTransient<IClienteService, ClienteService>();

            serviceCollection.AddTransient<IFuncionarioService, FuncionarioService>();
        }
    }
}
