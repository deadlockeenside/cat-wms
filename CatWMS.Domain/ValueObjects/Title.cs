using CatWMS.Domain.Common;

namespace CatWMS.Domain.ValueObjects;

public sealed record Title : ValueObject<string>
{
    private Title(string value) : base(value) { }

    protected override void Validate(string value)
    {
        // TODO: Validation and format
    }

    // Static fabric method
    public static Title Create(string value) => new Title(value);
}
