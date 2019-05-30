using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float _speed = (float)5;
    [SerializeField] private bool _randomizeHeight = true;
    [SerializeField] private bool _randomRedrawPos = false;
    [SerializeField] private int _renderPlane = 0;
    private int pastPlayer = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);

        if (transform.position.x < 0)
        {
            pastPlayer++;
        }

        if (pastPlayer == 1)
        {
            ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementScore();
        }

        if (transform.position.x < -15)
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

            pastPlayer = 0;
        }
    }
}
