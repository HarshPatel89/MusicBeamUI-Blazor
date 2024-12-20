namespace MusicBeam.Models.User
{
    public class LoginRequest
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }

    public record Login(
        string Email,
        string Password
    );
}
