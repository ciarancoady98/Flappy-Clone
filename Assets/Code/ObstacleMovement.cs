using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float _speed = (float)5;
    [SerializeField] private bool _randomizeHeight = true;
    [SerializeField] private bool _randomRedrawPos = false;
    [SerializeField] private int _renderPlane = 0;

    //we also want to implement random spacing of the crabs

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if(transform.position.x < -15)
        {
            float xPos;
            if (_randomRedrawPos)
            {
                xPos = UnityEngine.Random.Range(15, 40);
            }
            else
            {
                xPos = 15;
            }


            if (_randomizeHeight)
            {
                float yPos = UnityEngine.Random.Range(-3, 3);
                transform.position = new Vector3(xPos, yPos, _renderPlane);
            }
            else
            {
                transform.position = new Vector3(xPos, transform.position.y, _renderPlane);
            }
        }
    }
}
