using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Typed values for the CSS user-select property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class UserSelectKeywordKeyword
{
    public static readonly UserSelectKeyword None = new("none");
    public static readonly UserSelectKeyword Auto = new("auto");
    public static readonly UserSelectKeyword All = new("all");

    public static implicit operator UserSelectKeyword(GlobalKeyword style) => new(style.Value);
}
