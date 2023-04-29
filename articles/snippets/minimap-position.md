# Minimap Position

You can modify the minimap position with alt:V internal function.

`T` - Top \
`B` - Bottom \
`R` - Right \
`L` - Left

```js
import { setMinimapComponentPosition } from 'alt-client';
import { setBigmapActive } from 'natives';

// Player + Compass + HP
setMinimapComponentPosition('minimap', 'L', 'B', 0.811, -0.768, 0.150, 0.188888);
// Purple Route
setMinimapComponentPosition('minimap_mask', 'L', 'B', 0.8355, -0.738, 0.111, 0.159);
// Map
setMinimapComponentPosition('minimap_blur', 'L', 'B', 0.7855, -0.748, 0.266, 0.237);

// You should use this native to see the results.
setBigmapActive(true, false);
setBigmapActive(false, false);
```

# Used APIs

- [setMinimapComponentPosition](https://docs.altv.mp/js/api/alt-client.html#_altmp_altv_types_alt_client_setMinimapComponentPosition_1)
- [setBigmapActive](https://natives.altv.mp/#/0x231C8F89D0539D8F)
