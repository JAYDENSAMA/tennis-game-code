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
       animator = GetComponent<Animator>(); 
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
