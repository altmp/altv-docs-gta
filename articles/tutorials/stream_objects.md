# Stream Objects
This tutorial will show how to add custom objects to your server. For this tutorial we will use [Billboard Props Pack by War_Reporter](https://www.gta5-mods.com/maps/billboard-props-pack-addon).

## Suggested tools
* [Open IV](https://openiv.com/)
* [Codewalker](https://www.gta5-mods.com/tools/codewalker-gtav-interactive-3d-map)

## Creating the resources
1. Open the `dlc.rpf` (or however your rpf file is named) archive with one of suggested tools
2. Extract the archive like below:
    * Place all `ydr`, `yft`, `ytd` and other assets in the folder `stream\assets\`. For organizational reasons, these files can be distributed into subfolders  
    * Place all `ytyp` files into the folder `stream\`
3. You have to specify the ytyp files in the resources stream.cfg. More information at the bottom of this article

> [!WARNING]
> If your resource does not contain ytyp files it is not possible to spawn the objects using natives.\
> The Data Files List and examples can be found [here](https://docs.altv.mp/gta/articles/references/data-files.html).

## **Folder Structure**
```
billboards/
|-> stream/
|    |-> assets/
|    |    |-> block_01.ydr
|    |    |-> block_02.ydr
|    |    |-> block_03.ydr
|    |    |-> block_04.ydr
|    |    |-> block_05.ydr
|    |    |-> block_06.ydr
|    |    |-> sign_big_01.ydr
|    |    |-> sign_big_02.ydr
|    |    |-> sign_big_03.ydr
|    |    |-> sign_big_04.ydr
|    |    |-> sign_big_05.ydr
|    |    |-> sign_big_06.ydr
|    |    |-> sign_big_07.ydr
|    |    |-> sign_big_08.ydr
|    |    |-> sign_shop_a_01.ydr
|    |    |-> sign_shop_a_02.ydr
|    |    |-> sign_shop_a_03.ydr
|    |    |-> sign_shop_a_04.ydr
|    |    |-> sign_shop_b_01.ydr
|    |    |-> sign_shop_b_01+hidr.ytd
|    |    |-> sign_shop_b_02.ydr
|    |    |-> sign_shop_b_02+hidr.ytd
|    |    |-> sign_shop_b_03.ydr
|    |    |-> sign_shop_b_03+hidr.ytd
|    |    |-> sign_shop_b_04.ydr
|    |    |-> sign_shop_b_04+hidr.ytd
|    |    \-> sign_shop_c_01.ydr
|    \-> def_props.ytyp
|-> resource.cfg
\-> stream.cfg
```

## **resource.cfg**
```
type: dlc,
main: stream.cfg,

client-files: [
  stream/*
]
```

## **stream.cfg**
```
files: [
  stream/assets/*
]

meta: {
  stream/def_props.ytyp: DLC_ITYP_REQUEST
}
```

Add the `billboards` (folder name is your resource name) for the `server.cfg` file.
