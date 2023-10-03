# Versions

# List
The release dates are using the format **YYYY.MM.DD** and PC release dates are preferred.

| Online Version | Buildnumber | Release Date |
| -------------- | ----------- | ------------ |
| 1.24 |  | 2015.04.14 |
| 1.24 | 335.1 | 2015.04.17 |
| 1.25 | 350.1 | 2015.04.30 |
| 1.26 | 350.2 | 2015.05.01 |
| 1.27 | 350.3 | 2015.06.10 |
| 1.28 | 393.2 | 2015.07.08 |
| 1.28.01 | 393.4 | 2015.07.21 |
| 1.29 |  | 2015.09.15 |
| 1.30 |  | 2015.10.20 |
| 1.31 |  | 2015.10.20 |
| 1.32 |  | 2016.01.28 |
| 1.33 |  | 2016.03.15 |
| 1.34 |  | 2016.06.07 |
| 1.35 |  | 2016.07.12 |
| 1.36 |  | 2016.10.04 |
| 1.37 |  | 2016.12.13 |
| 1.38 |  | 2017.03.14 |
| 1.39 |  | 2017.04.05 |
| 1.40 |  | 2017.06.13 |
| 1.41 |  | 2017.08.29 |
| 1.42 |  | 2017.12.12 |
| 1.43 |  | 2018.03.20 |
| 1.44 |  | 2018.06.24 |
| 1.45 |  | 2018.10.16 |
| 1.46 | 1604 | 2018.12.11 |
| 1.47 |  | 2019.06.23 |
| 1.48 | 1737 | 2019.06.25 |
| 1.49 |  | 2019.12.12 |
| 1.50 | 1868 | 2019.12.12 |
| 1.50 | 1868.1 | 2020.03.31 |
| 1.51 | 2060 | 2020.08.11 |
| 1.52 | 2189 | 2020.12.15 |
| 1.53 | 2215 | 2021.02.10 |
| 1.54 |  | 2021.03.16 |
| 1.57 | 2372 | 2021.07.20 |
| 1.58 | 2545 | 2021.12.15 |
| 1.59 |  | 2022.04.26 |
| 1.60 | 2628 | 2022.05.17 |
| 1.61 | 2699 | 2022.07.26 |
| 1.63 | 2699.16 | 2022.10.25 |
| 1.64 | 2802 | 2022.12.13 |
| 1.66 | 2824 | 2023.02.01 |
| 1.67 | 2944 | 2023.06.13 |
| 1.67 | 3028 | 2023.10.03 |

# Useful Snippets
## Enums
```js
let versions = [
    {version: "1.24", buildnumber: null, release: "2015.04.14"},
    {version: "1.24", buildnumber: "335.1", release: "2015.04.17"},
    {version: "1.25", buildnumber: "350.1", release: "2015.04.30"},
    {version: "1.26", buildnumber: "350.2", release: "2015.05.01"},
    {version: "1.27", buildnumber: "350.3", release: "2015.06.10"},
    {version: "1.28", buildnumber: "393.2", release: "2015.07.08"},
    {version: "1.28.01", buildnumber: "393.4", release: "2015.07.21"},
    {version: "1.29", buildnumber: null, release: "2015.09.15"},
    {version: "1.30", buildnumber: null, release: "2015.10.20"},
    {version: "1.31", buildnumber: null, release: "2015.10.20"},
    {version: "1.32", buildnumber: null, release: "2016.01.28"},
    {version: "1.33", buildnumber: null, release: "2016.03.15"},
    {version: "1.34", buildnumber: null, release: "2016.06.07"},
    {version: "1.35", buildnumber: null, release: "2016.07.12"},
    {version: "1.36", buildnumber: null, release: "2016.10.04"},
    {version: "1.37", buildnumber: null, release: "2016.12.13"},
    {version: "1.38", buildnumber: null, release: "2017.03.14"},
    {version: "1.39", buildnumber: null, release: "2017.04.05"},
    {version: "1.40", buildnumber: null, release: "2017.06.13"},
    {version: "1.41", buildnumber: null, release: "2017.08.29"},
    {version: "1.42", buildnumber: null, release: "2017.12.12"},
    {version: "1.43", buildnumber: null, release: "2018.03.20"},
    {version: "1.44", buildnumber: null, release: "2018.06.24"},
    {version: "1.45", buildnumber: null, release: "2018.10.16"},
    {version: "1.46", buildnumber: "1604", release: "2018.12.11"},
    {version: "1.47", buildnumber: null, release: "2019.06.23"},
    {version: "1.48", buildnumber: "1737", release: "	2019.06.25"},
    {version: "1.49", buildnumber: null, release: "	2019.12.12"},
    {version: "1.50", buildnumber: "1868", release: "2019.12.12"},
    {version: "1.50", buildnumber: "1868.1", release: "2020.03.31"},
    {version: "1.51", buildnumber: "2060", release: "2020.08.11"},
    {version: "1.52", buildnumber: "2189", release: "2020.12.15"},
    {version: "1.53", buildnumber: "2215", release: "2021.02.10"},
    {version: "1.54", buildnumber: null, release: "2021.03.16"},
    {version: "1.57", buildnumber: "2372", release: "2021.07.20"},
    {version: "1.58", buildnumber: "2545", release: "2021.12.15"},
    {version: "1.59", buildnumber: null, release: "2022.04.26"},
    {version: "1.60", buildnumber: "2628", release: "2022.05.17"},
    {version: "1.61", buildnumber: "2699", release: "2022.07.26"},
    {version: "1.63", buildnumber: "2699.16", release: "2022.10.25"},
    {version: "1.64", buildnumber: "2802", release: "2022.12.13"},
    {version: "1.66", buildnumber: "2824", release: "2023.02.01"},
    {version: "1.67", buildnumber: "2944", release: "023.06.13"}
];
```
