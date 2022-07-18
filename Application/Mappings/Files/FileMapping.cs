using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace Application.Mappings.Files;

public class FileMapping : Profile
{
    public FileMapping()
    {
        CreateMap<FileToUpload, FileUploadDTO>();
        //CreateMap<FileToUpload, FileUploadDTO>();
        //CreateMap<FileToUpload, FileUploadDTO>();
        //CreateMap<FileToUpload, FileUploadDTO>();
    }


}
