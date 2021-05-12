using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject player; //sphere, point2;
    public NavMeshAgent agent;
    public float delta = 1.5f;
    public float speed = 5.0f;
    private Vector3 startPos;
    public Vector3 point1;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startPos;
        if(Vector3.Distance(transform.position, player.transform.position) < 3)
        {
            agent.SetDestination(point1);
        }

        //v.x += delta * Mathf.Sin(Time.time * speed);
        //transform.position = v;
    }
}
