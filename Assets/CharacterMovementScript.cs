using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementScript : MonoBehaviour
{
    public CharacterController controller;
    public Joystick leftJoystick, rightJoystick;
    private Vector3 vector3;
    public float speed = 3f;

    private float move_x, move_z;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move_x = leftJoystick.Horizontal * speed;
        move_z = leftJoystick.Vertical * speed;
        vector3 = new Vector3(move_x, 0, move_z);
        controller.Move(vector3 * Time.deltaTime);
    }
}
