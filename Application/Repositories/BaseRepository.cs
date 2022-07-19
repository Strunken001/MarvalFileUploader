
using Domain.Db;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
    private readonly FileUploadContext _fileUploadDbContext;

    public BaseRepository(FileUploadContext fileUploadDbContext)
    {
        _fileUploadDbContext = fileUploadDbContext;
    }

    //public async Task<T> UploadFile(T request)
    //{     

    //    var response = await _fileUploadDbContext.Set<T>().AddAsync(request);

    //    await _fileUploadDbContext.SaveChangesAsync();

    //    return response.Entity;

    //}

    public async Task<List<T>> UploadFile(List<T> request)
    {

        _fileUploadDbContext.Set<T>().AddRange(request);

        await _fileUploadDbContext.SaveChangesAsync();

        return request;
    }

    public async Task<List<T>> GetFile()
    {
        return await _fileUploadDbContext.Set<T>().ToListAsync();

    }
}
