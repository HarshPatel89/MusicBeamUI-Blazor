using MusicBeam.Models.Errors;

namespace MusicBeam.Models.User
{
    public record User
    (
        string token
    );

    public class UserResponse
    {
        public ErrorsModel errors { get; set; }
        public User user { get; set; }
    }
}
