# Appearance

> [!CAUTION]
> The client-side natives and server-side API is only usable on the freemode (``mp_m_freemode_01`` for male and ``mp_f_freemode_01`` for female) models The synchronization of client-size set appearance is valid until the first time a server-side setter is used. To realize the client-size preview of ped appearance it is recommended to clone the player's ped and set the appearance with the natives previously enumerated.

> [!TIP]
> Only the tatoos (native addPedDecorationFromHashes) have still to be set client-side and is synced even if you use the new Appearance API / Clothes API server-side.

Starting with the alt:V 7.0 release, you are now able set a player appearance server-side, here is a summary of the new methods and their corresponding natives client-side if they have one.

## Usage

### HeadBlendData

> [!WARNING]
> Once you set the player model you must use this method in order to make the other methods work

The "shape" parameters control the shape of the ped's face. The "skin" parameters control the skin tone. ShapeMix and skinMix control how much the first and second IDs contribute,(typically mother and father.) ThirdMix overrides the others in favor of the third IDs. IsParent is set for "children" of the player character's grandparents during old-gen character creation. It has unknown effect otherwise.

The IDs start at zero and go Male Non-DLC, Female Non-DLC, Male DLC, and Female DLC.
[more informations here](gtaforums.com/topic/858970-all-gtao-face-ids-pedset-ped-head-blend-data-explained)

# [client](#tab/tab1-0)
**Set head blend data**
[native](https://natives.altv.mp/#/0x9414E18B9434C2FE)
```js
import * as native from 'natives';
import * as alt from 'alt-client';

const player = alt.Player.local;
const shapeFirstID = 0;
const shapeSecondID = 0;
const shapeThirdID = 0;
const skinFirstID = 0;
const skinSecondID = 0;
const skinThirdID = 0;
const shapeMix = 0;
const skinMix = 0;
const thirdMix = 0;
const isParent = false;

native.setPedHeadBlendData(player, shapeFirstID, shapeSecondID, shapeThirdID, skinFirstID, skinSecondID, skinThirdID, shapeMix, skinMix, thirdMix, isParent);
```
# [server](#tab/tab1-1)
**To set head blend data**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setHeadBlendData)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_SetHeadBlendData_System_UInt32_System_UInt32_System_UInt32_System_UInt32_System_UInt32_System_UInt32_System_Single_System_Single_System_Single_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const shapeFirstID = 0;
const shapeSecondID = 0;
const shapeThirdID = 0;
const skinFirstID = 0;
const skinSecondID = 0;
const skinThirdID = 0;
const shapeMix = 0;
const skinMix = 0;
const thirdMix = 0;

player.setHeadBlendData(shapeFirstID, shapeSecondID, shapeThirdID, skinFirstID, skinSecondID, skinThirdID, shapeMix, skinMix, thirdMix);
```

**To get head blend data**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_getHeadBlendData)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_HeadBlendData)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
player.getHeadBlendData();
```
***

#### Head blend palette color

> [!WARNING]
> There is no client-side native for it

**To set head blend palette color**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setHeadBlendPaletteColor)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_SetHeadBlendPaletteColor_System_Byte_AltV_Net_Data_Rgba_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const id = 0;
const color = new alt.RGBA(100, 150, 200);
const red = color.r;
const green = color.g;
const blue = color.b;

player.setHeadBlendPaletteColor(id, red, green, blue);
```

**To get head blend palette color**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_getHeadBlendPaletteColor)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_GetHeadBlendPaletteColor_System_Byte_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const id = 0;

player.getHeadBlendPaletteColor(id);
```

### Face feature

Index ranges from 0 to 19. e.g. nose length, chin shape.
Scale ranges from -1.0 to 1.0.

# [client](#tab/tab2-0)
**To set face feature**
[native](https://natives.altv.mp/#/0x71A5C1DBA060049E)
```js
import * as native from 'natives';
import * as alt from 'alt-client';

const index = 0;
const scale = 0.5;

native.setPedFaceFeature(alt.Player.local, index, scale);
```
# [server](#tab/tab2-1)
**To set face feature**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setFaceFeature)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_SetFaceFeature_System_Byte_System_Single_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const index = 0;
const scale = 0.5;

player.setFaceFeature(index, scale);
```

**To remove face feature**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_removeFaceFeature)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_RemoveFaceFeature_System_Byte_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const index = 0;

player.removeFaceFeature(index);
```

**To get face feature scale**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_getFaceFeatureScale)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_GetFaceFeatureScale_System_Byte_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const index = 0;

player.getFaceFeatureScale(index);
```
***

### Head overlay

OverlayID ranges from 0 to 12. eg. Blemishes, Facial hair.
Index goes from 0 to [getPedHeadOverlayNum](https://natives.altv.mp/#/0xCF1CE768BB43480E) - 1.
opacity goes from 0.0 to 1.0.

# [client](#tab/tab3-0)
**To set head overlay**
[native](https://natives.altv.mp/#/0x48F44967FA05CC1E)
```js
import * as native from 'natives';
import * as alt from 'alt-client';

const overlayID = 0;
const index = 0;
const opacity = 0.5;

native.setPedHeadOverlay(alt.Player.local, overlayID, index, opacity);
```

**To get head overlay**
[native](https://natives.altv.mp/#/0xA60EF3B6461A4D43)
```js
import * as native from 'natives';
import * as alt from 'alt-client';

native.getPedHeadOverlayValue(alt.Player.local, overlayID);
```
# [server](#tab/tab3-1)
**To set head overlay**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setHeadOverlay)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_SetHeadOverlay_System_Byte_System_Byte_System_Single_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const overlayID = 0;
const index = 0;

player.setHeadOverlay(overlayID, index, opacity);
```

**To get head overlay**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_getHeadOverlay)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_GetHeadOverlay_System_Byte_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const overlayID = 0;

player.getHeadOverlay(overlayID);
```

**To remove head overlay**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_removeHeadOverlay)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_RemoveHeadOverlay_System_Byte_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const overlayID = 0;

player.removeHeadOverlay(overlayID);
```
***

### HeadOverlayColor

ColorType is 1 for eyebrows, beards, and chest hair
ColorType is 2 for blush and lipstick
ColorType is 0 otherwise.

# [client](#tab/tab3-0)
**To set head overlay color**
[native](https://natives.altv.mp/#/0x497BF74A7B9CB952)
```js
import * as native from 'natives';
import * as alt from 'alt-client';

const ped = alt.Player.local;
const overlayID = 0;
const colorType = 0;
const colorID = 0;
const secondColorID = 0;

native.setPedHeadOverlayColor(ped, overlayID, colorType, colorID, secondColorID);
```
# [server](#tab/tab3-1)
**To set head overlay color**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setHeadOverlayColor)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_SetHeadOverlayColor_System_Byte_System_Byte_System_Byte_System_Byte_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const overlayID = 0;
const colorType = 0;
const colorIndex = 0;
const secondColorIndex = 0;

player.setHeadOverlayColor(overlayID, colorType, colorIndex, secondColorIndex);
```
***

### Eye color

Recommended eye color indexes range is from 1 to 31.

# [client](#tab/tab3-0)
**To set eye color**
[native](https://natives.altv.mp/#/0x50B56988B170AFDF)
```js
import * as native from 'natives';
import * as alt from 'alt-client';

const index = 0;

native.setPedEyeColor(alt.Player.local, index);
```

**To get eye color**
[native](https://natives.altv.mp/#/0x76BBA2CEE66D47E9)
```js
import * as native from 'natives';
import * as alt from 'alt-client';

native.getPedEyeColor(alt.Player.local);
```
# [server](#tab/tab3-1)
**To set eye color**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setEyeColor)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_SetEyeColor_System_UInt16_)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const eyeColor = 0;

player.setEyeColor(eyeColor);
```

**To get eye color**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_getEyeColor)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_EyeColor)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
player.getEyeColor();
```
***

### Hair color

# [client](#tab/tab3-0)
**To set hair color**
[native](https://natives.altv.mp/#/0x4CFFC65454C93A49)
```js
import * as native from 'natives';
import * as alt from 'alt-client';

const ped = alt.Player.local;
const colorID = 0;
const highlightColorID = 0;

native.setPedHairColor(ped, colorID, highlightColorID);
```
# [server](#tab/tab3-1)
**To set hair color**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setHairColor)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_HairColor)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const hairColor = 0;

player.setHairColor(hairColor);
```

**To get hair color**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_getHairColor)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_HairColor)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
player.getHairColor();
```

**To set hair highlight color**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setHairHighlightColor)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_HairHighlightColor)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);
const hairHighlightColor = 0;

player.setHairHighlightColor(hairHighlightColor);
```

**To get hair highlight color**
[JS method](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_getHairHighlightColor)
[C# method](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_HairHighlightColor)
```js
import * as alt from 'alt-server';

const player = alt.Player.getByID(0);

player.getHairHighlightColor();
```

## Troubleshooting

If you combine the client-side and server-side function to set appearance, sooner of later you will encounter error messages in your server console.

When it happens, you must track and remove the client-side functions where you set players appearance in order to remove those logs.