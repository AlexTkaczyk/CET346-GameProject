using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementScript : MonoBehaviour
{
    public CharacterController controller;
    public Camera camera;
    public Joystick leftJoystick;
    private Vector3 vector3;
    public float speed = 3f;
    public float sensitivity = 1f;
    private float rot_x, move_z;

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

        vector3 = new Vector3(rot_x, 0, move_z);
        vector3 = transform.rotation * vector3;
        controller.Move(vector3 * Time.deltaTime);
    }
}
