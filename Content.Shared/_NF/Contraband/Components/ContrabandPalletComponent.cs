using Content.Shared.Stacks;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared._NF.Contraband.Components;

[RegisterComponent]
[Access(typeof(SharedContrabandTurnInSystem))]
public sealed partial class ContrabandPalletConsoleComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("cashType", serverOnly: true, customTypeSerializer:typeof(PrototypeIdSerializer<StackPrototype>))]
    public string RewardType = "FrontierUplinkCoin";

    [ViewVariables(VVAccess.ReadWrite), DataField(serverOnly: true)]
    public string Faction = "NFSD";

    [ViewVariables(VVAccess.ReadWrite), DataField]
    public string LocStringPrefix = string.Empty;

    [DataField]
    public Dictionary<EntProtoId, EntProtoId> RegisterRecipies = new()
    {
        {"NFWeaponPistolMk58Expedition","NFWeaponPistolMk58"},
        {"NFWeaponPistolPollockExpedition","NFWeaponPistolPollockHighCapacityMag"},
        {"NFWeaponPistolUniversalExpedition","NFWeaponPistolUniversal"},
        {"NFWeaponRevolverArgentiExpedition","NFWeaponRevolverArgenti"},
        {"NFWeaponRevolverFaithExpedition","NFWeaponRevolverFaith"},
        {"NFWeaponRevolverDeckardExpedition","NFWeaponRevolverDeckard"},
        {"NFWeaponRevolverPython45Expedition","NFWeaponRevolverPython45"},
        {"NFWeaponRifleBarlowsBoltExpedition","NFWeaponRifleBarlowsBolt"},
        {"NFWeaponRifleCeremonialExpedition","NFWeaponRifleCeremonial"},
        {"NFWeaponRifleRepeaterExpedition","NFWeaponRifleRepeater"},
        {"NFWeaponPistolCobraExpedition","NFWeaponPistolCobra"},
        {"NFWeaponPistolN1984Expedition","NFWeaponPistolN1984"},
        {"NFWeaponPistolViperExpedition","NFWeaponPistolViper"},
        {"NFWeaponRevolverFitzExpedition","NFWeaponRevolverFitz"},
        {"NFWeaponRevolverLuckyExpedition","NFWeaponRevolverLucky"},
        {"NFWeaponRevolverPirateExpedition","NFWeaponRevolverPirate"},
        {"NFWeaponRevolverWard45Expedition","NFWeaponRevolverWard45"},
        {"NFWeaponShotgunKammererExpedition","NFWeaponShotgunKammerer"},
        {"NFWeaponSubMachineGunC20rExpedition","NFWeaponSubMachineGunC20r"},
        {"NFWeaponRifleAssaultNovaliteC1Expedition","NFWeaponRifleAssaultNovaliteC1"},
        {"NFWeaponRifleAssaultJackdawExpedition","NFWeaponRifleAssaultJackdaw"},
        {"NFWeaponRifleAssaultGestioExpedition","NFWeaponRifleAssaultGestio"},
        {"NFWeaponRifleSVSExpedition","NFWeaponRifleSVS"},
        {"NFWeaponEnergyPistolLaserExpedition","NFWeaponEnergyPistolLaser"},
        {"NFWeaponRifleAssaultLecterExpedition","NFWeaponRifleAssaultLecter"},
        {"NFWeaponRifleAssaultM90Expedition","NFWeaponRifleAssaultM90"},
        {"NFWeaponRifleSniperHristovExpedition","NFWeaponRifleSniperHristov"},
        {"NFWeaponRifleMusketExpedition","NFWeaponRifleMusket"},
        {"NFWeaponSubMachineGunWt550Expedition","NFWeaponSubMachineGunWt550"},
        {"NFWeaponSubMachineGunDrozdExpedition","NFWeaponSubMachineGunDrozd"},
        {"NFWeaponSubMachineGunAtreidesExpedition","NFWeaponSubMachineGunAtreides"},
        {"NFWeaponSubMachineGunTypewriterExpedition","NFWeaponSubMachineGunTypewriter"},
        {"NFWeaponEnergyPistolLaserSvalinnExpedition","NFWeaponEnergyPistolLaserSvalinn"},
        {"NFWeaponShotgunEnforcerExpedition","NFWeaponShotgunEnforcer"},
        {"NFWeaponShotgunBulldogExpedition","NFWeaponShotgunBulldog"},
        {"NFWeaponRifleAssaultSmExpedition","NFWeaponRifleAssaultSm"},
        {"NFWeaponRifleAssaultVulcanExpedition","NFWeaponRifleAssaultVulcan"},
        {"NFWeaponEnergyRifleCarbineExpedition","NFWeaponEnergyRifleCarbine"},
        {"NFWeaponEnergyPistolLaserAdvancedExpedition","NFWeaponEnergyPistolLaserAdvanced"},
        {"NFWeaponEnergyPistolLaserAntiqueExpedition","NFWeaponEnergyPistolLaserAntique"},
        {"NFWeaponEnergySubMachineGunDeltaVExpedition","NFWeaponEnergySubMachineGunDeltaV"},
        {"NFWeaponEnergyRifleSniperXrayCannonExpedition","NFWeaponEnergyRifleSniperXrayCannon"},
        {"NFWeaponEnergyRifleSniperCannonExpedition","NFWeaponEnergyRifleSniperCannon"},
        {"NFWeaponEnergyRifleTemperatureExpedition","NFWeaponEnergyRifleTemperature"},

        {"ClothingOuterHardsuitSyndie","ClothingOuterHardsuitShanlinUnpainted"},
        {"ClothingOuterHardsuitSyndieElite","ClothingOuterHardsuitShiweiUnpainted"},

        {"ClothingShoesBootsMagSyndie","ClothingShoesBootsMagSyndieRegistered"},
    };
}
