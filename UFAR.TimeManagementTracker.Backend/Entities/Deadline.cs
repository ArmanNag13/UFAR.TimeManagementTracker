
namespace UFAR.TimeManagementTracker.Backend.Entities
{
    public class Deadline
    {
        public int Id { get; set; }

        
        public string Title { get; set; }

        
        public DateTime DueDate { get; set; }

       
        public int UserId { get; set; }
    }
}
