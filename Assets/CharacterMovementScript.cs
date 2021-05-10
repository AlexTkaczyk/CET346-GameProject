using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementScript : MonoBehaviour
{
    public CharacterController controller;
    public Camera camera;
    public Joystick leftJoystick, rightJoystick;
    private Vector3 vector3;
    public float speed = 3f;
    public float sensitivity = 1f;

    private float move_x, move_z, rot_x, rot_y;
    private float lookUp = 60f ;
    private float lookDown = - 60f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move_x = leftJoystick.Horizontal * speed;
        move_z = leftJoystick.Vertical * speed;

        rot_x = rightJoystick.Horizontal * sensitivity;
        rot_y = rightJoystick.Vertical * sensitivity;

        rot_y = Mathf.Clamp(rot_y, lookDown, lookUp);

        vector3 = new Vector3(move_x, 0, move_z);

        transform.Rotate(0, rot_x, 0);
        camera.transform.Rotate(-rot_y, 0, 0);
        vector3 = transform.rotation * vector3;

        controller.Move(vector3 * Time.deltaTime);
    }
}
