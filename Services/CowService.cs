using AspNetCoreApi.Core.Interfaces.Repositories;
using AspNetCoreApi.Core.Interfaces.Services;
using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace AspNetCoreApi.Services;

public class CowService:BaseService<Cow,CowDto>,ICowService
{
    public readonly ICowRepository _repo;
    public readonly IMapper _mapper;
    public CowService(ICowRepository repo, IMapper mapper) : base(repo, mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    
}