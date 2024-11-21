# TENNIS GAME
# Introduction:
This tennis game, created in Unity, features a player-controlled character and an AI-driven bot. The goal is to rally a ball back and forth, with realistic physics and animations adding to the gameplay experience.

#### Movement Script: Handles the player's movement and hitting mechanics.

#### Bot Script: Controls the bot's left-right movement and its ability to aim and hit the ball back unpredictably.

#### Ball Script: Resets the ball's position when it hits a wall, ensuring seamless gameplay.

The scripts use Unity's physics engine, animation system, and input handling to deliver responsive and engaging gameplay, serving as a solid foundation for further game development.
# Objective of the Game:
The objective is to keep the ball in play by hitting it back and forth between the player and the bot. The player aims to improve their accuracy and timing, while the bot provides a challenging opponent through its calculated movements and randomized targeting.

This documentation provides a detailed overview of each script and highlights the technologies and concepts used to make this game functional and engaging.
# GAME SCRIPTS:
# 1. Movement Script:
## Purpose:

Controls the player's movement and hitting mechanics.

## Key Features:

Allows the player to move in all directions using Input.GetAxisRaw.

Lets the player control an aim target and hit the ball using the "F" key.

Differentiates between moving and hitting states (hitting flag).

## Core Functionality:

![Screenshot 2024-11-21 063650](https://github.com/user-attachments/assets/9cd45a35-c4e9-4479-995e-6497a4e0f1ba)

# 2. Bot Script:
## Purpose: 
Implements AI for the bot to move and hit the ball back to the player.

## Key Features:

Moves left and right along the court based on the ball's position (Move function).

Randomly picks a target to aim at when hitting the ball back.

Applies force to the ball to send it towards a selected target.

Plays animations for hitting actions.

## Core Functionality:
![2](https://github.com/user-attachments/assets/49f5cc6d-ec06-4e41-8a46-35c7a5d67c3b)

# 1. Ball Script

## Purpose:

Manages the ball's behavior and ensures it resets when out of play.

## Key Features:

Stores the ball's initial position (initialPos) at the start.

Detects collision with the wall using OnCollisionEnter.

Resets the ball's velocity and position upon collision with a tagged "wall".

## Core Functionality:
![Screenshot 2024-11-21 065949](https://github.com/user-attachments/assets/936dda5a-f922-4644-ac01-ec0291907dea)

# Technologies Used:
Unity Physics: Manages ball movement and realistic interactions.

Animator: Triggers animations for hitting actions.

Input System: Captures player inputs for movement and hitting.

Tagging: Identifies specific objects like "ball" and "wall" for interactions.

# 1. Prerequisites
Unity installed on your system.

A fully set up Unity project with the following:

Proper hierarchy and game objects:

Player, Bot, Ball, Court, and Walls are already present.

Required assets (models, animations, and prefabs) imported and configured.

All necessary scripts already attached to the respective GameObjects.

# 2. How to Run the Game

## Open the Unity Project:

Launch Unity Hub and open the project containing the scripts.
### Scene Setup:

Ensure the scene contains the following GameObjects:
### Player: With the Movement script attached.
### Bot: With the Bot script attached.
### Ball: With the Ball script attached.
### Court and Walls: Properly set up for gameplay boundaries.

## Script Configuration:

All script fields (e.g., ball, aimTarget, targets) should already be assigned in the Inspector.

Confirm that the ball and wall objects are tagged correctly:

Ball tagged as "ball".

Walls tagged as "wall".

Physics and Animations:


Ensure all GameObjects have the required Colliders and Rigidbody components.

Confirm animations are linked and referenced in the Animator Controllers for both the Player and the Bot.

## Run the Game:

Press the Play button in Unity's Editor.

Use the controls to move the player:

Arrow Keys/WASD: Move the player.

F Key: Aim and hit the ball.

Watch the bot automatically respond to the ball and return it.

# IAMGES
![tpose](https://github.com/user-attachments/assets/724f923e-0e8f-4512-bca0-421db1bf6662)
![tpose3](https://github.com/user-attachments/assets/2bf58437-d620-4d2d-8fbe-35e965f39117)



# Conclusion
The provided tennis game project demonstrates the use of Unity's physics, animation, and scripting capabilities to create an engaging and interactive experience. By leveraging scripts such as Movement, Bot, and Ball, the game ensures smooth player controls, responsive AI behavior, and realistic ball interactions.

This project is a great foundation for further development, allowing for enhancements like improved AI logic, multiplayer support, and additional gameplay features. With the setup complete, you are ready to explore, play, and expand the game to new heights!


# NOTE:
IF YOU WANT TO PLAY THE GAME WITHOUT DOWNLOADING UNITY HUB YOU CAN DIRECTLY DOWNLOADE  THE GAME FROM THE LINK  
https://github.com/JAYDENSAMA/TENNIS-GAME










