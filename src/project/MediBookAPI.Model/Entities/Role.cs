

using Core.DataAccess.Entities;

namespace MediBookAPI.Model.Entities;

public sealed class Role:Entity<int>
{
    public Role()
    {
        Name = string.Empty;
        Description = string.Empty;
        UserRoles = new HashSet<UserRole>();
    }

    public string Name { get; set; }
    public string Description { get; set; }

    // Navigation Property
    public ICollection<UserRole> UserRoles { get; set; }

}
