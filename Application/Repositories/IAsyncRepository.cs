

namespace Application.Repositories;

public interface IAsyncRepository <T> where T : class
{
    Task<T> UploadFile(T request);
    //Task<FileValidateResultVm> Handle(GetFilesCompareQuery request, CancellationToken cancellationToken);
    Task<List<T>> GetFile();

}
