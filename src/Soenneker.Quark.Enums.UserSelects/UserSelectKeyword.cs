using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Typed values for the CSS user-select property in .NET enumeration form.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class UserSelectKeyword
{
    public static readonly UserSelectKeyword None = new("none");
    public static readonly UserSelectKeyword Auto = new("auto");
    public static readonly UserSelectKeyword All = new("all");
}
