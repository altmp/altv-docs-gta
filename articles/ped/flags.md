# Ped Config Flags

Ped config flags are flags that configure behaviour or show states of peds.
Flag means: that the value of the variable can only be 0 or 1 (false or true). The flags can be read with <a href="https://natives.altv.mp/#/0x7EE53118C892B513" target="_blank">getPedConfigFlag</a> and written with <a href="https://natives.altv.mp/#/0x1913FE4CBF41C463" target="_blank">setPedConfigFlag</a>.

| Name | Flag ID |
| ---- | ------- |
| PED_FLAG_NO_CRITICAL_HITS                             | 2 |
| PED_FLAG_DROWNS_IN_WATER                              | 3 |
| PED_FLAG_DISABLE_RETICULE_FIXED_LOCKON                | 4 |
| PED_FLAG_UPPER_BODY_DAMAGE_ANIMS_ONLY                 | 7 |
| PED_FLAG_NEVER_LEAVES_GROUP                           | 13 |
| PED_FLAG_BLOCK_NON_TEMPORARY_EVENTS                   | 17 |
| PED_FLAG_CAN_PUNCH                                    | 18 |
| PED_FLAG_IGNORE_SEEN_MELEE                            | 24 |
| PED_FLAG_CAN_FLY_THRU_WINDSCREEN                      | 32 |
| PED_FLAG_DIES_WHEN_RAGDOLL                            | 33 |
| PED_FLAG_HAS_HELMET                                   | 34 |
| PED_FLAG_PUT_ON_MOTORCYCLE_HELMET                     | 35 |
| PED_FLAG_DISABLE_EVASIVE_DIVES                        | 39 |
| PED_FLAG_DONT_INFLUENCE_WANTED_LEVEL                  | 42 |
| PED_FLAG_DISABLE_PLAYER_LOCKON                        | 43 |
| PED_FLAG_DISABLE_LOCKON_TO_RANDOM_PEDS                | 44 |
| PED_FLAG_BEING_DELETED                                | 47 |
| PED_FLAG_BLOCK_WEAPON_SWITCHING                       | 48 |
| PED_FLAG_NO_COLLISION                                 | 52 |
| PED_FLAG_IS_SHOOTING                                  | 58 |
| PED_FLAG_WAS_SHOOTING                                 | 59 |
| PED_FLAG_IS_ON_GROUND                                 | 60 |
| PED_FLAG_WAS_ON_GROUND                                | 61 |
| PED_FLAG_IN_VEHICLE                                   | 62 |
| PED_FLAG_ON_MOUNT                                     | 63 |
| PED_FLAG_ATTACHED_TO_VEHICLE                          | 64 |
| PED_FLAG_IS_SWIMMING                                  | 65 |
| PED_FLAG_WAS_SWIMMING                                 | 66 |
| PED_FLAG_IS_SKIING                                    | 67 |
| PED_FLAG_IS_SITTING                                   | 68 |
| PED_FLAG_KILLED_BY_STEALTH                            | 69 |
| PED_FLAG_KILLED_BY_TAKEDOWN                           | 70 |
| PED_FLAG_KNOCKEDOUT                                   | 71 |
| PED_FLAG_IS_SNIPER_SCOPE_ACTIVE                       | 72 |
| PED_FLAG_SUPER_DEAD                                   | 73 |
| PED_FLAG_USING_COVER_POINT                            | 75 |
| PED_FLAG_IS_IN_THE_AIR                                | 76 |
| PED_FLAG_IS_AIMING_GUN                                | 78 |
| PED_FLAG_FORCE_PED_LOAD_COVER                         | 93 |
| PED_FLAG_VAULT_FROM_COVER                             | 97 |
| PED_FLAG_IS_DRUNK                                     | 100 |
| PED_FLAG_FORCED_AIM                                   | 101 |
| PED_FLAG_IS_NOT_RAGDOLL_AND_NOT_PLAYING_ANIM          | 104 |
| PED_FLAG_FORCE_RELOAD                                 | 105 |
| PED_FLAG_BUMPED_BY_PLAYER                             | 117 |
| PED_FLAG_IS_HAND_CUFFED                               | 120 |
| PED_FLAG_IS_ANKLE_CUFFED                              | 121 |
| PED_FLAG_DISABLE_MELEE                                | 122 |
| PED_FLAG_NM_MESSAGE_466                               | 125 |
| PED_FLAG_CAN_BE_AGITATED                              | 128 |
| PED_FLAG_IS_SCUBA                                     | 135 |
| PED_FLAG_WILL_ARREST_RATHER_THAN_JACK                 | 136 |
| PED_FLAG_RIDING_TRAIN                                 | 138 |
| PED_FLAG_ARREST_RESULT                                | 139 |
| PED_FLAG_CAN_ATTACK_FRIENDLY                          | 140 |
| PED_FLAG_SHOOTING_ANIM_FLAG                           | 145 |
| PED_FLAG_DISABLE_LADDER_CLIMBING                      | 146 |
| PED_FLAG_STAIRS_DETECTED                              | 147 |
| PED_FLAG_SLOPE_DETECTED                               | 148 |
| PED_FLAG_CAN_PERFORM_ARREST                           | 155 |
| PED_FLAG_CAN_PERFORM_UNCUFF                           | 156 |
| PED_FLAG_CAN_BE_ARRESTED                              | 157 |
| PED_FLAG_IS_INJURED                                   | 166 |
| PED_FLAG_IS_INJURED_2                                 | 170 |
| PED_FLAG_IS_IN_CUSTODY                                | 180 |
| PED_FLAG_IS_AGITATED                                  | 183 |
| PED_FLAG_PREVENT_AUTO_SHUFFLE_TO_DRIVERS_SEAT         | 184 |
| PED_FLAG_ENABLE_WEAPON_BLOCKING                       | 186 |
| PED_FLAG_HAS_HURT_STARTED                             | 187 |
| PED_FLAG_DISABLE_HURT                                 | 188 |
| PED_FLAG_PLAYER_IS_WEIRD                              | 189 |
| PED_FLAG_USING_SCENARIO                               | 194 |
| PED_FLAG_VISIBLE_ON_SCREEN                            | 195 |
| PED_FLAG_DISABLE_EXPLOSION_REACTIONS                  | 208 |
| PED_FLAG_DODGED_PLAYER                                | 209 |
| PED_FLAG_DONT_ENTER_LEADERS_VEHICLE                   | 220 |
| PED_FLAG_SHRINK                                       | 223 |
| PED_FLAG_MELEE_COMBAT                                 | 224 |
| PED_FLAG_DISABLE_POTENTIAL_TO_BE_WALKED_INTO_RESPONSE | 225 |
| PED_FLAG_DISABLE_PED_AVOIDANCE                        | 226 |
| PED_FLAG_DISABLE_PANIC_IN_VEHICLE                     | 229 |
| PED_FLAG_IS_HOLDING_PROP                              | 236 |
| PED_FLAG_BLOCKS_PATHING_WHEN_DEAD                     | 237 |
| PED_FLAG_DISABLE_STOPPING_VEHICLE_ENGINE              | 241 |
| PED_FLAG_CAN_PLAY_IN_CAR_IDLES                        | 248 |
| PED_FLAG_IS_ON_STAIRS                                 | 253 |
| PED_FLAG_IS_ON_STAIRS_SLOPE                           | 270 |
| PED_FLAG_DONT_BLIP_COP                                | 272 |
| PED_FLAG_CLIMBED_SHIFTED_FENCE                        | 273 |
| PED_FLAG_EDGE_DETECTED                                | 276 |
| PED_FLAG_AVOID_TEAR_GAS                               | 279 |
| PED_FLAG_NO_WRITHE                                    | 281 |
| PED_FLAG_RAGDOLLING_ON_BOAT                           | 287 |
| PED_FLAG_HAS_BRANDISHED_WEAPON                        | 288 |
| PED_FLAG_FREEZE_POSITION                              | 292 |
| PED_FLAG_DISABLE_SHOCKING_EVENTS                      | 294 |
| PED_FLAG_DISABLE_PED_CONSTRAINTS                      | 301 |
| PED_FLAG_IS_IN_CLUSTER                                | 310 |
| PED_FLAG_NO_PED_MELEE                                 | 314 |
| PED_FLAG_HAS_HIGH_HEELS                               | 322 |
| PED_FLAG_DISABLE_TALK_TO                              | 329 |
| PED_FLAG_DONT_BLIP                                    | 330 |
| PED_FLAG_IS_SWITCHING_WEAPON                          | 331 |
| PED_FLAG_EQUIP_JETPACK                                | 349 |
| PED_FLAG_IS_DUCKING_IN_VEHICLE                        | 359 |
| PED_FLAG_HAS_RESERVE_PARACHUTE                        | 362 |
| PED_FLAG_USE_RESERVE_PARACHUTE                        | 363 |
| PED_FLAG_NEVER_LEAVE_TRAIN                            | 374 |
| PED_FLAG_IS_CLIMBING_LADDER                           | 388 |
| PED_FLAG_HAS_BARE_FEET                                | 389 |
| PED_FLAG_ALPHA                                        | 410 |
| PED_FLAG_IS_HOLSTERING_WEAPON                         | 413 |
| PED_FLAG_IS_SWITCHING_HELMET_VISOR                    | 418 |
| PED_FLAG_FLAMING_FOOTPRINTS                           | 421 |
| PED_FLAG_DISABLE_VEHICLE_COMBAT                       | 422 |
| PED_FLAG_DISABLE_PROP_KNOCK_OFF                       | 423 |
| PED_FLAG_FALLS_LIKE_AIRCRAFT                          | 424 |
| PED_FLAG_DISABLE_STARTING_VEHICLE_ENGINE              | 429 |
| PED_FLAG_IGNORE_BEING_ON_FIRE                         | 430 |
| PED_FLAG_DISABLE_HOMING_MISSILE_LOCKON                | 434 |
| PED_FLAG_DISABLE_HELMET_ARMOR                         | 438 |
| PED_FLAG_IS_ARRESTING                                 | 450 |
| PED_FLAG_IS_DECOY_PED                                 | 451 |
| PED_FLAG_CAN_BE_INCAPACITATED                         | 456 |
| PED_FLAG_MUTABLE_FORCED_AIM                           | 457 |

## Config Flag Enum

```ts
export enum PedConfigFlag {
    NoCriticalHits = 2,
    DrownsInWater = 3,
    DisableReticuleFixedLockon = 4,
    UpperBodyDamageAnimsOnly = 7,
    NeverLeavesGroup = 13,
    BlockNonTemporaryEvents = 17,
    CanPunch = 18,
    IgnoreSeenMelee = 24,
    CanFlyThruWindscreen = 32,
    DiesWhenRagdoll = 33,
    HasHelmet = 34,
    PutOnMotorcycleHelmet = 35,
    DisableEvasiveDives = 39,
    DontInfluenceWantedLevel = 42,
    DisablePlayerLockon = 43,
    DisableLockonToRandomPeds = 44,
    BeingDeleted = 47,
    BlockWeaponSwitching = 48,
    NoCollision = 52,
    IsShooting = 58,
    WasShooting = 59,
    IsOnGround = 60,
    WasOnGround = 61,
    InVehicle = 62,
    OnMount = 63,
    AttachedToVehicle = 64,
    IsSwimming = 65,
    WasSwimming = 66,
    IsSkiing = 67,
    IsSitting = 68,
    KilledByStealth = 69,
    KilledByTakedown = 70,
    Knockedout = 71,
    IsSniperScopeActive = 72,
    SuperDead = 73,
    UsingCoverPoint = 75,
    IsInTheAir = 76,
    IsAimingGun = 78,
    ForcePedLoadCover = 93,
    VaultFromCover = 97,
    IsDrunk = 100,
    ForcedAim = 101,
    IsNotRagdollAndNotPlayingAnim = 104,
    ForceReload = 105,
    BumpedByPlayer = 117,
    IsHandCuffed = 120,
    IsAnkleCuffed = 121,
    DisableMelee = 122,
    NmMessage466 = 125,
    CanBeAgitated = 128,
    IsScuba = 135,
    WillArrestRatherThanJack = 136,
    RidingTrain = 138,
    ArrestResult = 139,
    CanAttackFriendly = 140,
    ShootingAnimFlag = 145,
    DisableLadderClimbing = 146,
    StairsDetected = 147,
    SlopeDetected = 148,
    CanPerformArrest = 155,
    CanPerformUncuff = 156,
    CanBeArrested = 157,
    IsInjured = 166,
    IsInjured2 = 170,
    IsInCustody = 180,
    IsAgitated = 183,
    PreventAutoShuffleToDriversSeat = 184,
    EnableWeaponBlocking = 186,
    HasHurtStarted = 187,
    DisableHurt = 188,
    PlayerIsWeird = 189,
    UsingScenario = 194,
    VisibleOnScreen = 195,
    DisableExplosionReactions = 208,
    DodgedPlayer = 209,
    DontEnterLeadersVehicle = 220,
    Shrink = 223,
    MeleeCombat = 224,
    DisablePotentialToBeWalkedIntoResponse = 225,
    DisablePedAvoidance = 226,
    DisablePanicInVehicle = 229,
    IsHoldingProp = 236,
    BlocksPathingWhenDead = 237,
    DisableStoppingVehicleEngine = 241,
    CanPlayInCarIdles = 248,
    IsOnStairs = 253,
    IsOnStairsSlope = 270,
    DontBlipCop = 272,
    ClimbedShiftedFence = 273,
    EdgeDetected = 276,
    AvoidTearGas = 279,
    NoWrithe = 281,
    RagdollingOnBoat = 287,
    HasBrandishedWeapon = 288,
    FreezePosition = 292,
    DisableShockingEvents = 294,
    DisablePedConstraints = 301,
    IsInCluster = 310,
    NoPedMelee = 314,
    HasHighHeels = 322,
    DisableTalkTo = 329,
    DontBlip = 330,
    IsSwitchingWeapon = 331,
    EquipJetpack = 349,
    IsDuckingInVehicle = 359,
    HasReserveParachute = 362,
    UseReserveParachute = 363,
    NeverLeaveTrain = 374,
    IsClimbingLadder = 388,
    HasBareFeet = 389,
    Alpha = 410,
    IsHolsteringWeapon = 413,
    IsSwitchingHelmetVisor = 418,
    FlamingFootprints = 421,
    DisableVehicleCombat = 422,
    DisablePropKnockOff = 423,
    FallsLikeAircraft = 424,
    DisableStartingVehicleEngine = 429,
    IgnoreBeingOnFire = 430,
    DisableHomingMissileLockon = 434,
    DisableHelmetArmor = 438,
    IsArresting = 450,
    IsDecoyPed = 451,
    CanBeIncapacitated = 456,
    MutableForcedAim = 457
}
```
