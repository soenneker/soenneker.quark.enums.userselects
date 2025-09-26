using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// Typed values for the CSS user-select property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class UserSelect
{
    public static readonly UserSelect None = new("none");
    public static readonly UserSelect Auto = new("auto");
    public static readonly UserSelect All = new("all");

    public static implicit operator UserSelect(GlobalKeyword style) => new(style.Value);
}
