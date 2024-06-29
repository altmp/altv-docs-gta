# Model Loading

You need to request some models per natives, before using them. Because natives are non-blocking methods and the game wouldn't wait until the model has been loaded from disk, you need to call them as a async method. Here you can find an example, written in JavaScript how to load them correctly.

> [!NOTE]
> If you need to load model for ped, vehicle or object consider using [LocalVehicle](https://docs.altv.mp/js/api/alt-client.LocalVehicle.html), [LocalPed](https://docs.altv.mp/js/api/alt-client.LocalPed.html) or [LocalObject](https://docs.altv.mp/js/api/alt-client.LocalObject.html) API, these classes load the model under the hood for you.

# Example

## Usage of RequestModel Method
```js
const modelHash = alt.hash('mp_m_freemode_01');

await alt.Utils.requestModel(modelHash);
natives.createPed(2, modelHash, 0, 0, 70, 0, false, false);
```

## Used APIs
- [createPed native](https://natives.altv.mp/#/0xD49F9B0955C367DE)
- [alt.log](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_log)
- [alt.hash](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_hash)
- [alt.Utils.requestModel](https://docs.altv.mp/js/api/alt-client.Utils_1.html#_altmp_altv_types_alt_client_Utils_1_requestModel)
