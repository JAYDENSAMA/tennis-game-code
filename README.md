# TENNIS GAME
# Introduction:
This tennis game, created in Unity, features a player-controlled character and an AI-driven bot. The goal is to rally a ball back and forth, with realistic physics and animations adding to the gameplay experience.

Movement Script: Handles the player's movement and hitting mechanics.
Bot Script: Controls the bot's left-right movement and its ability to aim and hit the ball back unpredictably.
Ball Script: Resets the ball's position when it hits a wall, ensuring seamless gameplay.
The scripts use Unity's physics engine, animation system, and input handling to deliver responsive and engaging gameplay, serving as a solid foundation for further game development.
# Objective of the Game:
The objective is to keep the ball in play by hitting it back and forth between the player and the bot. The player aims to improve their accuracy and timing, while the bot provides a challenging opponent through its calculated movements and randomized targeting.

This documentation provides a detailed overview of each script and highlights the technologies and concepts used to make this game functional and engaging.
# GAME SCRIPTS:
# 1. Movement Script:
# Purpose:

Controls the player's movement and hitting mechanics.

# Key Features:

Allows the player to move in all directions using Input.GetAxisRaw.

Lets the player control an aim target and hit the ball using the "F" key.

Differentiates between moving and hitting states (hitting flag).

# Core Functionality:

![Screenshot 2024-11-21 063650](https://github.com/user-attachments/assets/9cd45a35-c4e9-4479-995e-6497a4e0f1ba)

# 2. Bot Script:
# Purpose: 
Implements AI for the bot to move and hit the ball back to the player.

# Key Features:

Moves left and right along the court based on the ball's position (Move function).

Randomly picks a target to aim at when hitting the ball back.

Applies force to the ball to send it towards a selected target.

Plays animations for hitting actions.

# Core Functionality:
![2](https://github.com/user-attachments/assets/49f5cc6d-ec06-4e41-8a46-35c7a5d67c3b)






