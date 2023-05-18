# Overwrite Gameconfig Pools
To extend the gameconfig pools, you need to add the following example to your server.toml.

```
[pools]
"DrawableStore" = 240420
```

1. Get the current value and name of a pool from your gameconfig in the update.rpf.
2. Add the name of the pool and the value to extend below the [pools] section.

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