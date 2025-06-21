using KidsChore.Application.Interfaces;
using KidsChore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KidsChore.Infrastructure.Services
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> _repo;
        public LocationService(IRepository<Location> repo)
        {
            _repo = repo;
        }
        public Task<IEnumerable<Location>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Location?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task AddAsync(Location location) => _repo.AddAsync(location);
        public Task UpdateAsync(Location location) => _repo.UpdateAsync(location);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
    }
} 