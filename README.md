# Batman Night Patrol

A Batman night patrol simulator built in Unity where you control Batman (or the Batmobile) through Gotham City with different operational modes, the iconic Bat-Signal, and alert systems.

## Description

This project is a Unity-based simulation featuring Batman patrolling Gotham City. The game includes character movement controls, multiple operational states (Normal, Stealth, Alert), a toggleable Bat-Signal light projecting the Batman logo into the sky, and an alert system with flashing emergency lights and alarm sounds.

## Features

- **WASD Movement**: Navigate Batman through the city
- **Speed Boost**: Hold Shift to run faster
- **Three Operational Modes**:
  - **Normal Mode (N)**: Standard patrol with regular speed
  - **Stealth Mode (C)**: Reduced speed for covert operations
  - **Alert Mode (Space)**: Activates emergency lights (red/blue flashing) and alarm sound
- **Bat-Signal (B)**: Toggle the iconic spotlight projecting Batman's symbol into the night sky with rotation effect
- **Dynamic Lighting**: Responsive light systems for different modes
- **3D City Environment**: Navigate through a Gotham-inspired cityscape

## Controls

| Key | Action |
|-----|--------|
| **W** | Move forward |
| **S** | Move backward |
| **A** | Rotate left |
| **D** | Rotate right |
| **Shift** | Sprint/Boost speed |
| **N** | Switch to Normal mode |
| **C** | Switch to Stealth mode |
| **Space** | Switch to Alert mode (flashing lights + alarm) |
| **B** | Toggle Bat-Signal on/off |

## Requirements

- Unity 2020.3 or newer
- Git for version control

## Installation & Running

1. Clone this repository

2. Open Unity Hub and add the project folder

3. Open the project in Unity Editor

4. Open the main scene (SampleScene or GothamCity)

5. Press the Play button to start the simulation


## Implementation Details

- **State Management**: Uses C# enums to manage three distinct operational states
- **Physics-based Movement**: Rigidbody and colliders for realistic collision detection
- **Lighting System**: Spotlight for Bat-Signal, point lights for alert effects
- **Audio System**: Looping alarm sound triggered by Alert state

## Development

This project was developed following clean code principles with:
- Modular script architecture
- Inline code documentation
- Regular Git commits with descriptive messages
- Separation of concerns (movement, lighting, audio in separate scripts)

## Future Enhancements

- Animation system for Batman character
- More complex state patterns
- Additional city interaction elements
- Vehicle controller for Batmobile mode

## Credits

Developed as part of a Unity game development assignment.
