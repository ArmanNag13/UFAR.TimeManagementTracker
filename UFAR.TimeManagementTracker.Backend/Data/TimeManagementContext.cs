using Microsoft.EntityFrameworkCore;
using UFAR.TimeManagementTracker.Backend.Entities;
using UFAR.TimeManagementTracker.Backend.Models;

namespace UFAR.TimeManagementTracker.Backend.Data
{
    public class TimeManagementContext : DbContext
    {
        public TimeManagementContext(DbContextOptions<TimeManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Deadline> Deadlines { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<FileRecords> FileRecords { get; set; }
        public DbSet<UserSign> userSigns { get; set; }
        public DbSet<AIResponse> AIResponses { get; set; }




    }
}
