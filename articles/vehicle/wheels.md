# Vehicle wheels

## Setting wheels

Vehicle wheels should be set using the `SetWheels(wheelType, wheelId)` method provided by alt:V.
This method is available to the respective vehicle instance.

> [!TIP]
> For cars the `SetWheels(wheelType, wheelId)` method is sufficient to change all 4 wheels. For motorcycles additionally
> the `SetRearWheels(wheelId)` method is available.

> [!TIP]
> See <a href='https://forge.plebmasters.de/vehiclemods'>Pleb Masters: Forge</a> for a full list of vehicle wheels.

**Wheel types**

| Id  | Description |
|-----|-------------|
| 0   | Sport       |
| 1   | Muscle      |
| 2   | Lowrider    |
| 3   | SUV         |
| 4   | Offroad     |
| 5   | Tuner       |
| 6   | Bike Wheels |
| 7   | High End    |

## Customizing wheels

### Methods

> [!WARNING]
> Not all of the features have a visual effect and may have needed a combination to adjust the physics of the vehicle.
> Changes to the values should always be done in small steps.

| Modifier    | Setter                                  | Getter                          |
|-------------|-----------------------------------------|---------------------------------|
| Camber      | `SetWheelCamber(wheelIndex, camber)`    | `GetWheelCamber(wheelIndex)`    |
| Height      | `SetWheelHeight(wheelIndex, height)`    | `GetWheelHeight(wheelIndex)`    |
| Rim Radius  | `SetWheelRimRadius(wheelIndex, radius)` | `GetWheelRimRadius(wheelIndex)` |
| Track Width | `SetTrackWidth(wheelIndex, width)`      | `GetTrackWidth(wheelIndex)`     |
| Tyre Radius | `SetTyreRadius(wheelIndex, radius)`     | `GetTyreRadius(wheelIndex)`     |
| Tyre Width  | `SetTyreWidth(wheelIndex, width)`       | `GetTyreWidth(wheelIndex)`      |

### Sample

The example modifies a Sultan RS camber and track width:

# [Server](#tab/tabid-1)

```js
const veh = new alt.Vehicle("sultanrs", 0, 0, 72, 0, 0, 0);
// As the data isn't synced by itself we need a way to sync it. The easiest way in this case is by using stream synced meta data.
veh.setStreamSyncedMeta("wheelMod", {camber: -0.25, trackWidth: 0.85});
```

# [Client](#tab/tabid-2)

```js
alt.on("gameEntityCreate", (entity) => {
    // We need to reapply the values when the vehicle gets streamed again, so we check for the type of the entity and if it has the wheelMod meta data set
    if (!(entity instanceof alt.Vehicle)) return;
    if (!entity.hasStreamSyncedMeta("wheelMod")) return;
    // To avoid duplicated code with the meta change event we move the modification part to it's own function
    modWheels(entity, entity.getStreamSyncedMeta("wheelMod"));
});

alt.on("streamSyncedMetaChange", (entity, key, value, oldValue) => {
    // Checking conditions if we should apply the modifications
    if (key !== "wheelMod") return;
    if (!(entity instanceof alt.Vehicle)) return;
    modWheels(entity, value);
});

function modWheels(vehicle, data) {
    // Going to use a loop as we need to apply the setters to all wheels
    // This can be changed to e.g. only modify the front or back wheels
    for (let i = 0; i < vehicle.wheelsCount; i++) {
        vehicle.setWheelCamber(i, data.camber);
        vehicle.setWheelTrackWidth(i, data.trackWidth);
    }
}
```