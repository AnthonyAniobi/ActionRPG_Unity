# Action RPG

A 2D action-RPG prototype built with Unity. The project contains a tile-based
world, animated player and enemy characters, directional attacks, collision
combat, and a health display.

![Action RPG gameplay and Unity editor](screenshots/current_app.png)

## Features

- 2D tilemap-based world with terrain, elevation boundaries, bridges, and
  environmental decoration.
- Player movement with running animation and directional facing.
- Directional attacks for side, up, and down inputs.
- Enemy movement and collision-based damage.
- Player health UI.
- Unity's Input System for keyboard and gamepad support.

## Requirements

- Unity `6000.4.2f1`
- A desktop platform supported by Unity

## Getting started

1. Clone the repository.
2. Open the repository folder in Unity Hub using Unity `6000.4.2f1`.
3. Open `Assets/Scenes/WorldScene.unity`.
4. Press **Play** in the Unity Editor.

The project uses Unity packages and assets stored in the repository. Unity may
take a few minutes to import the project the first time it is opened.

## Controls

The default keyboard bindings are configured in
`Assets/InputSystem_Actions.inputactions`.

| Action | Keyboard |
| --- | --- |
| Move | `WASD` or arrow keys |
| Attack left/right | Configured directional attack binding |
| Attack up | Configured directional attack binding |
| Attack down | Configured directional attack binding |

Gamepad bindings are also available through the Input System action asset. Use
the Input Actions editor in Unity to inspect or change bindings.

## Project structure

```text
Assets/
├── Animation/       Character and enemy animations
├── Materials/       Physics and rendering materials
├── Scenes/          Playable Unity scenes
├── Scripts/         Player, enemy, and tilemap gameplay scripts
├── Sprites/         Characters, terrain, effects, and UI art
└── Tiles/           Tilemap and animated tile assets
```

The main gameplay scene is
[`Assets/Scenes/WorldScene.unity`](Assets/Scenes/WorldScene.unity).

## Development

Gameplay scripts are organized by responsibility:

- `Assets/Scripts/PlayerScripts` handles player movement, attacks, and health.
- `Assets/Scripts/EnemyScripts` handles enemy movement and combat.
- `Assets/Scripts/TilemapScripts` handles elevation transitions.

When adding or changing controls, update
`Assets/InputSystem_Actions.inputactions` and verify the associated action
names remain consistent with the gameplay scripts.

## Status

This is an active prototype. Gameplay systems and content may change as the
project develops.