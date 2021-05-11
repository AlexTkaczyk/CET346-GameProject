using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementScript : MonoBehaviour
{
    public CharacterController controller;
    public Joystick leftJoystick;
    private Vector3 vector3;
    public float speed = 3f;
    public float sensitivity = 1f;
    private float rot_x, move_z;
    private float gravity = 14f;
    private float verticalVelocity;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move_z = leftJoystick.Vertical * speed;
        rot_x = leftJoystick.Horizontal * sensitivity;
        transform.Rotate(0, rot_x, 0);  

        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        
        vector3 = new Vector3(rot_x, verticalVelocity, move_z);
        vector3 = transform.rotation * vector3;
        controller.Move(vector3 * Time.deltaTime);
    }
}
