using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacleLeft : MonoBehaviour
{
    [SerializeField] private float _speed = (float)5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if(transform.position.x < -15)
        {
            float yPos = UnityEngine.Random.Range(-3, 3);
            transform.position = new Vector3(15, yPos, 0);
        }
    }
}
