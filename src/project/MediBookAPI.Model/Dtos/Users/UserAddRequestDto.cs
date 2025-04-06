

namespace MediBookAPI.Model.Dtos.Users;

public sealed record UserAddRequestDto
{

    public string? Username { get; init; }
    public string? Email { get; init; }
}
