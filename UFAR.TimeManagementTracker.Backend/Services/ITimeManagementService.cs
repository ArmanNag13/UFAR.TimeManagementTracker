using System.Collections.Generic;
using System.Threading.Tasks;
using UFAR.TimeManagementTracker.Backend.Entities;

namespace UFAR.TimeManagementTracker.Backend.Services
{
    public interface ITimeManagementService
    {
        Task<IEnumerable<Deadline>> GetAllDeadlinesAsync();
        Task<Deadline> GetDeadlineByIdAsync(int id);
        Task AddDeadlineAsync(Deadline deadline);
        Task DeleteDeadlineAsync(int id);
    }
}
