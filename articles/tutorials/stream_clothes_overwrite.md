# Stream Clothes (Overwrite GTA DLC)
This tutorial show, how to add custom clothes for MP Character on your server, if you want to overwrite a existing gta dlc (helpful, if you hit the ymt limit and you can't add custom dlcs anymore).

## Suggested tools 
* [alt:V clothes tool updated by DurtyFree](https://github.com/DurtyFree/altv-cloth-tool/releases/latest)
* [OpenIV](https://openiv.com)
* [Clothes Menu for testing your resource](https://github.com/Nicoo34/Clothes-Menu)


## Creating the resources 
Be sure you have the latest updated Clothes tool, check the link before in the ```Suggested tools``` category

## Get the cloth collection name
In our example we will use the mpsecurity dlc.

1. Open OpenIV and navigate to the correct dlc (e.g update/x64/dlcpacks/mpsecurity).
2. Search the ymt from the clothes (e.g dlc1.rpf/x64/models/cdimages/mp_security_male.rpf).
3. The name would be in this case ``mp_m_freemode_01_mp_m_security.ymt`` so we need to use ``security`` as collection name in the clothes tool.

## Tool tutorial 
1. select the gender for your clothes.
2. imported Clothes appear on the left corner.
3. when you have select all clothes you want to add, just click on ```"Build Project"```.
4. be sure that's alt:V resource is ticked, if it's not for alt:V, you can tick others options.
5. enter the collection name which we got before.
6. open the stream.toml of your generated clothes dlc and remove the ``[meta]`` part of the file and also the 2 generated meta files in the stream folder.
7. in the stream folder you have to rename the ``ped_female.rpf`` and ``ped_male.rpf`` folder to ``dlcName_female.rpf`` and ``dlcName_male.rpf`` (use the correct dlc name here, e.g ``mpsecurity_male.rpf``)
8. add the resource name in your ```server.toml``` and your resource folder into the ```server resource folder```


![First step](~/altv-docs-assets/altv-docs-gta/images/tutorials/stream_clothes/first_overwrite.png)
![Second step](~/altv-docs-assets/altv-docs-gta/images/tutorials/stream_clothes/second_overwrite.png)

## **resource.toml** 
```
type = 'dlc'
main = 'stream.toml'
client-files = [ 'stream/*' ]
```

## **stream.toml**
```
files = [
  'stream/mpsecurity_male.rpf/*'
  'stream/mpsecurity_female.rpf/*'
]
```

## Folder structure 
```
clotheResource/
├─ stream/
│  ├─ mpsecurity_male.rpf/
│  │  ├─ mp_m_freemode_01_mp_m_security/
│  │  │  ├─ accs_000_u.ydd
│  │  │  ├─ accs_diff_000_a_uni.ytd
│  │  ├─ mp_m_freemode_01_mp_m_security.ymt
│  ├─ mpsecurity_female.rpf/
│  │  ├─ mp_f_freemode_01_mp_f_security/
│  │  │  ├─ jbib_000_u.ydd
│  │  │  ├─ jbib_diff_000_a_uni.ytd
│  │  ├─ mp_f_freemode_01_mp_f_security.ymt
├─ resource.toml
├─ stream.toml
```

With this tutorial you can add every clothes you want for your server, GTA5 main characters clothes will not work with this tutorial, same for NPC add-on.
If you have any trouble with your resource, you can ask on the discord modding channel.
