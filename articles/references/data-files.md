# Data Files

# Data File List
| Key | File type | Root element | Mounter |
| --- | --------- | ------------ | ------- |
| ACTION_TABLE_DEFINITIONS |  |  |  |
| ALTERNATE_VARIATIONS_FILE |  |  | CPedVariationStreamFileMounter |
| AMBIENT_PED_MODEL_SET_FILE |  |  | AmbientModelSetMounter |
| AMBIENT_PROP_MODEL_SET_FILE |  |  | AmbientModelSetMounter |
| AMBIENT_VEHICLE_MODEL_SET_FILE |  |  | AmbientModelSetMounter |
| AUDIO_DYNAMIXDATA |  |  | audMetadataDataFileMounter |
| AUDIO_GAMEDATA |  |  | audMetadataDataFileMounter |
| AUDIO_SOUNDDATA |  |  | audMetadataDataFileMounter |
| AUDIO_SPEECHDATA |  |  | audSpeechDataFileMounter |
| AUDIO_SYNTHDATA |  |  | audMetadataDataFileMounter |
| AUDIO_WAVEPACK | Folder containing wave packs | N/A | audWavePackDataFileMounter |
| CARCOLS_FILE | Vehicle model variation data | CVehicleModelInfoVarGlobal | CVehicleColorsDataFileMounter |
| CLIP_SETS_FILE |  |  | CExtraContentFileMounter |
| CONDITIONAL_ANIMS_FILE |  |  | ConditionalAnimationsMounter |
| CONTENT_UNLOCKING_META_FILE |  |  | CExtraContentFileMounter |
| DLC_ITYP_REQUEST | Equivalent of in level metas | N/A | CDLCItypFileMounter |
| DLC_SCRIPT_METAFILE |  |  | CDLCScriptDataMounter |
| DLC_WEAPON_PICKUPS |  |  | CPickupDataManagerMounter |
| EXPLOSIONFX_FILE |  |  | CVfxExplosionFileMounter |
| EXPLOSION_INFO_FILE |  |  | CExplosionFileMounter |
| EXTRA_FOLDER_MOUNT_DATA |  |  | CExtraContentFileMounter |
| EXTRA_TITLE_UPDATE_DATA |  |  | CExtraContentFileMounter |
| GTXD_PARENTING_DATA | TXD parent/child relationships for maps | CMapParentTxds | CExtraContentFileMounter |
| HANDLING_FILE | Handling data XML | CHandlingDataMgr | CVehicleHandlingFileMounter |
| INTERIOR_PROXY_ORDER_FILE |  |  | CInteriorProxyFileMounter |
| LOADOUTS_FILE |  |  | CExtraContentFileMounter |
| MOVE_NETWORK_DEFS |  |  | CExtraContentFileMounter |
| MP_STATS_DISPLAY_LIST_FILE |  |  | CStatsDisplayListFileMounter |
| MP_STATS_UI_LIST_FILE |  |  | CStatsUIListFileMounter |
| OVERLAY_INFO_FILE |  |  | CExtraContentFileMounter |
| PEDSTREAM_FILE |  |  | CPedVariationStreamFileMounter |
| PED_BOUNDS_FILE |  |  | CPedModelMetaDataFileMounter |
| PED_BRAWLING_STYLE_FILE |  |  | CBrawlingStyleMetaDataFileMounter |
| PED_COMPONENT_SETS_FILE |  |  | CPedModelMetaDataFileMounter |
| PED_DAMAGE_APPEND_FILE |  |  | CPedDamageDataMounter |
| PED_FIRST_PERSON_ALTERNATE_DATA |  |  | CPedVariationStreamFileMounter |
| PED_FIRST_PERSON_ASSET_DATA |  |  | CPedVariationStreamFileMounter |
| PED_METADATA_FILE |  |  | CPedModelMetaDataFileMounter |
| PED_OVERLAY_FILE |  |  | CPedDecorationsDataFileMounter |
| PED_PERCEPTION_FILE |  |  | CPedModelMetaDataFileMounter |
| PED_PERSONALITY_FILE |  |  | CPedModelMetaDataFileMounter |
| PED_TASK_DATA_FILE |  |  | CPedModelMetaDataFileMounter |
| POPSCHED_FILE | Population scheduling data override | N/A | CPopulationDataFileMounter |
| PTFXASSETINFO_FILE |  |  | CVisualEffectsFileMounter |
| SCALEFORM_DLC_FILE |  |  | CScaleformPreallocationDataFileMounter |
| SCENARIO_INFO_FILE |  |  | ScenarioInfoMounter |
| SCENARIO_POINTS_PSO_FILE |  |  | ScenarioPointMounter |
| SCRIPTFX_FILE |  |  | CVFXScriptFileMounter |
| SHOP_PED_APPAREL_META_FILE |  |  | CExtraMetaDataFileMounter |
| SP_STATS_DISPLAY_LIST_FILE |  |  | CStatsDisplayListFileMounter |
| SP_STATS_UI_LIST_FILE |  |  | CStatsUIListFileMounter |
| STREAMING_REQUEST_LISTS_FILE |  |  | SRLMounter |
| TATTOO_SHOP_DLC_FILE |  |  | CExtraMetaDataFileMounter |
| TEXTFILE_METAFILE |  |  | CExtraContentFileMounter |
| TIMECYCLEMOD_FILE |  |  | TimeCycleFileMounter |
| TRAINCONFIGS_FILE |  |  | CTrainConfigFileMounter |
| TRAINTRACK_FILE |  |  | CTrainConfigFileMounter |
| VEHICLEEXTRAS_FILE |  |  | CVehicleExtrasFileMounter |
| VEHICLE_LAYOUTS_FILE |  |  | CVehicleMetadataFileMounter |
| VEHICLE_METADATA_FILE |  |  | CVehicleMetaDataFileMounter |
| VEHICLE_SHOP_DLC_FILE |  |  | CExtraContentFileMounter |
| VEHICLE_VARIATION_FILE |  |  | CVehicleVariationDataFileMounter |
| VFXVEHICLEINFO_FILE |  |  | CVfxVehicleInfoFileMounter |
| WEAPONCOMPONENTSINFO_FILE |  |  | CWeaponComponentDataFileMounter |
| WEAPONINFO_FILE |  |  | CWeaponInfoDataFileMounter |
| WEAPONINFO_FILE_PATCH |  |  | CWeaponInfoDataFileMounter |
| WEAPON_ANIMATIONS_FILE |  |  | CWeaponAnimationsDataFileMounter |
| WEAPON_METADATA_FILE |  |  | CWeaponMetaDataFileMounter |
| WEAPON_SHOP_INFO_METADATA_FILE |  |  | CExtraMetaDataFileMounter |
| ZONEBIND_FILE |  |  | CPopulationDataFileMounter |

# Examples
## Vehicles
```
stream/vehicles.meta: VEHICLE_METADATA_FILE
stream/carvariations.meta: VEHICLE_VARIATION_FILE
stream/dlctext.meta: VEHICLE_VARIATION_FILE
stream/handling.meta: HANDLING_FILE
stream/carcols.meta: CARCOLS_FILE
stream/audio/sfx/dlc_meteor: AUDIO_WAVEPACK
stream/audio/meteor_game.dat: AUDIO_GAMEDATA
stream/audio/meteor_sounds.dat: AUDIO_SOUNDDATA
stream/audio/meteor_amp.dat: AUDIO_SYNTHDATA
```