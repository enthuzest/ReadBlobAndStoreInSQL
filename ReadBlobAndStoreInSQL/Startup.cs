using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReadBlobAndStoreInSQL.Models.Database;
using ReadBlobAndStoreInSQL.Repository;
using ReadBlobAndStoreInSQL.Services;
using System;

[assembly: FunctionsStartup(typeof(ReadBlobAndStoreInSQL.Startup))]

namespace ReadBlobAndStoreInSQL
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<ContractContext>(options =>
            {
                options.UseSqlServer(Environment.GetEnvironmentVariable("SqlConnectionString"));
            });

            builder.Services.AddScoped<IContractService, ContractService>();
            builder.Services.AddScoped<IContractRepo, ContractRepo>();
        }
    }
}
