

using Core.DataAccess.Entities;

namespace MediBookAPI.Model.Entities;

public sealed class UserRole:Entity<int>
{
    public UserRole()
    {
        User = new User();
        Role = new Role();
    }

    // Foreign Keys
    public int UserId { get; set; }
    public int RoleId { get; set; }

    // Navigation Properties
    public User User { get; set; }
    public Role Role { get; set; }
}
