using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacleLeft : MonoBehaviour
{
    [SerializeField] private float _speed = (float)5;
    [SerializeField] private bool _randomizeHeight = true;
    [SerializeField] private bool _randomMovement = false;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if(transform.position.x < -15)
        {
            if (_randomizeHeight)
            {
                float yPos = UnityEngine.Random.Range(-3, 3);
                transform.position = new Vector3(15, yPos, 0);
            }
            else if (_randomMovement)
            {
                //randomly change either the direction of velocity of the sprite

            }
            else
            {
                transform.position = new Vector3(15, transform.position.y, 0);
            }
        }
    }
}
