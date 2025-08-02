using System.Diagnostics.CodeAnalysis;
using Content.Shared.Mind;
using Robust.Shared.Containers;

namespace Content.Shared._AS.License;

public sealed class LicenseSystem : EntitySystem
{
    [Dependency] private readonly SharedContainerSystem _container = default!;
    [Dependency] private readonly SharedMindSystem _mind = default!;
    [Dependency] private readonly MetaDataSystem _meta = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<LicenseComponent, ComponentInit>(OnInit);
    }

    private void OnInit(Entity<LicenseComponent> ent, ref ComponentInit args)
    {
        if (ent.Comp.LicenseName is not {} license)
            return;

        var newItemName = TryGetOwnerName(ent, out var owner)
            ? Loc.GetString(ent.Comp.OwnerLoc, ("owner", owner), ("license", license))
            : Loc.GetString(ent.Comp.NoOwnerLoc, ("license", license));
        _meta.SetEntityName(ent, newItemName);
    }

    private bool TryGetOwnerName(EntityUid ent, [NotNullWhen(true)] out string? owner)
    {
        owner = null;
        if (Transform(ent) is not { } xform)
            return false;
        // Outermost container owner is expected to be player entity
        // This is true in this case as licenses will be generated before a owner will be entering a potential container
        if (!_container.TryGetOuterContainer(ent, xform, out var container))
            return false;
        // Getting the player character name via mind
        if (_mind.TryGetMind(container.Owner, out _, out var mindComp))
            owner = mindComp.CharacterName;
        return owner != null;
    }
}
