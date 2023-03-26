# Overwrite Gameconfig Pools
This tutorial show, how you can change the gamepool sizes (requires alt:V v15 and higher).

## Suggested tools
* [OpenIV](https://openiv.com/)

## Creating the resources
1. Create a resource folder with a name of your choice.
2. Create a resource.toml like the example below.
3. Get the current value and name of a pool from your gameconfig in the update.rpf.
4. Add the name of the pool you want to change and the new value below the [pools] section.

## **resource.toml**
```
type = "rpf"

[pools]
"DrawableStore" = 240420
```

## Default raised pools by alt:V

| Pool | Value |
| --- | --- |
| InteriorProxy                 | 2500 |
| DrawableStore                 | 234900 |
| DwdStore                      | 240000 |
| phInstGtaStore                | 16384 |
| fwDynamicArchetypeComponent   | 40000 |
| PortalInst                    | 900 |
| TxdStore                      | 95500 |
| AnimStore                     | 21000 |
| FragmentStore                 | GTA Defaultvalue + 5000 |
| Dummy Object                  | GTA Defaultvalue + 5000 |
| Building                      | 65000 |
| MetaDataStore                 | GTA Defaultvalue + 3000 |
| StaticBounds                  | GTA Defaultvalue + 2000 |
| HandlingData                  | GTA Defaultvalue + 1000 |
| ScaleformStore                | GTA Defaultvalue + 500 |
| MapTypesStore                 | GTA Defaultvalue + 3000 |
| fragInstGta                   | GTA Defaultvalue + 10000 |
| AttachmentExtension           | 860 |
| PtFxAssetStore                | 1300 |
| MapDataStore                  | 15000 |