using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalSpeed = 100f;
    public float verticalSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = 0;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            yAxis = -1;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            yAxis = 1;
        }
        Vector3 movementVector = horizontalSpeed * (transform.right * horizontal + transform.forward * vertical) + verticalSpeed * transform.up * yAxis;
        this.GetComponent<CharacterController>().Move(movementVector);
    }
}
