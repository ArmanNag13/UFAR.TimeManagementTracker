namespace UFAR.TimeManagementTracker.Backend.Models
{
    public class AuthResponse
    {

        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsSuccess { get; internal set; }
        public string Message { get; internal set; }
        public string Token { get; internal set; }
    }
}
