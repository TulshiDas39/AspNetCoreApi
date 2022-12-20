﻿using AspNetCoreApi.Core.Dtos;
using AspNetCoreApi.Core.Interfaces.Repositories;
using AspNetCoreApi.Core.Interfaces.Services;
using AutoMapper;
using Core.Models;

namespace AspNetCoreApi.Services;

public class BaseService<TEntity, TDto, TKey> : IBaseService<TDto,TKey> where TEntity : BaseModel<TKey> where TDto : BaseDto<TKey> 
{
    private readonly IBaseRepository<TEntity, TKey> _repo;
    private readonly IMapper _mapper;

    public BaseService(IBaseRepository<TEntity, TKey> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task<List<TDto>> GetAll()
    {
        var list = await _repo.GetAll();
        return _mapper.Map<List<TDto>>(list);
    }

    public async Task<TDto> GetById(TKey Id)
    {
        var item = await _repo.GetById(Id);

        return _mapper.Map<TDto>(item);
    }

    public async Task<TDto> Create(TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        await _repo.AddAsync(entity);
        return _mapper.Map<TDto>(entity);
    }

    public Task Update(TDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Delete(TKey Id)
    {
        throw new NotImplementedException();
    }

    public Task ParmanentDelete(TKey Id)
    {
        throw new NotImplementedException();
    }
}


//do not add properties/fields/methods to this class. Do that in the above class.

public class BaseService<TEntity,TDto> :BaseService<TEntity,TDto, int> , IBaseService<TDto> where TEntity : BaseModel where TDto:BaseDto
{
    public BaseService(IBaseRepository<TEntity> repo, IMapper mapper) : base(repo,mapper)
    {
    }
}