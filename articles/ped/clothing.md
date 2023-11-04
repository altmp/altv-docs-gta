# Clothing

Starting with the alt:V 4.0 release, in addition to setting the clothes on the client side (native: setPedComponentVariation), it is also possible to set them on the server side (setClothes, setDlcClothes, setProp, setDlcProp).

> [!CAUTION]
> The synchronization of client-side set clothing is valid until the first time a server-side setter is used. To realize the client-side preview of clothes it is recommended to [clone the player's ped](https://docs.altv.mp/articles/ped.html) and display the clothes on this ped (either with natives or using setPedDlcClothes & setPedDlcProp).

> [!TIP]
> See <a href='https://forge.plebmasters.de/clothes'>Pleb Masters: Forge</a> for a full list of freemode ped clothes.

## Introduction

The utilization of the server-side setters is divided into 2 variants:
- normal setters, which are used like the natives
- dlc setters, which are used differently, but are less prone to gta updates and new clothing resources

## Usage

> [!TIP]
> - `setClothes` [JS](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setClothes) [C#](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.IPlayer.html#AltV_Net_Elements_Entities_IPlayer_SetClothes_System_Byte_System_UInt16_System_Byte_System_Byte_)
> - `setDlcClothes` [JS](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setDlcClothes) [C#](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.IPlayer.html#AltV_Net_Elements_Entities_IPlayer_SetDlcClothes_System_Byte_System_UInt16_System_Byte_System_Byte_System_UInt32_)
> - `setProp` [JS](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setProp) [C#](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.IPlayer.html#AltV_Net_Elements_Entities_IPlayer_SetProps_System_Byte_System_UInt16_System_Byte_)
> - `setDlcProp` [JS](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setDlcProp) [C#](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.IPlayer.html#AltV_Net_Elements_Entities_IPlayer_SetDlcProps_System_Byte_System_UInt16_System_Byte_System_UInt32_)
> - Remark: hairs are also clothes and therefor set by the setClothes function.

While the `setClothes` function is basically equivalent to the native `setPedComponentVariation`, the `setDlcClothes` function has a slightly different functionality.

In addition to the parameters of the `setClothes` function, the `setDlcClothes` function requires a dlc and uses relative rather than absolute ids for the clothes.
The biggest advantage of using the dlc setter is that if the ids of the clothing shift (due to a gta update or an additional clothing resource that changes the load order), the relative dlc ids are still preserved. An adjustment of the clothing is therefore not necessary and everything can be used as usual.

> [!CAUTION]
> Internally `setClothes` uses clothes.bin, which contains a mapping of the ids to the appropriate gta dlcs. Because of this `setClothes` can not be used with own dlc resources, otherwise this can not be synced. To use own dlc resources `setDlcClothes` is mandatory.

Let's take the t-shirt with the drawable id 133 as example:
It can either be set via setClothes (`player.setClothes(11, 133, 0)`) or via setDlcClothes (`player.setDlcClothes(alt.hash("mp_m_executive_01"), 11, 4, 0)`).
If Rockstar were to append another piece of clothing to the first dlc pack, the setClothes function would point to a different piece of clothing than which was originally used.
The setDlcClothes function, on the other hand, is not affected because the used dlc pack has not changed.

The usage of `setProp` (equivalent to `setPedPropIndex`) and `setDlcProp` is the same as the cloth functions.

> [!TIP]
> As noted, the use of `setDlcClothes` and `setDlcProp` requires the specification of a dlc hash.
> If the dlc hash is not known, it can be found in the respective meta file at the entry "dlcName" (needs to be hashed first).

## Troubleshooting

### "clothes override data" error in console

If you combine the client-side and server-side functions to set clothes, sooner or later you will encounter the following error message:

```
clothes gta data 00000000000000111111011110
clothes override data 00000000000000111111011010
```

In order to analyze this error message in detail, special attention must be paid to which of the components is causing the error, as this also gives clues to the particular location of the code where it is used.

| Component | 25 | 24 | 23 | 22 | 21 | 20 | 19 | 18 | 17 | 16 | 15 | 14 | 13 | 12 | 11 | 10 | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
| --------- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | - | - | - | - | - | - | - | - | - | - |
| GTA data | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 | 1 | 1 | 0 | 1 | 1 | 1 | 1 | 0 |
| Override data | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 | 1 | 1 | 0 | 1 | 1 | 0 | 1 | 0 |

As the analysis of these lines shows, the clothing mismatch is located at the component with id 2, which corresponds to the hair.
The next step to solve this problem would be to check in the code where the hair is set (e.g. hairdresser or character creation) and switch to the server-side setter there.

### Clothing tool dlcs not found

If you use the alt:V clothing tool to create the resources, please note that the clothes collection name is not the same as the dlc name used by gta. The collection name must be appended with `mp_m_` for male clothes and `mp_f_` for female clothes.

For example, if your collection name is `myAddonClothes`, the dlc names will be `mp_m_myAddonClothes` and `mp_f_myAddonClothes`.
