using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{

    float speed = 40;
    Animator animator;
    public Transform ball;
    public Transform aimTarget;

    public Transform[] targets;

    float force = 13; 
    Vector3 targetPosition;

   

    void Start()
    {
        targetPosition = transform.position;
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        targetPosition.z = ball.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    Vector3 PickTarget()
    {
        int randomValue = Random.Range(0, targets.Length);
        return targets[randomValue].position;
    }

    

    
    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("ball")) 
    {
        
        Vector3 targetDirection = aimTarget.position - transform.position;
        
        
        Rigidbody ballRigidbody = other.GetComponent<Rigidbody>();
        if (ballRigidbody != null)
        {
            
            ballRigidbody.velocity = targetDirection.normalized * force + new Vector3(0, 6, 0); 
        }

        
        Vector3 ballDirection = ball.position - transform.position;
        if (ballDirection.x >= 0)
        {
            animator.Play("New Animation bot");
        }
        
    }
}

}