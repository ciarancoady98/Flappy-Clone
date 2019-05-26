using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabRandomMovement : MonoBehaviour
{
    [SerializeField] private bool _randomMovement = false;
    [SerializeField] private float movementAmount = (float)0.1;
    private int _direction = 1;

    //we also want to implement random spacing of the crabs

    //move the crab by the movement amount in the current direction
    private void move()
    {
        float yPos = transform.position.y + (movementAmount * _direction);
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (_randomMovement)
        {
            //randomly change either the direction of velocity of the sprite
            if ((transform.position.y > -4.3 && _direction == -1) || (transform.position.y < -3.7 && _direction == 1))
            {
                //continue to move in direction
                move();
            }
            else
            {
                //change direction
                _direction = _direction * -1;
                move();
            }
        }
    }
}
