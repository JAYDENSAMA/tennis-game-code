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
3. Movement Script
Purpose
Handles player-controlled movement and targeting in the game.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Transform aimTarget;
    float speed = 4f;
    bool hitting;
    float force = 13;

    Animator animator;
    public Transform ball;
    void Start()
    {
       animator = GetComponent<Animator(); 
    }

    void Update()
    {
       float h = Input.GetAxisRaw("Horizontal");
       float v = Input.GetAxisRaw("Vertical");

       if (Input.GetKeyDown(KeyCode.F)) 
       {
           hitting = true;  
       }
       else if (Input.GetKeyUp(KeyCode.F))
       {
           hitting = false;
       }

       if (hitting)
       {
           aimTarget.Translate(new Vector3(h, 0, 0) * speed * 2 * Time.deltaTime); 
       }                    

       if ((h != 0 || v != 0) && !hitting)
       {
           transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime); 
       }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            Vector3 dir = aimTarget.position - transform.position;
            other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0, 6, 0);
            animator.Play("New Animation");

            Vector3 ballDir = ball.position - transform.position;
            if (ballDir.x >= 0)                                    
            {
                animator.Play("New Animation");                        
            }
        }
    }
}
