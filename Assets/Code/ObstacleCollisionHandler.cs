﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if a collision occurs reset the game back to the start
        Debug.Log("Collision Has Occured");
        SceneManager.LoadScene(0);
    }
}
