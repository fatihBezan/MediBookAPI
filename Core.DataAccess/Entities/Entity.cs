namespace Core.DataAccess.Entities;

public abstract class Entity<TId>
{
    public DateTime CreatedTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public TId Id { get; set; }

    public Entity()
    {
        Id = default;
    }

    public Entity(TId id)
    {
        Id = id;
    }
}
