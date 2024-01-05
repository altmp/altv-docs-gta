# Stream Audio Occlusions

In order to experience altV voice to its full contains, one needs to have certain files within their ressource (mainly MLOs) to enable Audio Occlusions for it.

The purpose of the Audio Occlusion files is to accurately simulate sounds in consideration of obstacles or restrictions, such as rooms or portals.
These files also allows the specific setting of sounds in rooms, such as echo.

## The following files belong to Audio Occlusions:

- a compiled meta file: `*.ymt`
  
- a audio data fale: `*.dat151.rel`
  

In order to have working Audio Occlusions, one has to also create a copy of the `*.dat151.rel` file and delete its `.rel` ending.

In the end, the folder for the audio occlusion files should look like this:

```
example_mlo/
|-> stream/
|    |-> audio/
|    |    |-> 385481254354.ymt
|    |    |-> altvoice_game.dat151
|    |    \-> altvoice_game.dat151.rel
|    |-> REST OF THE RESSOURCE
```

*Note: It is not necessary to create a seperate folder within the stream folder for the Audio Occlusion files, but it's highly recommended due to the overview.*

After importing the needed files into the stream folder, one has to add a line to the `stream.toml` for each pair of `*.dat151` and `*.dat151.rel` files.

## stream.toml

```toml
files = [ 'stream/*' ]

[meta]
'stream/audio/altvoice_game.dat' = 'AUDIO_GAMEDATA'
```

Of course, the `"altvoice"` of the `*.dat151` and `*.dat151.rel` file is the name of the files for the ressource. In this case, it's just used as an example.
