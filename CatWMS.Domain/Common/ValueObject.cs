namespace CatWMS.Domain.Common;

public abstract record ValueObject<T>
{
    protected ValueObject(T value)
    {
        Validate(value);
        Value = Format(value);
    }

    public T Value { get; init; }

    protected abstract void Validate(T value);

    protected virtual T Format(T value) => value;

    public static implicit operator T(ValueObject<T> obj) => obj is null ? throw new ArgumentNullException(nameof(obj)) : obj.Value;

    public sealed override string ToString() => Value?.ToString() ?? string.Empty;
}
