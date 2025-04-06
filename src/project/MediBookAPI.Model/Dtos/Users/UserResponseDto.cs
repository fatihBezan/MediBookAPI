

namespace MediBookAPI.Model.Dtos.Users;

public sealed record UserResponseDto
{
    public int Id { get; init; }
    public string? Username { get; init; }
    public string? Email { get; init; }
}
