﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSK.Application.Module.Migration
{
    public interface ISeedData<TDbContext>
        where TDbContext : DbContext
    {
        Task SeedAsync(TDbContext context);
    }

    public interface IAuthConfigSeedData<TDbContext> : ISeedData<TDbContext>
        where TDbContext : DbContext
    {
    }
}
