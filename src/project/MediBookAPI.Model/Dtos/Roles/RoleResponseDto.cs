﻿
namespace MediBookAPI.Model.Dtos.Roles;

public sealed record RoleResponseDto
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
}
