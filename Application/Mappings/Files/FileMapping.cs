using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace Application.Mappings.Files;

public class FileMapping : Profile
{
    public FileMapping()
    {
        CreateMap<FileUploadDTO, FileToUpload > ();
        //CreateMap<FileToUpload, FileUploadDTO>();
        //CreateMap<FileToUpload, FileUploadDTO>();
        //CreateMap<FileToUpload, FileUploadDTO>();
    }


}
