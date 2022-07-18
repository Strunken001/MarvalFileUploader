using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Files.DeleteFile
{
    public record DeleteFileQuery : IRequest<FileUpdateDTO>;

    public class DeleteFileQueryHandler : IRequestHandler<DeleteFileQuery, FileUpdateDTO>
    {
        private readonly IAsyncRepository<FileToUpload> _asyncRepository;
        private readonly IMapper _mapper;

        public DeleteFileQueryHandler(IAsyncRepository<FileToUpload> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }

        public async Task<FileUpdateDTO> Handle(DeleteFileQuery request, CancellationToken cancellationToken)
        {
            var file = _asyncRepository.DeleteFile(request);
            return _mapper.Map<FileUpdateDTO>(file);
        }
    }
}
