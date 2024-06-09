using AutoMapper;
using MyApi.DTOs;
using MyApi.Repositories.Interfaces;
using MyApi.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApi.Services
{
    public abstract class ServiceBase<T, TDto, TRepository> : IService<T, TDto>
        where T : class
        where TDto : class
        where TRepository : IRepository<T>
    {
        protected readonly TRepository _repository;
        protected readonly IMapper _mapper;

        public ServiceBase(TRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<List<TDto>>(entities);
        }

        public async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public async Task AddAsync(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(int id, TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
