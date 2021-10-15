# Cayo Perico Island
Cayo Perico Island has been added with "The Cayo Perico Heist" Update (mpheist4), the island can be found at 4895.28, -5744.58, 26.351. There are two ways to load the island, never use both at the same time.

# [Load Island & unload Los Santos](#tab/tabid-1)
This method is more performant and better for weak PCs. You need to use setIslandHopperEnabled native function.
```js
alt.on("connectionComplete",()=>{
    let blip = natives.addBlipForCoord(5943.5679611650485, -6272.114833599767,2); // a invisible blip to make the map clickable at the island
    natives.setBlipSprite(blip, 407);
    natives.setBlipScale(blip, 0);
    natives.setBlipAsShortRange(blip, false);
});

let nearIsland = false;

alt.everyTick(() => {
	let distance = alt.Player.local.pos.distanceTo(new alt.Vector3(4840.571, -5174.425, 2.0));

    if(distance < 2000) {
        if(!nearIsland)
        {
            nearIsland = true;
            natives.setIslandHopperEnabled('HeistIsland', true);
            natives.setScenarioGroupEnabled('Heist_Island_Peds', true);
            natives.setAudioFlag("PlayerOnDLCHeist4Island", true);
            natives.setAmbientZoneListStatePersistent("AZL_DLC_Hei4_Island_Zones", true, true);
            natives.setAmbientZoneListStatePersistent("AZL_DLC_Hei4_Island_Disabled_Zones", false, true);
        }
    } else {
        if(nearIsland)
        {
            nearIsland = false;
            natives.setIslandHopperEnabled('HeistIsland', false);
            natives.setScenarioGroupEnabled("Heist_Island_Peds", false);
            natives.setAudioFlag("PlayerOnDLCHeist4Island", false);
            natives.setAmbientZoneListStatePersistent("AZL_DLC_Hei4_Island_Zones", false, false);
            natives.setAmbientZoneListStatePersistent("AZL_DLC_Hei4_Island_Disabled_Zones", false, false);
        }
    }
    if(nearIsland)
    {
        natives.setRadarAsExteriorThisFrame();
        natives.setRadarAsInteriorThisFrame(alt.hash("h4_fake_islandx"), 4700.0, -5145.0, 0, 0);
    }
});
```

# [Load Island & keep Los Santos](#tab/tabid-2)
This method loads all IPLs and keeps Los Santos loaded, this can have a big performance impact on weaker PCs.

> [!TIP]
> - Note: You probably need to run additional natives, to reduce wave size etc.

```js
alt.on("connectionComplete",()=>{
    let blip = natives.addBlipForCoord(5943.5679611650485, -6272.114833599767,2); // a invisible blip to make the map clickable at the island
    natives.setBlipSprite(blip, 407);
    natives.setBlipScale(blip, 0);
    natives.setBlipAsShortRange(blip, false);

    alt.requestIpl("h4_islandairstrip");
    alt.requestIpl("h4_islandairstrip_props");
    alt.requestIpl("h4_islandx_mansion");
    alt.requestIpl("h4_islandx_mansion_props");
    alt.requestIpl("h4_islandx_props");
    alt.requestIpl("h4_islandxdock");
    alt.requestIpl("h4_islandxdock_props");
    alt.requestIpl("h4_islandxdock_props_2");
    alt.requestIpl("h4_islandxtower");
    alt.requestIpl("h4_islandx_maindock");
    alt.requestIpl("h4_islandx_maindock_props");
    alt.requestIpl("h4_islandx_maindock_props_2");
    alt.requestIpl("h4_IslandX_Mansion_Vault");
    alt.requestIpl("h4_islandairstrip_propsb");
    alt.requestIpl("h4_beach");
    alt.requestIpl("h4_beach_props");
    alt.requestIpl("h4_beach_bar_props");
    alt.requestIpl("h4_islandx_barrack_props");
    alt.requestIpl("h4_islandx_checkpoint");
    alt.requestIpl("h4_islandx_checkpoint_props");
    alt.requestIpl("h4_islandx_Mansion_Office");
    alt.requestIpl("h4_islandx_Mansion_LockUp_01");
    alt.requestIpl("h4_islandx_Mansion_LockUp_02");
    alt.requestIpl("h4_islandx_Mansion_LockUp_03");
    alt.requestIpl("h4_islandairstrip_hangar_props");
    alt.requestIpl("h4_IslandX_Mansion_B");
    alt.requestIpl("h4_islandairstrip_doorsclosed");
    alt.requestIpl("h4_Underwater_Gate_Closed");
    alt.requestIpl("h4_mansion_gate_closed");
    alt.requestIpl("h4_aa_guns");
    alt.requestIpl("h4_IslandX_Mansion_GuardFence");
    alt.requestIpl("h4_IslandX_Mansion_Entrance_Fence");
    alt.requestIpl("h4_IslandX_Mansion_B_Side_Fence");
    alt.requestIpl("h4_IslandX_Mansion_Lights");
    alt.requestIpl("h4_islandxcanal_props");
    alt.requestIpl("h4_beach_props_party");
    alt.requestIpl("h4_islandX_Terrain_props_06_a");
    alt.requestIpl("h4_islandX_Terrain_props_06_b");
    alt.requestIpl("h4_islandX_Terrain_props_06_c");
    alt.requestIpl("h4_islandX_Terrain_props_05_a");
    alt.requestIpl("h4_islandX_Terrain_props_05_b");
    alt.requestIpl("h4_islandX_Terrain_props_05_c");
    alt.requestIpl("h4_islandX_Terrain_props_05_d");
    alt.requestIpl("h4_islandX_Terrain_props_05_e");
    alt.requestIpl("h4_islandX_Terrain_props_05_f");
    alt.requestIpl("H4_islandx_terrain_01");
    alt.requestIpl("H4_islandx_terrain_02");
    alt.requestIpl("H4_islandx_terrain_03");
    alt.requestIpl("H4_islandx_terrain_04");
    alt.requestIpl("H4_islandx_terrain_05");
    alt.requestIpl("H4_islandx_terrain_06");
    alt.requestIpl("h4_ne_ipl_00");
    alt.requestIpl("h4_ne_ipl_01");
    alt.requestIpl("h4_ne_ipl_02");
    alt.requestIpl("h4_ne_ipl_03");
    alt.requestIpl("h4_ne_ipl_04");
    alt.requestIpl("h4_ne_ipl_05");
    alt.requestIpl("h4_ne_ipl_06");
    alt.requestIpl("h4_ne_ipl_07");
    alt.requestIpl("h4_ne_ipl_08");
    alt.requestIpl("h4_ne_ipl_09");
    alt.requestIpl("h4_nw_ipl_00");
    alt.requestIpl("h4_nw_ipl_01");
    alt.requestIpl("h4_nw_ipl_02");
    alt.requestIpl("h4_nw_ipl_03");
    alt.requestIpl("h4_nw_ipl_04");
    alt.requestIpl("h4_nw_ipl_05");
    alt.requestIpl("h4_nw_ipl_06");
    alt.requestIpl("h4_nw_ipl_07");
    alt.requestIpl("h4_nw_ipl_08");
    alt.requestIpl("h4_nw_ipl_09");
    alt.requestIpl("h4_se_ipl_00");
    alt.requestIpl("h4_se_ipl_01");
    alt.requestIpl("h4_se_ipl_02");
    alt.requestIpl("h4_se_ipl_03");
    alt.requestIpl("h4_se_ipl_04");
    alt.requestIpl("h4_se_ipl_05");
    alt.requestIpl("h4_se_ipl_06");
    alt.requestIpl("h4_se_ipl_07");
    alt.requestIpl("h4_se_ipl_08");
    alt.requestIpl("h4_se_ipl_09");
    alt.requestIpl("h4_sw_ipl_00");
    alt.requestIpl("h4_sw_ipl_01");
    alt.requestIpl("h4_sw_ipl_02");
    alt.requestIpl("h4_sw_ipl_03");
    alt.requestIpl("h4_sw_ipl_04");
    alt.requestIpl("h4_sw_ipl_05");
    alt.requestIpl("h4_sw_ipl_06");
    alt.requestIpl("h4_sw_ipl_07");
    alt.requestIpl("h4_sw_ipl_08");
    alt.requestIpl("h4_sw_ipl_09");
    alt.requestIpl("h4_islandx_mansion");
    alt.requestIpl("h4_islandxtower_veg");
    alt.requestIpl("h4_islandx_sea_mines");
    alt.requestIpl("h4_islandx");
    alt.requestIpl("h4_islandx_barrack_hatch");
    alt.requestIpl("h4_islandxdock_water_hatch");
    alt.requestIpl("h4_beach_party");
    alt.requestIpl("h4_mph4_terrain_01_grass_0");
    alt.requestIpl("h4_mph4_terrain_01_grass_1");
    alt.requestIpl("h4_mph4_terrain_02_grass_0");
    alt.requestIpl("h4_mph4_terrain_02_grass_1");
    alt.requestIpl("h4_mph4_terrain_02_grass_2");
    alt.requestIpl("h4_mph4_terrain_02_grass_3");
    alt.requestIpl("h4_mph4_terrain_04_grass_0");
    alt.requestIpl("h4_mph4_terrain_04_grass_1");
    alt.requestIpl("h4_mph4_terrain_04_grass_2");
    alt.requestIpl("h4_mph4_terrain_04_grass_3");
    alt.requestIpl("h4_mph4_terrain_05_grass_0");
    alt.requestIpl("h4_mph4_terrain_06_grass_0");
    alt.requestIpl("h4_mph4_airstrip_interior_0_airstrip_hanger");
});

let nearIsland = false;

alt.everyTick(() => {
	let distance = alt.Player.local.pos.distanceTo(new alt.Vector3(4840.571, -5174.425, 2.0));

    if(distance < 2000) {
        if(!nearIsland)
        {
            nearIsland = true;
            natives.setScenarioGroupEnabled('Heist_Island_Peds', true);
            natives.setAudioFlag("PlayerOnDLCHeist4Island", true);
            natives.setAmbientZoneListStatePersistent("AZL_DLC_Hei4_Island_Zones", true, true);
            natives.setAmbientZoneListStatePersistent("AZL_DLC_Hei4_Island_Disabled_Zones", false, true);
            natives.setDeepOceanScaler(0.1);
        }
    } else {
        if(nearIsland)
        {
            nearIsland = false;
            natives.setScenarioGroupEnabled("Heist_Island_Peds", false);
            natives.setAudioFlag("PlayerOnDLCHeist4Island", false);
            natives.setAmbientZoneListStatePersistent("AZL_DLC_Hei4_Island_Zones", false, false);
            natives.setAmbientZoneListStatePersistent("AZL_DLC_Hei4_Island_Disabled_Zones", false, false);
            natives.resetDeepOceanScaler();
        }
    }

    if(nearIsland)
    {
        natives.setRadarAsExteriorThisFrame();
        natives.setRadarAsInteriorThisFrame(alt.hash("h4_fake_islandx"), 4700.0, -5145.0, 0, 0);
    }
});
```

# Used APIs
[everyTick](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_everyTick)
[Vector3()](https://docs.altv.mp/js/api/alt-client.Vector3.html#_altmp_altv_types_alt_client_Vector3_constructor)
[Vector3.distanceTo](https://docs.altv.mp/js/api/alt-client.Vector3.html#_altmp_altv_types_alt_client_Vector3_distanceTo)
[requestIpl](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_requestIpl)
[setIslandHopperEnabled](https://natives.altv.mp/#/0x9A9D1BA639675CF1)
[setAudioFlag](https://natives.altv.mp/#/0xB9EFD5C25018725A)
[setAmbientZoneListStatePersistent](https://natives.altv.mp/#/0xF3638DAE8C4045E1)
[setDeepOceanScaler](https://natives.altv.mp/#/0xB96B00E976BE977F)
[resetDeepOceanScaler](https://natives.altv.mp/#/0x5E5E99285AE812DB)