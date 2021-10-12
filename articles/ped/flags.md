# Ped Config Flags

Ped config flags are flags that configure behaviour or show states of peds.
Flag means: that the value of the variable can only be 0 or 1 (false or true). The flags can be read with <a href="https://natives.altv.mp/#/0x7EE53118C892B513" target="_blank">getPedConfigFlag</a> and written with <a href="https://natives.altv.mp/#/0x1913FE4CBF41C463" target="_blank">setPedConfigFlag</a>.

| Name   | Flag ID
| ------ | :-------------------------------: |
| PED_FLAG_CAN_PUNCH                            |  18
| PED_FLAG_CAN_FLY_THRU_WINDSCREEN              |  32
| PED_FLAG_DIES_BY_RAGDOLL                      |  33
| PED_FLAG_PUT_ON_MOTORCYCLE_HELMET             |  35
| PED_FLAG_NO_COLLISION                         |  52
| PED_FLAG_IS_SHOOTING                          |  58
| PED_FLAG_IS_ON_GROUND                         |  60
| PED_FLAG_NO_COLLIDE                           |  62
| PED_FLAG_DEAD                                 |  71
| PED_FLAG_IS_SNIPER_SCOPE_ACTIVE               |  72
| PED_FLAG_SUPER_DEAD                           |  73
| PED_FLAG_IS_IN_AIR                            |  76
| PED_FLAG_IS_AIMING                            |  78
| PED_FLAG_DRUNK                                |  100
| PED_FLAG_IS_NOT_RAGDOLL_AND_NOT_PLAYING_ANIM  |  104
| PED_FLAG_NO_PLAYER_MELEE                      |  122
| PED_FLAG_NM_MESSAGE_466                       |  125
| PED_FLAG_INJURED_LIMP                         |  166
| PED_FLAG_INJURED_LIMP_2                       |  170
| PED_FLAG_DISABLE_SHUFFLING_TO_DRIVER_SEAT     |  184
| PED_FLAG_INJURED_DOWN                         |  187
| PED_FLAG_SHRINK                               |  223
| PED_FLAG_MELEE_COMBAT                         |  224
| PED_FLAG_DISABLE_STOPPING_VEH_ENGINE          |  241
| PED_FLAG_IS_ON_STAIRS                         |  253
| PED_FLAG_HAS_ONE_LEG_ON_GROUND                |  276
| PED_FLAG_NO_WRITHE                            |  281
| PED_FLAG_FREEZE                               |  292
| PED_FLAG_IS_STILL                             |  301
| PED_FLAG_NO_PED_MELEE                         |  314
| PED_FLAG_SWITCHING_WEAPON                     |  331
| PED_FLAG_ALPHA                                |  410
| PED_FLAG_FLAMING_FOOTPRINTS                   |  421
| PED_FLAG_DISABLE_PROP_KNOCK_OFF               |  423
| PED_FLAG_DISABLE_STARTING_VEH_ENGINE          |  429


## Config Flag Enum

```ts
// noinspection JSUnusedGlobalSymbols
export enum PedConfigFlag {
    // noinspection JSUnusedGlobalSymbols
    CanPunch = 18,
    CanFlyThruWindscreen = 32,
    DiesByRagdoll = 33,
    PutOnMotorcycleHelmet = 35,
    NoCollision = 52,
    IsShooting = 58,
    IsOnGround = 60,
    NoCollide = 62,
    Dead = 71,
    IsSniperScopeActive = 72,
    SuperDead = 73,
    IsInAir = 76,
    IsAiming = 78,
    Drunk = 100,
    IsNotRagdollAndNotPlayingAnim = 104,
    NoPlayerMelee = 122,
    NmMessage466 = 125,
    InjuredLimp = 166,
    InjuredLimp2 = 170,
    DisableShufflingToDriverSeat = 184,
    InjuredDown = 187,
    Shrink = 223,
    MeleeCombat = 224,
    DisableStoppingVehEngine = 241,
    IsOnStairs = 253,
    HasOneLegOnGround = 276,
    NoWrithe = 281,
    Freeze = 292,
    IsStill = 301,
    NoPedMelee = 314,
    PedSwitchingWeapon = 331,
    Alpha = 410,
    DisablePropKnockOff = 423,
    DisableStartingVehEngine = 429,
    FlamingFootprints = 421
}
```