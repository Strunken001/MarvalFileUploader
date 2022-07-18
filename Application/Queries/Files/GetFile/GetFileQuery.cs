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

namespace Application.Queries.Files.GetFile
{
    public record GetFileQuery : IRequest<GetFileDTO>;

    public class GetFileQueryHandler : IRequestHandler<GetFileQuery, GetFileDTO>
    {
        private readonly IAsyncRepository<FileToUpload> _asyncRepository;
        private readonly IMapper _mapper;

        public GetFileQueryHandler(IAsyncRepository<FileToUpload> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }

        public async Task<GetFileDTO> Handle(GetFileQuery request, CancellationToken cancellationToken)
        {
            var file = await _asyncRepository.GetFile();
            return _mapper.Map<GetFileDTO>(file);
        }
    }
}
