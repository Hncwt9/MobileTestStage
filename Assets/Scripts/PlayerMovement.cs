using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Joystick joystick;

    public float speed = 40f;

    float horizontalMove = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = joystick.Horizontal * speed;

        transform.Translate(Vector3.right * horizontalMove * Time.deltaTime);
    }
}
