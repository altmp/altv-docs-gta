# Game Files

Grand Theft Auto V, based on the RAGE Engine contains several file extensions.
Yet no one knows the meaning or the use behind it.

## Quick Overview
### Prefixes
| Prefix | Platform                      |
| :----: | ----------------------------- |
|   W    | win32pc / win32 / x86 / pc    |
|   Y    | win64pc / win64 / x64 / linux |
|   V    | vita / psp2                   |
|   D    | xboxone / durango             |
|   O    | ps4 / orbis                   |
|   A    | android                       |
|   S    | ios                           |
|   P    | ps5 / prospero                |
|   N    | nx64                          |
|   X    | xbox360 / xenon               |
|   C    | ps3 / psn                     |
|   I    | independent (North-specific)  |

### Suffix

| File   | Contains hi@ | Meaning                     | Usage                                                        |     Explanation      |
| ------ | :----------: | --------------------------- | ------------------------------------------------------------ | :------------------: |
| Y(BN)  |     Yes      | **B**ou**n**ds              | Collision Information                                        | [<< HERE >>](##YBN)  |
| Y(ND)  |      No      | Path **N**o**d**e           | Path Node for NPCs & GPS                                     | [<< HERE >>](##YND)  |
| Y(TD)  |     Yes      | **T**exture **D**irectory   | Compound of Texture Files                                    | [<< HERE >>](##YTD)  |
| Y(TYP) |      No      | Map **Typ**es               | Map Types                                                    | [<< HERE >>](##YTYP) |
| Y(MAP) |      No      | **Map** Data                | Collection of Entities to form a Compound                    | [<< HERE >>](##YMAP) |
| Y(MF)  |      No      | **M**ani**f**est            | Manifest, used to enforce loading of certain [YTYP](##YTYP)s; E.g  used by Entities inside a [YMAP](##YMAP) | [<< HERE >>](##YMF)  |
| Y(FT)  |  Yes (hi_)   | **F**ragmen**t**            | Complex models such as vehicles, destructible objects.       | [<< HERE >>](##YFT)  |
| Y(DD)  |     Yes      | **D**rawable **D**ictionary | Dictionary of multiple drawables (Usually used for LODs).    | [<< HERE >>](##YDD)  |
| Y(DR)  |     Yes      | **Dr**awable                | Generic models, geometry, optional embedded textures and lights. | [<< HERE >>](##YDR)  |
| RPF    |      No      | **R**AGE **P**ack**f**ile   | Production Format, of a compound containing various Files                                    | [<< HERE >>](##RPF)  |


## YBN
[comment]: <> "Collision"

### Explanation

It declares static collisions, usually in connection of a *.yft.

There are two types of YBN's:

| Low Details | High Details |
| ----------- | ------------ |
| name.ybn    | hi@name.ybn  |

Those collisions are formed by primitive shapes and low detailed shaping of the original form.
(See example)

### Example

YBN's are used for buildings and general environment.

<img src="https://i.imgur.com/dFhCsv8.png" alt="Collsion Example" style="zoom: 50%"/>

### Tools

| Preview | Editing            |
| ------- | ------------------ |
| OpenIV  | 3ds Max (GIMS Evo) |
|         | CodeWalker [1]     |
|         | zModeler3          |

1. It only allows the moving and deleting
   Editing based on Polygons is only available in 3ds Max & ZModeler3.

## YND
[comment]: <> "Path Node"

### Explanation
It declares Path Nodes required for NPCs and calculating GPS Routes.

### Example
This is an example inside CodeWalker, how Path Nodes look like
<img src="https://i.imgur.com/nWd2voy.jpeg" alt="Path Nodes" style="zoom: 50%"/>

## YTD
[comment]: <> "Texture Directory"

### Explanation
Combined with [YFT](##YFT)s, there are embedded Texture and external Textures.
This is where [YTD](##YTD)s get to use.

Used dynamic to implement Textures.

### Example
N/A

## YTYP
[comment]: <> "Map Types"

### Explanation
Definition File of YDR Entries.
Required to be used for further creation

### Example
N/A

## YMAP
[comment]: <> "Map Data"

### Explanation
Collection of Entities to form a Compound.
You can create it inside CodeWalker, together with a [YMF (Manifest File)](##YMF)

### Example
This is the YMAP, that gets included into your CodeWalker Project.
It contains several Entities,
<img src="https://i.imgur.com/UaaRsGo.png" alt="YMAP Example" style="zoom: 75%"/>

## YMF
[comment]: <> "Manifest"

### Explanation
Required to tell the Game which files are required to be loaded to make [YMAP](##YMAP)s work.
Usually generated manually inside CodeWalker.

### Example
N/A

## YFT
[comment]: <> "Fragment"

### Explanation
Mainly used for Vehicles, usually contains an High Details alternative.

| Low Details | High Details |
| :---------: | ------------ |
|   name.yft  |  hi@name.yft |

### Example
Inside ZModeler, a vehicle in hi@ format looks like this
<img src="https://i.imgur.com/IeC1hTO.png" alt="YFT Example" style="zoom: 75%"/>

## YDD
[comment]: <> "Drawable Dictionary"

### Explanation
Used for complex Buildings, usually contains several LODs and Models.

### Example
Inside OpenIV, it looks like this
<img src="https://i.imgur.com/AxViAHL.png" alt="YDD Example" style="zoom: 45%"/>

## YDR
[comment]: <> "Drawables"

### Explanation
Small and simple objects, containing embedded textures or external Textures via. [YTD](##YTD)
Used for Entities, which are combined into a [YTYP](##YTYP)

### Example
Inside OpenIV, an YDR looks like this.
<img src="https://i.imgur.com/HahxAnr.png" alt="YDD Example" style="zoom: 45%"/>

## RPF
[comment]: <> "Package File"

### Explanation
Combing several files together, usually used for expanding the base Game with more content.<br>
E.g by Updates

### Example
If we open a RPF with OpenIV to view in it, it will looks like this.<br>
<img src="https://i.imgur.com/poM1LyH.png" alt="YDD Example" style="zoom: 80%"/>

# Credits
[RAGE Engine Glossary](https://rage.re/docs?category=5&tags=gta5&topic=28)