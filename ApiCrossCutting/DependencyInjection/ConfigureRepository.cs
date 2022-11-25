using ApiData.Context;
using ApiData.Implementations;
using ApiData.Repository;
using ApiDomain.Interfaces;
using ApiDomain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddScoped<IUserRepository, UserImplementation>();



            serviceCollection.AddScoped<IUfRepository, UfImplementation>();

            serviceCollection.AddScoped<IMunicipioRepository, MunicipioImplementation>();

            serviceCollection.AddScoped<ICepRepository, CepImplementation>();


            serviceCollection.AddScoped<IPessoaRepository, PessoaImplementation>();


            serviceCollection.AddScoped<ITelefoneRepository, TelefoneImplementation>();


            serviceCollection.AddScoped<ICategoriaRepository, CategoriaImplementation>();


            serviceCollection.AddScoped<IProdutoRepository, ProdutoImplementation>();

            serviceCollection.AddScoped<IRacaRepository, RacaImplementation>();

            serviceCollection.AddScoped<IEspecieRepository, EspecieImplementation>();

            serviceCollection.AddScoped<IPetRepository, PetImplementation>();

            serviceCollection.AddScoped<IServicoRepository, ServicoImplementation>();

            serviceCollection.AddScoped<IPagamentoRepository, PagamentoImplementation>();


            serviceCollection.AddScoped<IClienteRepository, ClienteImplementation>();
            serviceCollection.AddScoped<IFuncionarioRepository, FuncionarioImplementation>();

            serviceCollection.AddDbContext<MyContext>(
               options => options.UseMySql("server=localhost;userid=root;port=3306;password=78@_JXTOb?;database=lojaPetShotTrabalho")
           );

        }
    }
}
