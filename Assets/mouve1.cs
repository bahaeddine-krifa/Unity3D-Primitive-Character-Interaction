using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouve1 : MonoBehaviour
{
    public float speed; // Declare moveSpeed here

    private Vector3 moveDirection; // Declare moveDirection here
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Vector3.zero; // Reset the movement direction each frame

        if  (Input.GetKey(KeyCode.Z))
        {
            moveDirection += transform.forward; // Move forward
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveDirection -= transform.forward; // Move backward
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += transform.right; // Move right
        }

        if (Input.GetKey(KeyCode.Q))
        {
            moveDirection -= transform.right; // Move left
        }

        // Normalize the direction vector to ensure consistent speed
        moveDirection.Normalize();

        // Move the character based on the input and speed
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
