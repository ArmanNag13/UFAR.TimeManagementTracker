namespace UFAR.TimeManagementTracker.Backend.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime ExamDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
