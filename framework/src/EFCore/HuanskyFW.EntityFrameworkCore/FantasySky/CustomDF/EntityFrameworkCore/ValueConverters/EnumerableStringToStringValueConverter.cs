namespace HuanskyFW.EntityFrameworkCore.ValueConverters;

public class EnumerableStringToStringValueConverter : EnumerableToStringValueConverter<string>
{
    public EnumerableStringToStringValueConverter()
        : base(
            d => d,
            s => s)
    {
    }

    public static EnumerableStringToStringValueConverter Instance = new();
}
