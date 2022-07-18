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

namespace Application.Queries.Files.UpdateRecord
{
    public record UpdateRecordQuery(FileUpdateDTO request) : IRequest<FileUploadDTO>;
    public class UpdateRecordQueryHandler : IRequestHandler<UpdateRecordQuery, FileUploadDTO>
    {
        private readonly IAsyncRepository<FileToUpload> _asyncRepository;
        private readonly IMapper _mapper;

        public UpdateRecordQueryHandler(IAsyncRepository<FileToUpload> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }

        public async Task<FileUploadDTO> Handle(UpdateRecordQuery request, CancellationToken cancellationToken)
        {
            var file = _asyncRepository.UpdateRecord(request);
            return _mapper.Map<FileUploadDTO>(file);
        }
    }
}
