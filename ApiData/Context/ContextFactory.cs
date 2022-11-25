using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Criar a migração em tempo de criaçao do projeto, vi
            var connectioString = "server=localhost;userid=root;port=3306;password=78@_JXTOb?;database=lojaPetShotTrabalho";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectioString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
