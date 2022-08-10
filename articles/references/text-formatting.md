# Text Formatting

## Sample Snippet

```js
native.beginTextCommandPrint("STRING");
native.addTextComponentSubstringPlayerName("This is an test subtitle shown for 10 seconds.");
native.endTextCommandPrint(10000, true);
```

## Formatting Codes

To improve the formatting of the above shown snippet, Rockstar provides several formatting codes, which are usually between two tildes (~).\
The below tables will list the available formatting codes and describes what they do.

### Colors

> [!TIP]
> Some formatting codes reference hud colors directly. If you don't know about them, take a look at the [hud colors](hud-colors.md) article.

| Label               | Description                                                                                                                                        | Example                                      |
|---------------------|----------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------|
| ~HUD_COLOUR_[Name]~ | Colors the text with the given hud color                                                                                                           | `This is a test ~HUD_COLOUR_RED~subtitle`    |
| ~HC_[Name]~         | Alias for the above command                                                                                                                        | `This is a test ~HC_RED~subtitle`            |
| ~HC_[Number]~       | Same as the commands above, but uses the index instead of the name                                                                                 | `This is a test ~HC_6~subtitle`              |
| ~s~                 | Resets the color                                                                                                                                   | `This is a ~HUD_COLOUR_RED~test~s~ subtitle` |
| ~v~                 | Sets the color to HUD_COLOUR_SCRIPT_VARIABLE, settable by the native [setScriptVariableHudColour](https://natives.altv.mp/#/0xD68A5FF8A3A89874)    | `This is a ~v~test~s~ subtitle`              |
| ~u~                 | Sets the color to HUD_COLOUR_SCRIPT_VARIABLE_2, settable by the native [setScriptVariable2HudColour](https://natives.altv.mp/#/0x16A304E6CB2BFAB9) | `This is a ~u~test~s~ subtitle`              |
| ~w~                 | Sets the color to HUD_COLOUR_WHITE                                                                                                                 | `This is a ~w~test~s~ subtitle`              |
| ~r~                 | Sets the color to HUD_COLOUR_RED                                                                                                                   | `This is a ~r~test~s~ subtitle`              |
| ~g~                 | Sets the color to HUD_COLOUR_GREEN                                                                                                                 | `This is a ~g~test~s~ subtitle`              |
| ~b~                 | Sets the color to HUD_COLOUR_BLUE                                                                                                                  | `This is a ~b~test~s~ subtitle`              |
| ~f~                 | Sets the color to HUD_COLOUR_FRIENDLY                                                                                                              | `This is a ~f~test~s~ subtitle`              |
| ~y~                 | Sets the color to HUD_COLOUR_YELLOW                                                                                                                | `This is a ~y~test~s~ subtitle`              |
| ~c~                 | Sets the color to HUD_COLOUR_MENU_GREY                                                                                                             | `This is a ~c~test~s~ subtitle`              |
| ~t~                 | Sets the color to HUD_COLOUR_MENU_GREY                                                                                                             | `This is a ~t~test~s~ subtitle`              |
| ~o~                 | Sets the color to HUD_COLOUR_ORANGE                                                                                                                | `This is a ~o~test~s~ subtitle`              |
| ~p~                 | Sets the color to HUD_COLOUR_PURPLE                                                                                                                | `This is a ~p~test~s~ subtitle`              |
| ~q~                 | Sets the color to HUD_COLOUR_PINK                                                                                                                  | `This is a ~q~test~s~ subtitle`              |
| ~m~                 | Sets the color to HUD_COLOUR_MID_GREY_MP                                                                                                           | `This is a ~m~test~s~ subtitle`              |
| ~l~                 | Sets the color to HUD_COLOUR_BLACK                                                                                                                 | `This is a ~l~test~s~ subtitle`              |
| ~d~                 | Sets the color to HUD_COLOUR_BLUEDARK                                                                                                              | `This is a ~d~test~s~ subtitle`              |

### Visuals

| Label                      | Description                        | Example                                   |
|----------------------------|------------------------------------|-------------------------------------------|
| ~n~                        | Adds a line break                  | `This is a ~n~ test subtitle`             |
| ~h~                        | Bold text, use again to remove     | `This is a ~h~test~h~ subtitle`           |
| ~bold~                     | Alias for `~h~`                    | `This is a ~bold~test~bold~ subtitle`     |
| ~italic~                   | Italic text, use again to remove   | `This is a ~italic~test~italic~ subtitle` |
| ~ws~                       | Inserts a wanted star              | `~ws~ This is a test subtitle`            |
| ~wanted_star~              | Alias for `~ws~`                   | `~wanted_star~ This is a test subtitle`   |
| &#60;C&#62;...&#60;/C&#62; | Condensed text                     | `This is a <C>test</C> subtitle`          |
| ~EX_R*~                    | Inserts the Rockstar logo          | `~EX_R*~ This is a test subtitle`         |
| ~BLIP_[Sprite]             | Inserts a blip                     | `~BLIP_TAXI~ Your taxi is waiting`        |
| ~INPUT_[Name]              | Inserts a input key                | `~INPUT_ENTER~ to enter the vehicle`      |
| ~INPUTGROUP_[Name]         | Inserts a input group              | `Use ~INPUTGROUP_MOVE~ to walk around`    |
| ~ACCEPT~                   | Inserts a accept prompt            | No example                                |
| ~CANCEL~                   | Inserts a accept prompt            | No example                                |
| ~PAD_[Name]~               | Inserts a gamepad button / control | `~PAD_A~ to enter the vehicle`            |