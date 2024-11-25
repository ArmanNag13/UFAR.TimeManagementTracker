using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UFAR.TimeManagementTracker.Backend.Data;
using UFAR.TimeManagementTracker.Backend.Entities;

namespace UFAR.TimeManagementTracker.Backend.Services
{
    public class TimeManagementService : ITimeManagementService
    {
        private readonly TimeManagementContext _context;

        public TimeManagementService(TimeManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Deadline>> GetAllDeadlinesAsync()
        {
            return await _context.Deadlines.ToListAsync();
        }

        public async Task<Deadline> GetDeadlineByIdAsync(int id)
        {
            return await _context.Deadlines.FindAsync(id);
        }

        public async Task AddDeadlineAsync(Deadline deadline)
        {
            _context.Deadlines.Add(deadline);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDeadlineAsync(int id)
        {
            var deadline = await _context.Deadlines.FindAsync(id);
            if (deadline != null)
            {
                _context.Deadlines.Remove(deadline);
                await _context.SaveChangesAsync();
            }
        }
    }
}
