using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float speed = 5f;
    bool ballDropped = false;
    public KeyCode ballDrop;

    void Update()
    {
        if (!ballDropped)
        {
            float move = Input.GetAxis("Horizontal");          
            transform.position += transform.right * move * speed * Time.deltaTime;

            if (Input.GetKeyDown(ballDrop))
            {
                ballDropped = true;
                GetComponent<Rigidbody2D>().gravityScale = 0.3f;
            }
        }       
    }
}
