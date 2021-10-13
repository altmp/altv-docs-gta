# Trains
As trains aren't researched that much currently some entries are marked with ???, which means they're either guessed or untested.

## trains{COUNT}.dat structure
These files represent a track and the behaviour of its nodes.

| Line | Data |
| ---- | ---- |
| 1 | {NODE_COUNT} |
| Others | {X} {Y} {Z} {NodeType}\n |

### Node types
A node describes different behaviours on these tracks.

| NodeType | Description |
| -------- | ----------- |
| 0 | Normal Node |
| 1 | Train Stop |
| 2 | ??? (Something for missions) |
| 3 | Unused |
| 4 | Tunnel |
| 5 | Train Stop in Tunnel |

## traintracks.xml structure
Description and behaviour of trains for a track (trains{COUNT}.dat files)

| Key | Description |
| --- | ----------- |
| filename | Name and Path to the trains{COUNT}.dat file |
| trainConfigName | Train config group specified in trains.xml |
| isPingPongTrack | ??? (train switches direction if end of track is reached (always false in default config)) |
| stopsAtStations | If trains stop at Train Stop Nodes |
| MPstopsAtStations | ??? (if train stops in Multiplayer, when stopsAtStations is true (always true in default config)) |
| speed | The Cruise Speed of the train |
| breakingDist | The Distance the train is needing to break until it stops |

## trains.xml structure
Description of train sets

| Key | Subkey of | Description |
| --- | --------- | ----------- |
| train_config_group | | Name of the train group |
| train_config_ref | train_config_group | Subcategory which is the name of the train_config (at least 1 per train_config_group) |
| train_config | | Configuration of a train and its carriage. |
| populate_train_dist | train_config | |
| announce_stations | train_config | Enables/Disable the Announcment of the next Station |
| doors_beep | train_config | Enable/Disable Door Beeping on closing |
| carriages_hang | train_config | |
| link_tracks_with_adjacent_stations | train_config | |
| carriage_gap | train_config | Distance between this engine/carriage and the next one |
| carriage | train_config | Description for each carriage |
| model_name | carriage | Model Name of the engine/carriage |
| max_peds_per_carriage | carriage | How many Peds spawn in the engine/carriage |
| flip_model_dir | carriage | Rotate the Model by 180° |
| do_interior_lights | carriage | Enable/Disable interior lights |
| carriage_vert_offset | carriage | How high the engine/carriage is above the tracks |
| repeat_count | carriage | How often this Carriage Configuration is added to the train |