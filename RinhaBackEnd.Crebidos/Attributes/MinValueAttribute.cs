using System.ComponentModel.DataAnnotations;

namespace RinhaBackEnd.Crebidos.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class MinValueAttribute : ValidationAttribute
{
    /// <summary>
    ///     Initializes a new instance of <see cref="MinValueAttribute"/> class.
    /// </summary>
    /// <param name="value">
    ///     The minimum value for a int property/field/parameter.
    ///     The value must be greater or equal the value informed.
    ///     By default the value is set to zero.
    ///     Just works with int.
    /// </param>
    public MinValueAttribute(int value = 0)
    {
            Value = value;
    }

    private int Value { get; }

    public override bool IsValid(object? value)
    {
        if (value is not int)
            throw new ArgumentException("This validation is just for int");

        return value is int val && val >= Value;       
    }
}
