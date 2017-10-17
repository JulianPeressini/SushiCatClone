using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{

    public int scoreValue;   

    void OnTriggerEnter2D(Collider2D other)
    {
        LevelManager.instance.AddScore(scoreValue);
        Destroy(other);
                      
    }
}
