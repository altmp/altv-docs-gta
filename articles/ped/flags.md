# Ped Config Flags

Ped config flags are flags that configure behaviour or show states of peds.
Flag means: that the value of the variable can only be 0 or 1 (false or true). The flags can be read with <a href="https://natives.altv.mp/#/0x7EE53118C892B513" target="_blank">getPedConfigFlag</a> and written with <a href="https://natives.altv.mp/#/0x1913FE4CBF41C463" target="_blank">setPedConfigFlag</a>.

| Name | Flag ID |
| ---- | ------- |
| PED_FLAG_NO_CRITICAL_HITS | 2 |
| PED_FLAG_DROWNS_IN_WATER | 3 |
| PED_FLAG_DISABLE_RETICULE_FIXED_LOCKON | 4 |
| PED_FLAG_UPPER_BODY_DAMAGE_ANIMS_ONLY | 7 |
| PED_FLAG_NEVER_LEAVES_GROUP | 13 |
| PED_FLAG_BLOCK_NON_TEMPORARY_EVENTS | 17 |
| PED_FLAG_CAN_PUNCH | 18 |
| PED_FLAG_IGNORE_SEEN_MELEE | 24 |
| PED_FLAG_GET_OUT_UNDRIVEABLE_VEHICLE | 29 |
| PED_FLAG_CAN_FLY_THRU_WINDSCREEN | 32 |
| PED_FLAG_DIES_WHEN_RAGDOLL | 33 |
| PED_FLAG_HAS_HELMET | 34 |
| PED_FLAG_PUT_ON_MOTORCYCLE_HELMET | 35 |
| PED_FLAG_DONT_TAKE_OFF_HELMET | 36 |
| PED_FLAG_DISABLE_EVASIVE_DIVES | 39 |
| PED_FLAG_DONT_INFLUENCE_WANTED_LEVEL | 42 |
| PED_FLAG_DISABLE_PLAYER_LOCKON | 43 |
| PED_FLAG_DISABLE_LOCKON_TO_RANDOM_PEDS | 44 |
| PED_FLAG_ALLOW_LOCKON_TO_FRIENDLY_PLAYERS | 45 |
| PED_FLAG_BEING_DELETED | 47 |
| PED_FLAG_BLOCK_WEAPON_SWITCHING | 48 |
| PED_FLAG_NO_COLLISION | 52 |
| PED_FLAG_IS_SHOOTING | 58 |
| PED_FLAG_WAS_SHOOTING | 59 |
| PED_FLAG_IS_ON_GROUND | 60 |
| PED_FLAG_WAS_ON_GROUND | 61 |
| PED_FLAG_IN_VEHICLE | 62 |
| PED_FLAG_ON_MOUNT | 63 |
| PED_FLAG_ATTACHED_TO_VEHICLE | 64 |
| PED_FLAG_IS_SWIMMING | 65 |
| PED_FLAG_WAS_SWIMMING | 66 |
| PED_FLAG_IS_SKIING | 67 |
| PED_FLAG_IS_SITTING | 68 |
| PED_FLAG_KILLED_BY_STEALTH | 69 |
| PED_FLAG_KILLED_BY_TAKEDOWN | 70 |
| PED_FLAG_KNOCKEDOUT | 71 |
| PED_FLAG_IS_SNIPER_SCOPE_ACTIVE | 72 |
| PED_FLAG_SUPER_DEAD | 73 |
| PED_FLAG_USING_COVER_POINT | 75 |
| PED_FLAG_IS_IN_THE_AIR | 76 |
| PED_FLAG_IS_AIMING_GUN | 78 |
| PED_FLAG_FORCE_PED_LOAD_COVER | 93 |
| PED_FLAG_VAULT_FROM_COVER | 97 |
| PED_FLAG_IS_DRUNK | 100 |
| PED_FLAG_FORCED_AIM | 101 |
| PED_FLAG_IS_NOT_RAGDOLL_AND_NOT_PLAYING_ANIM | 104 |
| PED_FLAG_FORCE_RELOAD | 105 |
| PED_FLAG_DONT_ACTIVATE_RAGDOLL_FROM_VEHICLE_IMPACT | 106 |
| PED_FLAG_DONT_ACTIVATE_RAGDOLL_FROM_BULLET_IMPACT | 107 |
| PED_FLAG_DONT_ACTIVATE_RAGDOLL_FROM_EXPLOSIONS | 108 |
| PED_FLAG_DONT_ACTIVATE_RAGDOLL_FROM_FIRE | 109 |
| PED_FLAG_DONT_ACTIVATE_RAGDOLL_FROM_ELECTROCUTION | 110 |
| PED_FLAG_KEEP_WEAPON_HOLSTERED_UNLESS_FIRED | 113 |
| PED_FLAG_GET_OUT_BURNING_VEHICLE | 116 |
| PED_FLAG_BUMPED_BY_PLAYER | 117 |
| PED_FLAG_RUN_FROM_FIRES_AND_EXPLOSIONS | 118 |
| PED_FLAG_TREAT_AS_PLAYER_DURING_TARGETING | 119 |
| PED_FLAG_IS_HAND_CUFFED | 120 |
| PED_FLAG_IS_ANKLE_CUFFED | 121 |
| PED_FLAG_DISABLE_MELEE | 122 |
| PED_FLAG_DISABLE_UNARMED_DRIVEBYS | 123 |
| PED_FLAG_JUST_GETS_PULLED_OUT_WHEN_ELECTROCUTED | 124 |
| PED_FLAG_NM_MESSAGE466 | 125 |
| PED_FLAG_WILL_NOT_HOTWIRE_LAW_ENFORCEMENT_VEHICLE | 126 |
| PED_FLAG_WILL_COMMANDEER_RATHER_THAN_JACK | 127 |
| PED_FLAG_CAN_BE_AGITATED | 128 |
| PED_FLAG_FORCE_PED_TO_FACE_LEFT_IN_COVER | 129 |
| PED_FLAG_FORCE_PED_TO_FACE_RIGHT_IN_COVER | 130 |
| PED_FLAG_BLOCK_PED_FROM_TURNING_IN_COVER | 131 |
| PED_FLAG_KEEP_RELATIONSHIP_GROUP_AFTER_CLEAN_UP | 132 |
| PED_FLAG_FORCE_PED_TO_BE_DRAGGED | 133 |
| PED_FLAG_PREVENT_PED_FROM_REACTING_TO_BEING_JACKED | 134 |
| PED_FLAG_IS_SCUBA | 135 |
| PED_FLAG_WILL_ARREST_RATHER_THAN_JACK | 136 |
| PED_FLAG_REMOVE_DEAD_EXTRA_FAR_AWAY | 137 |
| PED_FLAG_RIDING_TRAIN | 138 |
| PED_FLAG_ARREST_RESULT | 139 |
| PED_FLAG_CAN_ATTACK_FRIENDLY | 140 |
| PED_FLAG_WILL_JACK_ANY_PLAYER | 141 |
| PED_FLAG_WILL_JACK_WANTED_PLAYERS_RATHER_THAN_STEAL_CAR | 144 |
| PED_FLAG_SHOOTING_ANIM_FLAG | 145 |
| PED_FLAG_DISABLE_LADDER_CLIMBING | 146 |
| PED_FLAG_STAIRS_DETECTED | 147 |
| PED_FLAG_SLOPE_DETECTED | 148 |
| PED_FLAG_COWER_INSTEAD_OF_FLEE | 150 |
| PED_FLAG_CAN_ACTIVATE_RAGDOLL_WHEN_VEHICLE_UPSIDE_DOWN | 151 |
| PED_FLAG_ALWAYS_RESPOND_TO_CRIES_FOR_HELP | 152 |
| PED_FLAG_DISABLE_BLOOD_POOL_CREATION | 153 |
| PED_FLAG_SHOULD_FIX_IF_NO_COLLISION | 154 |
| PED_FLAG_CAN_PERFORM_ARREST | 155 |
| PED_FLAG_CAN_PERFORM_UNCUFF | 156 |
| PED_FLAG_CAN_BE_ARRESTED | 157 |
| PED_FLAG_PLAYER_PREFER_FRONT_SEAT_MP | 159 |
| PED_FLAG_IS_INJURED | 166 |
| PED_FLAG_DONT_ENTER_VEHICLES_IN_PLAYERS_GROUP | 167 |
| PED_FLAG_PREVENT_ALL_MELEE_TAUNTS | 169 |
| PED_FLAG_IS_INJURED2 | 170 |
| PED_FLAG_ALWAYS_SEE_APPROACHING_VEHICLES | 171 |
| PED_FLAG_CAN_DIVE_AWAY_FROM_APPROACHING_VEHICLES | 172 |
| PED_FLAG_ALLOW_PLAYER_TO_INTERRUPT_VEHICLE_ENTRY_EXIT | 173 |
| PED_FLAG_ONLY_ATTACK_LAW_IF_PLAYER_IS_WANTED | 174 |
| PED_FLAG_PEDS_JACKING_ME_DONT_GET_IN | 177 |
| PED_FLAG_PED_IGNORES_ANIM_INTERRUPT_EVENTS | 179 |
| PED_FLAG_IS_IN_CUSTODY | 180 |
| PED_FLAG_FORCE_STANDARD_BUMP_REACTION_THRESHOLDS | 181 |
| PED_FLAG_LAW_WILL_ONLY_ATTACK_IF_PLAYER_IS_WANTED | 182 |
| PED_FLAG_IS_AGITATED | 183 |
| PED_FLAG_PREVENT_AUTO_SHUFFLE_TO_DRIVERS_SEAT | 184 |
| PED_FLAG_USE_KINEMATIC_MODE_WHEN_STATIONARY | 185 |
| PED_FLAG_ENABLE_WEAPON_BLOCKING | 186 |
| PED_FLAG_HAS_HURT_STARTED | 187 |
| PED_FLAG_DISABLE_HURT | 188 |
| PED_FLAG_PLAYER_IS_WEIRD | 189 |
| PED_FLAG_DO_NOTHING_WHEN_ON_FOOT_BY_DEFAULT | 193 |
| PED_FLAG_USING_SCENARIO | 194 |
| PED_FLAG_VISIBLE_ON_SCREEN | 195 |
| PED_FLAG_DONT_ACTIVATE_RAGDOLL_ON_VEHICLE_COLLISION_WHEN_DEAD | 199 |
| PED_FLAG_HAS_BEEN_IN_ARMED_COMBAT | 200 |
| PED_FLAG_AVOIDANCE_IGNORE_ALL | 202 |
| PED_FLAG_AVOIDANCE_IGNORED_BY_ALL | 203 |
| PED_FLAG_AVOIDANCE_IGNORE_GROUP1 | 204 |
| PED_FLAG_AVOIDANCE_MEMBER_OF_GROUP1 | 205 |
| PED_FLAG_FORCED_TO_USE_SPECIFIC_GROUP_SEAT_INDEX | 206 |
| PED_FLAG_DISABLE_EXPLOSION_REACTIONS | 208 |
| PED_FLAG_DODGED_PLAYER | 209 |
| PED_FLAG_WAITING_FOR_PLAYER_CONTROL_INTERRUPT | 210 |
| PED_FLAG_FORCED_TO_STAY_IN_COVER | 211 |
| PED_FLAG_GENERATES_SOUND_EVENTS | 212 |
| PED_FLAG_LISTENS_TO_SOUND_EVENTS | 213 |
| PED_FLAG_ALLOW_TO_BE_TARGETED_IN_A_VEHICLE | 214 |
| PED_FLAG_WAIT_FOR_DIRECT_ENTRY_POINT_TO_BE_FREE_WHEN_EXITING | 215 |
| PED_FLAG_ONLY_REQUIRE_ONE_PRESS_TO_EXIT_VEHICLE | 216 |
| PED_FLAG_FORCE_EXIT_TO_SKY_DIVE | 217 |
| PED_FLAG_DONT_ENTER_LEADERS_VEHICLE | 220 |
| PED_FLAG_DISABLE_EXIT_TO_SKY_DIVE | 221 |
| PED_FLAG_SHRINK | 223 |
| PED_FLAG_MELEE_COMBAT | 224 |
| PED_FLAG_DISABLE_POTENTIAL_TO_BE_WALKED_INTO_RESPONSE | 225 |
| PED_FLAG_DISABLE_PED_AVOIDANCE | 226 |
| PED_FLAG_FORCE_RAGDOLL_UPON_DEATH | 227 |
| PED_FLAG_DISABLE_PANIC_IN_VEHICLE | 229 |
| PED_FLAG_ALLOWED_TO_DETACH_TRAILER | 230 |
| PED_FLAG_IS_HOLDING_PROP | 236 |
| PED_FLAG_BLOCKS_PATHING_WHEN_DEAD | 237 |
| PED_FLAG_FORCE_SKIN_CHARACTER_CLOTH | 240 |
| PED_FLAG_DISABLE_STOPPING_VEHICLE_ENGINE | 241 |
| PED_FLAG_PHONE_DISABLE_TEXTING_ANIMATIONS | 242 |
| PED_FLAG_PHONE_DISABLE_TALKING_ANIMATIONS | 243 |
| PED_FLAG_PHONE_DISABLE_CAMERA_ANIMATIONS | 244 |
| PED_FLAG_DISABLE_BLIND_FIRING_IN_SHOT_REACTIONS | 245 |
| PED_FLAG_ALLOW_NEARBY_COVER_USAGE | 246 |
| PED_FLAG_CAN_PLAY_IN_CAR_IDLES | 248 |
| PED_FLAG_CAN_ATTACK_NON_WANTED_PLAYER_AS_LAW | 249 |
| PED_FLAG_WILL_TAKE_DAMAGE_WHEN_VEHICLE_CRASHES | 250 |
| PED_FLAG_AI_CAN_DRIVE_PLAYER_AS_REAR_PASSENGER | 251 |
| PED_FLAG_PLAYER_CAN_JACK_FRIENDLY_PLAYERS | 252 |
| PED_FLAG_IS_ON_STAIRS | 253 |
| PED_FLAG_AI_DRIVER_ALLOW_FRIENDLY_PASSENGER_SEAT_ENTRY | 255 |
| PED_FLAG_ALLOW_MISSION_PED_TO_USE_INJURED_MOVEMENT | 257 |
| PED_FLAG_PREVENT_USING_LOWER_PRIORITY_SEATS | 261 |
| PED_FLAG_DISABLE_CLOSING_VEHICLE_DOOR | 264 |
| PED_FLAG_TELEPORT_TO_LEADER_VEHICLE | 268 |
| PED_FLAG_AVOIDANCE_IGNORE_WEIRD_PED_BUFFER | 269 |
| PED_FLAG_ON_STAIR_SLOPE | 270 |
| PED_FLAG_DONT_BLIP_COP | 272 |
| PED_FLAG_CLIMBED_SHIFTED_FENCE | 273 |
| PED_FLAG_KILL_WHEN_TRAPPED | 275 |
| PED_FLAG_EDGE_DETECTED | 276 |
| PED_FLAG_AVOID_TEAR_GAS | 279 |
| PED_FLAG_NO_WRITHE | 281 |
| PED_FLAG_ONLY_USE_FORCED_SEAT_WHEN_ENTERING_HELI_IN_GROUP | 282 |
| PED_FLAG_DISABLE_WEIRD_PED_EVENTS | 285 |
| PED_FLAG_SHOULD_CHARGE_NOW | 286 |
| PED_FLAG_RAGDOLLING_ON_BOAT | 287 |
| PED_FLAG_HAS_BRANDISHED_WEAPON | 288 |
| PED_FLAG_FREEZE_POSITION | 292 |
| PED_FLAG_DISABLE_SHOCKING_EVENTS | 294 |
| PED_FLAG_NEVER_REACT_TO_PED_ON_ROOF | 296 |
| PED_FLAG_DISABLE_SHOCKING_DRIVING_ON_PAVEMENT_EVENTS | 299 |
| PED_FLAG_DISABLE_PED_CONSTRAINTS | 301 |
| PED_FLAG_FORCE_INITIAL_PEEK_IN_COVER | 302 |
| PED_FLAG_DISABLE_JUMPING_FROM_VEHICLES_AFTER_LEADER | 305 |
| PED_FLAG_IS_IN_CLUSTER | 310 |
| PED_FLAG_SHOUT_TO_GROUP_ON_PLAYER_MELEE | 311 |
| PED_FLAG_IGNORED_BY_AUTO_OPEN_DOORS | 312 |
| PED_FLAG_NO_PED_MELEE | 314 |
| PED_FLAG_CHECK_LOS_FOR_SOUND_EVENTS | 315 |
| PED_FLAG_CAN_SAY_FOLLOWED_BY_PLAYER_AUDIO | 317 |
| PED_FLAG_ACTIVATE_RAGDOLL_FROM_MINOR_PLAYER_CONTACT | 318 |
| PED_FLAG_FORCE_POSE_CHARACTER_CLOTH | 320 |
| PED_FLAG_HAS_CLOTH_COLLISION_BOUNDS | 321 |
| PED_FLAG_HAS_HIGH_HEELS | 322 |
| PED_FLAG_DONT_BEHAVE_LIKE_LAW | 324 |
| PED_FLAG_DISABLE_POLICE_INVESTIGATING_BODY | 326 |
| PED_FLAG_DISABLE_WRITHE_SHOOT_FROM_GROUND | 327 |
| PED_FLAG_LOWER_PRIORITY_OF_WARP_SEATS | 328 |
| PED_FLAG_DISABLE_TALK_TO | 329 |
| PED_FLAG_DONT_BLIP | 330 |
| PED_FLAG_IS_SWITCHING_WEAPON | 331 |
| PED_FLAG_IGNORE_LEG_IK_RESTRICTIONS | 332 |
| PED_FLAG_ALLOW_TASK_DO_NOTHING_TIMESLICING | 339 |
| PED_FLAG_NOT_ALLOWED_TO_JACK_ANY_PLAYERS | 342 |
| PED_FLAG_ALWAYS_LEAVE_TRAIN_UPON_ARRIVAL | 345 |
| PED_FLAG_ONLY_WRITHE_FROM_WEAPON_DAMAGE | 347 |
| PED_FLAG_USE_SLO_MO_BLOOD_VFX | 348 |
| PED_FLAG_EQUIP_JETPACK | 349 |
| PED_FLAG_PREVENT_DRAGGED_OUT_OF_CAR_THREAT_RESPONSE | 350 |
| PED_FLAG_FORCE_DEEP_SURFACE_CHECK | 356 |
| PED_FLAG_DISABLE_DEEP_SURFACE_ANIMS | 357 |
| PED_FLAG_DONT_BLIP_NOT_SYNCED | 358 |
| PED_FLAG_IS_DUCKING_IN_VEHICLE | 359 |
| PED_FLAG_PREVENT_AUTO_SHUFFLE_TO_TURRET_SEAT | 360 |
| PED_FLAG_DISABLE_EVENT_INTERIOR_STATUS_CHECK | 361 |
| PED_FLAG_HAS_RESERVE_PARACHUTE | 362 |
| PED_FLAG_USE_RESERVE_PARACHUTE | 363 |
| PED_FLAG_TREAT_DISLIKE_AS_HATE_WHEN_IN_COMBAT | 364 |
| PED_FLAG_ONLY_UPDATE_TARGET_WANTED_IF_SEEN | 365 |
| PED_FLAG_ALLOW_AUTO_SHUFFLE_TO_DRIVERS_SEAT | 366 |
| PED_FLAG_PREVENT_REACTING_TO_SILENCED_CLONE_BULLETS | 372 |
| PED_FLAG_DISABLE_INJURED_CRY_FOR_HELP_EVENTS | 373 |
| PED_FLAG_NEVER_LEAVE_TRAIN | 374 |
| PED_FLAG_DONT_DROP_JETPACK_ON_DEATH | 375 |
| PED_FLAG_DISABLE_AUTO_EQUIP_HELMETS_IN_BIKES | 380 |
| PED_FLAG_IS_CLIMBING_LADDER | 388 |
| PED_FLAG_HAS_BARE_FEET | 389 |
| PED_FLAG_GO_ON_WITHOUT_VEHICLE_IF_IT_IS_UNABLE_TO_GET_BACK_TO_ROAD | 391 |
| PED_FLAG_BLOCK_DROPPING_HEALTH_SNACKS_ON_DEATH | 392 |
| PED_FLAG_FORCE_THREAT_RESPONSE_TO_NON_FRIEND_TO_FRIEND_MELEE_ACTIONS | 394 |
| PED_FLAG_DONT_RESPOND_TO_RANDOM_PEDS_DAMAGE | 395 |
| PED_FLAG_ALLOW_CONTINUOUS_THREAT_RESPONSE_WANTED_LEVEL_UPDATES | 396 |
| PED_FLAG_KEEP_TARGET_LOSS_RESPONSE_ON_CLEANUP | 397 |
| PED_FLAG_PLAYERS_DONT_DRAG_ME_OUT_OF_CAR | 398 |
| PED_FLAG_BROADCAST_REPONDED_TO_THREAT_WHEN_GOING_TO_POINT_SHOOTING | 399 |
| PED_FLAG_IGNORE_PED_TYPE_FOR_IS_FRIENDLY_WITH | 400 |
| PED_FLAG_TREAT_NON_FRIENDLY_AS_HATE_WHEN_IN_COMBAT | 401 |
| PED_FLAG_DONT_LEAVE_VEHICLE_IF_LEADER_NOT_IN_VEHICLE | 402 |
| PED_FLAG_ALLOW_MELEE_REACTION_IF_MELEE_PROOF_IS_ON | 404 |
| PED_FLAG_USE_NORMAL_EXPLOSION_DAMAGE_WHEN_BLOWN_UP_IN_VEHICLE | 407 |
| PED_FLAG_DISABLE_HOMING_MISSILE_LOCK_FOR_VEHICLE_PED_INSIDE | 408 |
| PED_FLAG_DISABLE_TAKE_OFF_SCUBA_GEAR | 409 |
| PED_FLAG_ALPHA | 410 |
| PED_FLAG_LAW_PEDS_CAN_FLEE_FROM_NON_WANTED_PLAYER | 411 |
| PED_FLAG_FORCE_BLIP_SECURITY_PEDS_IF_PLAYER_IS_WANTED | 412 |
| PED_FLAG_IS_HOLSTERING_WEAPON | 413 |
| PED_FLAG_USE_GO_TO_POINT_FOR_SCENARIO_NAVIGATION | 414 |
| PED_FLAG_DONT_CLEAR_LOCAL_PASSENGERS_WANTED_LEVEL | 415 |
| PED_FLAG_BLOCK_AUTO_SWAP_ON_WEAPON_PICKUPS | 416 |
| PED_FLAG_THIS_PED_IS_A_TARGET_PRIORITY_FOR_AI | 417 |
| PED_FLAG_IS_SWITCHING_HELMET_VISOR | 418 |
| PED_FLAG_FORCE_HELMET_VISOR_SWITCH | 419 |
| PED_FLAG_FLAMING_FOOTPRINTS | 421 |
| PED_FLAG_DISABLE_VEHICLE_COMBAT | 422 |
| PED_FLAG_DISABLE_PROP_KNOCK_OFF | 423 |
| PED_FLAG_FALLS_LIKE_AIRCRAFT | 424 |
| PED_FLAG_USE_LOCKPICK_VEHICLE_ENTRY_ANIMATIONS | 426 |
| PED_FLAG_IGNORE_INTERIOR_CHECK_FOR_SPRINTING | 427 |
| PED_FLAG_SWAT_HELI_SPAWN_WITHIN_LAST_SPOTTED_LOCATION | 428 |
| PED_FLAG_DISABLE_STARTING_VEHICLE_ENGINE | 429 |
| PED_FLAG_IGNORE_BEING_ON_FIRE | 430 |
| PED_FLAG_DISABLE_TURRET_OR_REAR_SEAT_PREFERENCE | 431 |
| PED_FLAG_DISABLE_WANTED_HELICOPTER_SPAWNING | 432 |
| PED_FLAG_USE_TARGET_PERCEPTION_FOR_CREATING_AIMED_AT_EVENTS | 433 |
| PED_FLAG_DISABLE_HOMING_MISSILE_LOCKON | 434 |
| PED_FLAG_FORCE_IGNORE_MAX_MELEE_ACTIVE_SUPPORT_COMBATANTS | 435 |
| PED_FLAG_STAY_IN_DEFENSIVE_AREA_WHEN_IN_VEHICLE | 436 |
| PED_FLAG_DONT_SHOUT_TARGET_POSITION | 437 |
| PED_FLAG_DISABLE_HELMET_ARMOR | 438 |
| PED_FLAG_PREVENT_VEH_EXIT_DUE_TO_INVALID_WEAPON | 441 |
| PED_FLAG_IGNORE_NET_SESSION_FRIENDLY_FIRE_CHECK_FOR_ALLOW_DAMAGE | 442 |
| PED_FLAG_DONT_LEAVE_COMBAT_IF_TARGET_PLAYER_IS_ATTACKED_BY_POLICE | 443 |
| PED_FLAG_CHECK_LOCKED_BEFORE_WARP | 444 |
| PED_FLAG_DONT_SHUFFLE_IN_VEHICLE_TO_MAKE_ROOM | 445 |
| PED_FLAG_GIVE_WEAPON_ON_GETUP | 446 |
| PED_FLAG_DONT_HIT_VEHICLE_WITH_PROJECTILES | 447 |
| PED_FLAG_DISABLE_FORCED_ENTRY_FOR_OPEN_VEHICLES_FROM_TRY_LOCKED_DOOR | 448 |
| PED_FLAG_FIRES_DUMMY_ROCKETS | 449 |
| PED_FLAG_IS_ARRESTING | 450 |
| PED_FLAG_IS_DECOY_PED | 451 |
| PED_FLAG_HAS_ESTABLISHED_DECOY | 452 |
| PED_FLAG_BLOCK_DISPATCHED_HELICOPTERS_FROM_LANDING | 453 |
| PED_FLAG_DONT_CRY_FOR_HELP_ON_STUN | 454 |
| PED_FLAG_CAN_BE_INCAPACITATED | 456 |
| PED_FLAG_MUTABLE_FORCED_AIM | 457 |
| PED_FLAG_DONT_CHANGE_TARGET_FROM_MELEE | 458 |

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
    GetOutUndriveableVehicle = 29,
    CanFlyThruWindscreen = 32,
    DiesWhenRagdoll = 33,
    HasHelmet = 34,
    PutOnMotorcycleHelmet = 35,
    DontTakeOffHelmet = 36,
    DisableEvasiveDives = 39,
    DontInfluenceWantedLevel = 42,
    DisablePlayerLockon = 43,
    DisableLockonToRandomPeds = 44,
    AllowLockonToFriendlyPlayers = 45,
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
    IsNotRagdollAndNotPlayingAnim = 104, // OpenDoorArmIK
    ForceReload = 105,
    DontActivateRagdollFromVehicleImpact = 106,
    DontActivateRagdollFromBulletImpact = 107,
    DontActivateRagdollFromExplosions = 108,
    DontActivateRagdollFromFire = 109,
    DontActivateRagdollFromElectrocution = 110,
    KeepWeaponHolsteredUnlessFired = 113,
    GetOutBurningVehicle = 116,
    BumpedByPlayer = 117,
    RunFromFiresAndExplosions = 118,
    TreatAsPlayerDuringTargeting = 119,
    IsHandCuffed = 120,
    IsAnkleCuffed = 121,
    DisableMelee = 122,
    DisableUnarmedDrivebys = 123,
    JustGetsPulledOutWhenElectrocuted = 124,
    NmMessage466 = 125,
    WillNotHotwireLawEnforcementVehicle = 126,
    WillCommandeerRatherThanJack = 127,
    CanBeAgitated = 128,
    ForcePedToFaceLeftInCover = 129,
    ForcePedToFaceRightInCover = 130,
    BlockPedFromTurningInCover = 131,
    KeepRelationshipGroupAfterCleanUp = 132,
    ForcePedToBeDragged = 133,
    PreventPedFromReactingToBeingJacked = 134,
    IsScuba = 135,
    WillArrestRatherThanJack = 136,
    RemoveDeadExtraFarAway = 137,
    RidingTrain = 138,
    ArrestResult = 139,
    CanAttackFriendly = 140,
    WillJackAnyPlayer = 141,
    WillJackWantedPlayersRatherThanStealCar = 144,
    ShootingAnimFlag = 145,
    DisableLadderClimbing = 146,
    StairsDetected = 147,
    SlopeDetected = 148,
    CowerInsteadOfFlee = 150,
    CanActivateRagdollWhenVehicleUpsideDown = 151,
    AlwaysRespondToCriesForHelp = 152,
    DisableBloodPoolCreation = 153,
    ShouldFixIfNoCollision = 154,
    CanPerformArrest = 155,
    CanPerformUncuff = 156,
    CanBeArrested = 157,
    PlayerPreferFrontSeatMP = 159,
    IsInjured = 166,
    DontEnterVehiclesInPlayersGroup = 167,
    PreventAllMeleeTaunts = 169,
    IsInjured2 = 170, // ForceDirectEntry
    AlwaysSeeApproachingVehicles = 171,
    CanDiveAwayFromApproachingVehicles = 172,
    AllowPlayerToInterruptVehicleEntryExit = 173,
    OnlyAttackLawIfPlayerIsWanted = 174,
    PedsJackingMeDontGetIn = 177,
    PedIgnoresAnimInterruptEvents = 179,
    IsInCustody = 180,
    ForceStandardBumpReactionThresholds = 181,
    LawWillOnlyAttackIfPlayerIsWanted = 182,
    IsAgitated = 183,
    PreventAutoShuffleToDriversSeat = 184,
    UseKinematicModeWhenStationary = 185,
    EnableWeaponBlocking = 186,
    HasHurtStarted = 187,
    DisableHurt = 188,
    PlayerIsWeird = 189,
    DoNothingWhenOnFootByDefault = 193,
    UsingScenario = 194,
    VisibleOnScreen = 195,
    DontActivateRagdollOnVehicleCollisionWhenDead = 199,
    HasBeenInArmedCombat = 200,
    AvoidanceIgnoreAll = 202,
    AvoidanceIgnoredByAll = 203,
    AvoidanceIgnoreGroup1 = 204,
    AvoidanceMemberOfGroup1 = 205,
    ForcedToUseSpecificGroupSeatIndex = 206,
    DisableExplosionReactions = 208,
    DodgedPlayer = 209,
    WaitingForPlayerControlInterrupt = 210,
    ForcedToStayInCover = 211,
    GeneratesSoundEvents = 212,
    ListensToSoundEvents = 213,
    AllowToBeTargetedInAVehicle = 214,
    WaitForDirectEntryPointToBeFreeWhenExiting = 215,
    OnlyRequireOnePressToExitVehicle = 216,
    ForceExitToSkyDive = 217,
    DontEnterLeadersVehicle = 220,
    DisableExitToSkyDive = 221,
    Shrink = 223,
    MeleeCombat = 224,
    DisablePotentialToBeWalkedIntoResponse = 225,
    DisablePedAvoidance = 226,
    ForceRagdollUponDeath = 227,
    DisablePanicInVehicle = 229,
    AllowedToDetachTrailer = 230,
    IsHoldingProp = 236,
    BlocksPathingWhenDead = 237,
    ForceSkinCharacterCloth = 240,
    DisableStoppingVehicleEngine = 241,
    PhoneDisableTextingAnimations = 242,
    PhoneDisableTalkingAnimations = 243,
    PhoneDisableCameraAnimations = 244,
    DisableBlindFiringInShotReactions = 245,
    AllowNearbyCoverUsage = 246,
    CanPlayInCarIdles = 248,
    CanAttackNonWantedPlayerAsLaw = 249,
    WillTakeDamageWhenVehicleCrashes = 250,
    AICanDrivePlayerAsRearPassenger = 251,
    PlayerCanJackFriendlyPlayers = 252,
    IsOnStairs = 253,
    AIDriverAllowFriendlyPassengerSeatEntry = 255,
    AllowMissionPedToUseInjuredMovement = 257,
    PreventUsingLowerPrioritySeats = 261,
    DisableClosingVehicleDoor = 264,
    TeleportToLeaderVehicle = 268,
    AvoidanceIgnoreWeirdPedBuffer = 269,
    OnStairSlope = 270,
    DontBlipCop = 272,
    ClimbedShiftedFence = 273,
    KillWhenTrapped = 275,
    EdgeDetected = 276,
    AvoidTearGas = 279,
    NoWrithe = 281, // DisableGoToWritheWhenInjured
    OnlyUseForcedSeatWhenEnteringHeliInGroup = 282,
    DisableWeirdPedEvents = 285,
    ShouldChargeNow = 286,
    RagdollingOnBoat = 287,
    HasBrandishedWeapon = 288,
    FreezePosition = 292,
    DisableShockingEvents = 294,
    NeverReactToPedOnRoof = 296,
    DisableShockingDrivingOnPavementEvents = 299,
    DisablePedConstraints = 301,
    ForceInitialPeekInCover = 302,
    DisableJumpingFromVehiclesAfterLeader = 305,
    IsInCluster = 310,
    ShoutToGroupOnPlayerMelee = 311,
    IgnoredByAutoOpenDoors = 312,
    NoPedMelee = 314, // ForceIgnoreMeleeActiveCombatant
    CheckLoSForSoundEvents = 315,
    CanSayFollowedByPlayerAudio = 317,
    ActivateRagdollFromMinorPlayerContact = 318,
    ForcePoseCharacterCloth = 320,
    HasClothCollisionBounds = 321,
    HasHighHeels = 322,
    DontBehaveLikeLaw = 324,
    DisablePoliceInvestigatingBody = 326,
    DisableWritheShootFromGround = 327,
    LowerPriorityOfWarpSeats = 328,
    DisableTalkTo = 329,
    DontBlip = 330,
    IsSwitchingWeapon = 331,
    IgnoreLegIkRestrictions = 332,
    AllowTaskDoNothingTimeslicing = 339,
    NotAllowedToJackAnyPlayers = 342,
    AlwaysLeaveTrainUponArrival = 345,
    OnlyWritheFromWeaponDamage = 347,
    UseSloMoBloodVfx = 348,
    EquipJetpack = 349,
    PreventDraggedOutOfCarThreatResponse = 350,
    ForceDeepSurfaceCheck = 356,
    DisableDeepSurfaceAnims = 357,
    DontBlipNotSynced = 358,
    IsDuckingInVehicle = 359,
    PreventAutoShuffleToTurretSeat = 360,
    DisableEventInteriorStatusCheck = 361,
    HasReserveParachute = 362,
    UseReserveParachute = 363,
    TreatDislikeAsHateWhenInCombat = 364,
    OnlyUpdateTargetWantedIfSeen = 365,
    AllowAutoShuffleToDriversSeat = 366,
    PreventReactingToSilencedCloneBullets = 372,
    DisableInjuredCryForHelpEvents = 373,
    NeverLeaveTrain = 374,
    DontDropJetpackOnDeath = 375,
    DisableAutoEquipHelmetsInBikes = 380,
    IsClimbingLadder = 388,
    HasBareFeet = 389,
    GoOnWithoutVehicleIfItIsUnableToGetBackToRoad = 391,
    BlockDroppingHealthSnacksOnDeath = 392,
    ForceThreatResponseToNonFriendToFriendMeleeActions = 394,
    DontRespondToRandomPedsDamage = 395,
    AllowContinuousThreatResponseWantedLevelUpdates = 396,
    KeepTargetLossResponseOnCleanup = 397,
    PlayersDontDragMeOutOfCar = 398,
    BroadcastRepondedToThreatWhenGoingToPointShooting = 399,
    IgnorePedTypeForIsFriendlyWith = 400,
    TreatNonFriendlyAsHateWhenInCombat = 401,
    DontLeaveVehicleIfLeaderNotInVehicle = 402,
    AllowMeleeReactionIfMeleeProofIsOn = 404,
    UseNormalExplosionDamageWhenBlownUpInVehicle = 407,
    DisableHomingMissileLockForVehiclePedInside = 408,
    DisableTakeOffScubaGear = 409,
    Alpha = 410, // IgnoreMeleeFistWeaponDamageMult
    LawPedsCanFleeFromNonWantedPlayer = 411,
    ForceBlipSecurityPedsIfPlayerIsWanted = 412,
    IsHolsteringWeapon = 413,
    UseGoToPointForScenarioNavigation = 414,
    DontClearLocalPassengersWantedLevel = 415,
    BlockAutoSwapOnWeaponPickups = 416,
    ThisPedIsATargetPriorityForAI = 417,
    IsSwitchingHelmetVisor = 418,
    ForceHelmetVisorSwitch = 419,
    FlamingFootprints = 421, // UseOverrideFootstepPtFx
    DisableVehicleCombat = 422,
    DisablePropKnockOff = 423,
    FallsLikeAircraft = 424,
    UseLockpickVehicleEntryAnimations = 426,
    IgnoreInteriorCheckForSprinting = 427,
    SwatHeliSpawnWithinLastSpottedLocation = 428,
    DisableStartingVehicleEngine = 429, // DisableStartEngine
    IgnoreBeingOnFire = 430,
    DisableTurretOrRearSeatPreference = 431,
    DisableWantedHelicopterSpawning = 432,
    UseTargetPerceptionForCreatingAimedAtEvents = 433,
    DisableHomingMissileLockon = 434,
    ForceIgnoreMaxMeleeActiveSupportCombatants = 435,
    StayInDefensiveAreaWhenInVehicle = 436,
    DontShoutTargetPosition = 437,
    DisableHelmetArmor = 438,
    PreventVehExitDueToInvalidWeapon = 441,
    IgnoreNetSessionFriendlyFireCheckForAllowDamage = 442,
    DontLeaveCombatIfTargetPlayerIsAttackedByPolice = 443,
    CheckLockedBeforeWarp = 444,
    DontShuffleInVehicleToMakeRoom = 445,
    GiveWeaponOnGetup = 446,
    DontHitVehicleWithProjectiles = 447,
    DisableForcedEntryForOpenVehiclesFromTryLockedDoor = 448,
    FiresDummyRockets = 449,
    IsArresting = 450,
    IsDecoyPed = 451,
    HasEstablishedDecoy = 452,
    BlockDispatchedHelicoptersFromLanding = 453,
    DontCryForHelpOnStun = 454,
    CanBeIncapacitated = 456,
    MutableForcedAim = 457,
    DontChangeTargetFromMelee = 458
}
```
