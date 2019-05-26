using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float _upwardForceMultiplier = (float) 100;

    // Update is called once per frame
    void Update()
    {
        bool pressedFireButton = Input.GetButton("Fire1");
        if (pressedFireButton)
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);
        }
    }
}
