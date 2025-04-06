

namespace MediBookAPI.Model.Dtos.Roles;

public sealed record RoleAddRequestDto
{
    public string? Name { get; init; }
    public string? Description { get; init; }
}
