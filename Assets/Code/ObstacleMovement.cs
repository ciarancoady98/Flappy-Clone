using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float _speed = (float)5;
    [SerializeField] private bool _randomizeHeight = true;
    [SerializeField] private int _renderPlane = 0;

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
    }
}
