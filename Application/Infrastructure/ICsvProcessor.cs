using Application.Queries.Files.UploadFile;
using Application.Queries.Files.ValidateFile;
using Domain.Models;
using System;


namespace Application.Infrastructure
{
    public interface ICsvProcessor
    {

        Task<List<FileCompareDto>> ProcessUploadedCsvFile(UploadFileCompareQuery files);


    }
}
