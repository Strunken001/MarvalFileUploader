using CsvHelper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using Domain.Models;
using Application.Queries.Files.ValidateFile;
using Application.Infrastructure;
using Application.Helpers;
using Application.Queries.Files.UploadFile;

namespace Application.Repositories
{
    public class CsvProcessorRepo : ICsvProcessor
    {

        private readonly ILogger<CsvProcessorRepo> _logger;

        public CsvProcessorRepo(ILogger<CsvProcessorRepo> logger)
        {
            _logger = logger;
        }


        public Task<List<FileCompareDto>> ProcessUploadedCsvFile(UploadFileCompareQuery files)
        {
            var fileListCompareResult = new List<FileCompareDto>();

            try
            {
                _logger.LogInformation("About to get the content of the first file");

                var firstFile = FileHelper.GetFileContent(files.file);               

                fileListCompareResult.Add(new FileCompareDto
                {
                    FileName = files.file.FileName,
                    
                    TotalRecords = firstFile.Count

                });

            }
            catch (Exception ex)
            {

                _logger.LogCritical("An Exception occured while runing ProcessUploadedCsvFile {ex} ", ex);
            }

            return Task.FromResult(fileListCompareResult);
        }

    


    }
}
