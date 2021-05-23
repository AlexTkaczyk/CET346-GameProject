﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterScript : MonoBehaviour
{
    public CharacterController controller;
    public Camera cam;
    public Joystick leftJoystick;
    private Vector3 vector3;
    public float speed = 3f;
    private float sensitivity = 1.5f;
    private float rot_x, move_z;
    private float gravity = 14f;
    private float verticalVelocity;
    public Vector3 point1;


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

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 10f))
            {
                if (hit.collider.CompareTag("Item"))
                {
                    bool isPickedUp = Inventory.instance.AddItem(hit.collider.GetComponent<Item>().item);
                    if (isPickedUp)
                    {
                        //Debug.Log("Picked up" + hit.collider.GetComponent<ItemScript>().item.itemName);
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
    }
}
