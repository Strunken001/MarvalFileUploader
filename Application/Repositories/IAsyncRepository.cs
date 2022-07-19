

namespace Application.Repositories;

public interface IAsyncRepository <T> where T : class
{
    Task<List<T>> UploadFile(List<T> request);
    //Task<FileValidateResultVm> Handle(GetFilesCompareQuery request, CancellationToken cancellationToken);
    Task<List<T>> GetFile();

}
