using Application.Infrastructure;
using Application.Queries.Files.ValidateFile;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Files.UploadFile
{
    public record UploadFileCompareQuery(IFormFile file) : IRequest<FileValidateResultVm>;
    public class UploadFileQueryHandler : IRequestHandler<UploadFileCompareQuery, FileValidateResultVm>
    {
        private readonly IAsyncRepository<FileToUpload> _asyncRepository;
        private readonly IMapper _mapper;
        private readonly ICsvProcessor _csvProcessor;

        public UploadFileQueryHandler(IAsyncRepository<FileToUpload> asyncRepository, IMapper mapper, ICsvProcessor csvProcessor)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
            _csvProcessor = csvProcessor;

        }

        public async Task<FileValidateResultVm> Handle(UploadFileCompareQuery request, CancellationToken cancellationToken)
        {

            var fileCompareResultResponse = new FileValidateResultVm();

            var validator = new GetFileCompareValidator();

            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                fileCompareResultResponse.Success = false;
                fileCompareResultResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    fileCompareResultResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            else
            {
                var fileContents = await _csvProcessor.ProcessUploadedCsvFile(request);

                foreach (var item in fileContents)
                {
                    fileCompareResultResponse.fileCompareDtos.Add(item);
                }

            }

            return fileCompareResultResponse;
        }
    }
}
