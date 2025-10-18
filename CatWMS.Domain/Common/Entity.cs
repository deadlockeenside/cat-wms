namespace CatWMS.Domain.Common;

// This can easily be modified to be Entity<T> and public T Id to support different key types.
public abstract class Entity
{
    // Using non-generic integer types for simplicity and to ease caching logic
    public int Id { get; init; }

    public sealed override bool Equals(object? obj)
    {
        if (obj is not Entity other)
            return false;

        if (ReferenceEquals(this, other))
            return true;

        if (GetType() != other.GetType())
            return false;

        return Id == other.Id;
    }

    public sealed override int GetHashCode() => (GetType().ToString() + Id).GetHashCode();
}