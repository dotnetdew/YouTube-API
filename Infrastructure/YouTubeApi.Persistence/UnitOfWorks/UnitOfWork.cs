using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeApi.Application.Interfaces.Repositories;
using YouTubeApi.Application.UnitOfWorks;
using YouTubeApi.Persistence.Contexts;
using YouTubeApi.Persistence.Repositories;

namespace YouTubeApi.Persistence.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext dbContext;
    public UnitOfWork(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();
    public int Save() => dbContext.SaveChanges();
    public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();
    IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);
    IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);
}
