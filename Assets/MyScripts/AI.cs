using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    //public GameObject player; //sphere, point2;
    public CharacterController controller;
    public NavMeshAgent agent;
    public float speed = 5.0f;
    public Vector3 point1;// point2;

    public float time;
    bool isWorking;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!isWorking)
        {
            StartCoroutine(Coroutine());
        }

        //v.x += delta * Mathf.Sin(Time.time * speed);
        //transform.position = v;
    }

    Vector3 getRandomPos()
    {
        float x = Random.Range(-10, 10);
        float z = Random.Range(-20, 20);

        Vector3 pos = new Vector3(x, 0, z);
        return pos;
    }

    IEnumerator Coroutine()
    {
        isWorking = true;
        yield return new WaitForSeconds(time);
        GetNewDestination();
        isWorking = false;
    }

    void GetNewDestination()
    {
        agent.SetDestination(getRandomPos());

        if (Vector3.Distance(controller.transform.position, agent.transform.position) < 5)
        {
            agent.SetDestination(point1);
        }
    }
}
