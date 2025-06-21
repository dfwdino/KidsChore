using KidsChore.Application.Interfaces;
using KidsChore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KidsChore.Infrastructure.Services
{
    public class ChoreItemService : IChoreItemService
    {
        private readonly IRepository<ChoreItem> _repo;
        public ChoreItemService(IRepository<ChoreItem> repo)
        {
            _repo = repo;
        }
        public Task<IEnumerable<ChoreItem>> GetAllAsync() => _repo.GetAllAsync();
        public Task<ChoreItem?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task AddAsync(ChoreItem item) => _repo.AddAsync(item);
        public Task UpdateAsync(ChoreItem item) => _repo.UpdateAsync(item);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
    }
} 