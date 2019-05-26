using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField] private float _upwardForceMultiplier = (float) 100;

    // Update is called once per frame
    void Update()
    {
        bool pressedFireButton = Input.GetButton("Fire1");
        if (pressedFireButton)
        {
            //if a button is pressed stop gravity and apply an upwards force to the player
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);
        }

        /*
        if(transform.position.y > 6.0 || transform.position.y < 6.0)
        {
            //if the player goes too high or too low restart the game
            SceneManager.LoadScene(0);
        }
        */
    }
}
