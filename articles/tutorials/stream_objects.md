﻿# Stream Objects
This tutorial will show how to add custom objects to your server. For this tutorial we will use the [alt:V logo](https://github.com/altmp/altv-example-resources/tree/master/object-addon/stream/assets).

## Two ways to add object dlc

There are two ways to add objects.

1. Simple
2. Long

## Simple way

Just throw the dlc.rpf as resource (available since [v15](https://docs.altv.mp/articles/changelogs/15_0.html))

```
.
├── resources/
│   └── altvlogo/
│       └── dlc.rpf
└── server.toml
```

> [!NOTE]
> `resource.toml` is not even needed!

Add "meteor" resource to `resources` in `server.toml` like this:

```toml
resources = [
  "altvlogo",
  # other resources...
]
```

## Long way

> [!WARNING]
> As of the current state (alt:V 13.x) there are several conditions for the resource name which could crash the client.
> To avoid those crashes, follow those rules for naming the resource:
> 
> - All lowercase
> - No special characters
> - Must begin with a letter
> 
> More information regarding this issue can be found at [GitHub issue #436](https://github.com/altmp/altv-issues/issues/436)

### Suggested tools
* [Open IV](https://openiv.com/)
* [Codewalker](https://www.gta5-mods.com/tools/codewalker-gtav-interactive-3d-map)

### Creating the resources
1. Open the `dlc.rpf` (or however your rpf file is named) archive with one of suggested tools
2. Extract the archive like below:
    * Place all `ydr`, `yft`, `ytd` and other assets in the folder `stream\assets\`. For organizational reasons, these files can be distributed into subfolders  
    * Place all `ytyp` files into the folder `stream\assets\`. Like other files can be distributed into subfolder.
3. You have to specify the ytyp files in the resources stream.toml. More information at the bottom of this article

> [!NOTE]
> 'DLC_ITYP_REQUEST'/'.ytyp' is a special case in [meta] declaration.      
> It must be in the files folder like the object data.            
> If it doesn't load, check the path to the file including upper/lower case in [meta].                     
> Only the auto load is controlled via the [meta] declaration (you save the [alt.loadYtyp](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_loadYtyp) in the script)

### **Folder Structure**
```
altvlogo/
|-> stream/
|    |-> assets/
|    |    |-> tw_altv_logo.ydr
|    \    \-> tw_altv_logo.ytyp
|-> resource.toml
\-> stream.toml
```

### **resource.toml**
```
type = 'dlc'
main = 'stream.toml'

client-files = [ 'stream/*' ]
```

### **stream.toml**
```
files = [ 'stream/assets/*' ]

[meta]
'stream/assets/tw_altv_logo.ytyp' = 'DLC_ITYP_REQUEST'
```

Add the `altvlogo` (folder name is your resource name) to the `server.toml` file inside the resource section.

## Spawning the object

To spawn the object now, use the following snippet:

```js
async function spawnLogo() {
    const modelHash = alt.hash("tw_altv_logo");
    await alt.Utils.requestModel(modelHash);
    native.createObject(modelHash, 0, 0, 100, false, false, false);
}
```
