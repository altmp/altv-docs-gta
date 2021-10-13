# Time & Date
The time and date influences various parts of the game. Here you can learn more about the system.

## Time
### GTA V
The time is influencing the day-night cycle. The possible range the time can go is from 00h 00m 00s to 23h 59m 59s.
By default the speed of time is multiplied by 30 in GTA V, which means 2 real seconds are equal to one GTA V minute (1000ms real -> 30000ms GTA V).

### alt:V
By default the ingame time isn't synced across the clients and has to be synced manually.
A common way to do this is to set the time and date on connect and then setting the conversation rate with the alt:V function [setMsPerGameMinute](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_setMsPerGameMinute).

**Useful setter**
- setDateTime (serverside) [JS](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setDateTime) [C#](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_SetDateTime_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_)
- setMsPerGameMinute (clientside) [JS](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_setMsPerGameMinute)
- setClockTime (clientside) [JS](https://natives.altv.mp/#/0x47C3B5848C3E45D8)
- addToClockTime (clientside) [JS](https://natives.altv.mp/#/0xD716F30D8C8980E2)
- advanceClockTimeTo (clientside) [JS](https://natives.altv.mp/#/0xC8CA9670B9D83B3B)
- pauseClock (clientside) [JS](https://natives.altv.mp/#/0x4055E40BD2DBEC1D)

**Useful getter**
- getMsPerGameMinute (clientside) [JS](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_getMsPerGameMinute)
- getClockHours (clientside) [JS](https://natives.altv.mp/#/0x25223CA6B4D20B7F)
- getClockMinutes (clientside) [JS](https://natives.altv.mp/#/0x13D2B8ADD79640F2)
- getClockSeconds (clientside) [JS](https://natives.altv.mp/#/0x494E97C2EF27C470)
- getPosixTime (clientside) [JS](https://natives.altv.mp/#/0xDA488F299A5B164E)
- getUtcTime (clientside) [JS](https://natives.altv.mp/#/0x8117E09A19EEF4D3)
- getLocalTime (clientside) [JS](https://natives.altv.mp/#/0x50C7A99057A69748)

## Date
### GTA V
The date is influencing the clouds and the moon of the client. It has different moon phases and it seems that the moon also has libration. The stars aren't affected by the date.
The index of months and days is starting with zero, which means that every day and month has to be calculated with -1 (month 0-11, days 0-30). The week starts with sunday.
**Note: When setting an invalid date (e.g. 2020.12.31) you may experience problems.**

### alt:V
By default the ingame date isn't synced across the clients and has to be synced manually. The common way is the same one as syncing the time.

**Useful setter**
- setDateTime (serverside) [JS](https://docs.altv.mp/js/api/alt-server.Player.html#_altmp_altv_types_alt_server_Player_setDateTime) [C#](https://docs.altv.mp/cs/api/AltV.Net.Elements.Entities.Player.html#AltV_Net_Elements_Entities_Player_SetDateTime_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_)
- setMsPerGameMinute (clientside) [JS](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_setMsPerGameMinute)
- setClockDate (clientside) [JS](https://natives.altv.mp/#/0xB096419DF0D06CE7)
- pauseClock (clientside) [JS](https://natives.altv.mp/#/0x4055E40BD2DBEC1D)

**Useful getter**
- getMsPerGameMinute (clientside) [JS](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_getMsPerGameMinute)
- getClockDayOfWeek (clientside) [JS](https://natives.altv.mp/#/0xD972E4BD7AEB235F)
- getClockDayOfMonth (clientside) [JS](https://natives.altv.mp/#/0x3D10BC92A4DB1D35)
- getClockMonth (clientside) [JS](https://natives.altv.mp/#/0xBBC72712E80257A1)
- getClockYear (clientside) [JS](https://natives.altv.mp/#/0x961777E64BDAF717)
- getPosixTime (clientside) [JS](https://natives.altv.mp/#/0xDA488F299A5B164E)
- getUtcTime (clientside) [JS](https://natives.altv.mp/#/0x8117E09A19EEF4D3)
- getLocalTime (clientside) [JS](https://natives.altv.mp/#/0x50C7A99057A69748)