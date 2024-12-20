namespace MusicBeam.Models.User
{
    public record UserRequest
   (
        string Email,
        string FirstName,
        string LastName,
        string Password
    );
}
