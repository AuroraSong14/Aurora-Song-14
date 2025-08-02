using System.ComponentModel.DataAnnotations;

namespace Content.Shared._AS.License;

[RegisterComponent]
public sealed partial class LicenseComponent : Component
{
    [DataField]
    public LocId NoOwnerLoc = "license-name-no-owner";

    [DataField]
    public LocId OwnerLoc = "license-name-owner";

    [DataField]
    public string? LicenseName;
}
