using System.Numerics;

namespace Content.Shared.Floofstation.Leash.Components;

/// <summary>
///     Indicates that this entity or the entity that wears this entity can be leashed.
/// </summary>
[RegisterComponent]
public sealed partial class LeashAnchorComponent : Component
{
    /// <summary>
    ///     Flooftier change - whether this anchor is enabled.
    /// </summary>
    [DataField]
    public bool Enabled = true;

    /// <summary>
    ///     The visual offset of the "anchor point".
    /// </summary>
    [DataField]
    public Vector2 Offset = Vector2.Zero;
}
