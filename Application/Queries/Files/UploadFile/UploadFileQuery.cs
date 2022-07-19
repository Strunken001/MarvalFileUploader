
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
    public record UploadFileContentCommand(List<FileUploadDTO> parseContent) : IRequest<List<FileToUpload>>;
    public class UploadFileCompareHandler: IRequestHandler<UploadFileContentCommand, List<FileToUpload>>
    {
        private readonly IAsyncRepository<FileToUpload> _asyncRepository;
        private readonly IMapper _mapper;

        public UploadFileCompareHandler(IAsyncRepository<FileToUpload> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;

        }

        public async Task<List<FileToUpload>> Handle(UploadFileContentCommand request, CancellationToken cancellationToken)
        {

            var resp =  _mapper.Map<List<FileToUpload>>(request.parseContent);
            var response = await _asyncRepository.UploadFile(resp);


            return response;
        }
    }
}
