# Model loading

You need to request some models per natives, before using them. Because natives are non-blocking methods and the game wouldn't wait until the model has been loaded from disk, you need to call them as a async method. Here you can find an example, written in JavaScript how to load them correctly.

# Example
## RequestModel Async Method
```js
export const RequestModel = async (modelHash, timeoutMs = 1000) => {
    return new Promise((resolve, reject) => {
        if (!natives.isModelValid(modelHash)) {
            reject(new Error(`Model does not exist: ${modelHash}`));
            return;
        }

        if (natives.hasModelLoaded(modelHash)) {
            resolve(true);
            return;
        }

        natives.requestModel(modelHash);

        const deadline = new Date().getTime() + timeoutMs;

        const inter = alt.setInterval(() => {
            if (natives.hasModelLoaded(modelHash)) {
                alt.clearInterval(inter);
                resolve(true);
            } else if (deadline < new Date().getTime()) {
                alt.clearInterval(inter);
                const error = `Error: Async loading failed for model: ${modelHash}`;
                alt.log(error);
                reject(new Error(error)); // probably better resolve(false)
            }
        }, 10);
    });
};
```

## Usage of RequestModel Method
```js
const modelHash = alt.hash('mp_m_freemode_01')

await RequestModel(modelHash);
natives.createPed(2, modelHash, 0, 0, 70, 0, false, false);
```

## Credits
This example was provided by \[DE] ithr0n#5837.

## Used APIs
- [hasModelLoaded](https://natives.altv.mp/#/0x98A4EB5D89A0C952)
- [isModelValid](https://natives.altv.mp/#/0xC0296A2EDF545E92)
- [requestModel](https://natives.altv.mp/#/0x963D27A58DF860AC)
- [createPed](https://natives.altv.mp/#/0xD49F9B0955C367DE)
- [setInterval](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_setInterval)
- [clearInterval](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_clearInterval)
- [log](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_log)
- [hash](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_hash)