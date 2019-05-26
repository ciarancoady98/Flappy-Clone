using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float _speed = (float)5;
    [SerializeField] private bool _randomizeHeight = true;
    [SerializeField] private bool _randomMovement = false;
    [SerializeField] private int _renderPlane = 0;
    private int _direction = 1;

    //we also want to implement random spacing of the crabs

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if(transform.position.x < -15)
        {
            if (_randomizeHeight)
            {
                float yPos = UnityEngine.Random.Range(-3, 3);
                transform.position = new Vector3(15, yPos, _renderPlane);
            }
            else
            {
                transform.position = new Vector3(15, transform.position.y, _renderPlane);
            }
        }
        else if (_randomMovement)
        {
            //randomly change either the direction of velocity of the sprite
            if (transform.position.y <= -3.7 && transform.position.y >= -4.3)
            {
                //continue to move in direction
                float yPos = transform.position.y + (Time.deltaTime * _direction);
                transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
            }
            else
            {
                //change direction
                _direction = _direction * -1;
                float yPos = transform.position.y + (Time.deltaTime * _direction);
                transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
            }
        }
    }
}
