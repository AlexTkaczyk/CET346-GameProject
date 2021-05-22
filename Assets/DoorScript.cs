using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public CharacterController controller;
    public Transform door, target;
    public Vector3 startpos;
    float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(controller.transform.position, door.transform.position) < 5)
        {

        }
    }
}
